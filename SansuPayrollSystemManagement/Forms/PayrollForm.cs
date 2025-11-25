using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class PayrollForm : Form
    {
        private DBHelper db = new DBHelper();

        public PayrollForm()
        {
            InitializeComponent();
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
            LoadPayrollHistory();
        }

        // ============================
        // LOAD EMPLOYEES TO COMBOBOX
        // ============================
        private void LoadEmployeeList()
        {
            try
            {
                string sql = "SELECT EmployeeID, FullName FROM Employees ORDER BY FullName ASC";
                DataTable dt = db.GetData(sql);
                cboEmployee.DataSource = dt;
                cboEmployee.DisplayMember = "FullName";
                cboEmployee.ValueMember = "EmployeeID";
                cboEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        // ============================
        // LOAD PAYROLL HISTORY TABLE
        // ============================
        private void LoadPayrollHistory()
        {
            try
            {
                string sql = @"SELECT 
                                p.PayrollID AS 'ID',
                                e.FullName AS 'Employee',
                                p.PayPeriodStart AS 'Start Date',
                                p.PayPeriodEnd AS 'End Date',
                                p.RegularHours AS 'Regular Hrs',
                                p.OvertimeHours AS 'OT Hrs',
                                p.TotalPay AS 'Total Pay',
                                p.Deductions AS 'Deductions',
                                p.NetPay AS 'Net Pay'
                              FROM Payroll p
                              JOIN Employees e ON p.EmployeeID = e.EmployeeID
                              ORDER BY p.PayPeriodEnd DESC";

                DataTable dt = db.GetData(sql);
                guna2DataGridViewPayroll.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payroll history: " + ex.Message);
            }
        }

        // ============================
        // COMPUTE PAYROLL
        // ============================
        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (cboEmployee.SelectedValue == null)
            {
                MessageBox.Show("Please select an employee first.", "Missing Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int empId = Convert.ToInt32(cboEmployee.SelectedValue);
                DateTime start = dtpStart.Value.Date;
                DateTime end = dtpEnd.Value.Date;

                if (end < start)
                {
                    MessageBox.Show("End date cannot be earlier than start date.", "Invalid Dates",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Count present days (Mon–Fri)
                string sqlDays = @"
                    SELECT COUNT(*)
                    FROM Attendance
                    WHERE EmployeeID = @id
                      AND Date BETWEEN @start AND @end
                      AND TimeIn IS NOT NULL
                      AND TimeOut IS NOT NULL
                      AND Status = 'Present'
                      AND DAYOFWEEK(Date) BETWEEN 2 AND 6";

                var pDays = new MySqlParameter[]
                {
                    new MySqlParameter("@id", empId),
                    new MySqlParameter("@start", start),
                    new MySqlParameter("@end", end)
                };

                int daysWorked = Convert.ToInt32(db.ExecuteScalar(sqlDays, pDays));

                // DAILY RATE
                double dailyRate = 550.00;

                // Base salary
                double overtimeHours = 0.0;
                double basePay = daysWorked * dailyRate;

                // ============================
                // GOVERNMENT CONTRIBUTIONS
                // ============================

                double monthlySalary = dailyRate * 26;

                // SSS
                double sss = monthlySalary * 0.045;
                if (sss > 900) sss = 900;

                // PhilHealth
                double philHealth = monthlySalary * 0.025;

                // Pag-IBIG
                double pagIbig = 100;

                // Total government deductions
                double govDeductions = sss + philHealth + pagIbig;

                // No other deductions for now
                double otherDeductions = 0;

                double deductions = govDeductions + otherDeductions;
                double totalPay = basePay;
                double netPay = totalPay - deductions;

                // ============================
                // DISPLAY RESULTS TO UI
                // ============================

                txtSSS.Text = sss.ToString("F2");
                txtPhilHealth.Text = philHealth.ToString("F2");
                txtPagIbig.Text = pagIbig.ToString("F2");

                txtRegularHours.Text = daysWorked.ToString("F0");
                txtOvertimeHours.Text = overtimeHours.ToString("F2");
                txtTotalPay.Text = totalPay.ToString("F2");
                txtDeductions.Text = deductions.ToString("F2");
                txtNetPay.Text = netPay.ToString("F2");

                lblStatus.Text = $"Payroll computed successfully for {cboEmployee.Text} ({daysWorked} days).";

                // Lock fields
                txtRegularHours.ReadOnly = true;
                txtOvertimeHours.ReadOnly = true;
                txtTotalPay.ReadOnly = true;
                txtDeductions.ReadOnly = true;
                txtNetPay.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error computing payroll: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================
        // SAVE PAYROLL RECORD
        // ============================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboEmployee.SelectedValue == null || string.IsNullOrWhiteSpace(txtNetPay.Text))
            {
                MessageBox.Show("Please compute payroll first before saving.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"INSERT INTO Payroll 
                              (EmployeeID, PayPeriodStart, PayPeriodEnd, RegularHours, OvertimeHours, TotalPay, Deductions, NetPay)
                              VALUES (@id, @start, @end, @reg, @ot, @total, @ded, @net)";

                MySqlParameter[] p = {
                    new MySqlParameter("@id", cboEmployee.SelectedValue),
                    new MySqlParameter("@start", dtpStart.Value.Date),
                    new MySqlParameter("@end", dtpEnd.Value.Date),
                    new MySqlParameter("@reg", Convert.ToDecimal(txtRegularHours.Text)),
                    new MySqlParameter("@ot", Convert.ToDecimal(txtOvertimeHours.Text)),
                    new MySqlParameter("@total", Convert.ToDecimal(txtTotalPay.Text)),
                    new MySqlParameter("@ded", Convert.ToDecimal(txtDeductions.Text)),
                    new MySqlParameter("@net", Convert.ToDecimal(txtNetPay.Text))
                };

                int rows = db.ExecuteNonQuery(sql, p);

                if (rows > 0)
                {
                    MessageBox.Show("Payroll saved successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPayrollHistory();
                }
                else
                {
                    MessageBox.Show("Failed to save payroll record.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payroll: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnBackDashboard_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new DashboardForm("Admin").ShowDialog();
        //    this.Close();
        //}

        private void btnGeneratePayslip_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewPayroll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payroll record first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int payrollId = Convert.ToInt32(guna2DataGridViewPayroll.SelectedRows[0].Cells["ID"].Value);

            MessageBox.Show($"Payslip generation for Payroll ID {payrollId} will be implemented here.",
                            "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
