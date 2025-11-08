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

        // ✅ Load employee names into combo box
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

        // ✅ Load saved payroll records into DataGridView
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

        // ✅ Compute payroll for selected employee
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

                // 1) Count worked DAYS (Mon–Fri only), present, with TimeIn/TimeOut
                string sqlDays = @"
            SELECT COUNT(*)
            FROM Attendance
            WHERE EmployeeID = @id
              AND Date BETWEEN @start AND @end
              AND TimeIn IS NOT NULL
              AND TimeOut IS NOT NULL
              AND Status = 'Present'
              AND DAYOFWEEK(Date) BETWEEN 2 AND 6";// --Mon(2)..Fri(6);
        
        var pDays = new MySqlParameter[]
        {
            new MySqlParameter("@id", empId),
            new MySqlParameter("@start", start),
            new MySqlParameter("@end", end)
        };

                int daysWorked = Convert.ToInt32(db.ExecuteScalar(sqlDays, pDays));

                // 2) Fixed daily rate (or read from DB if you add Employees.DailyRate)
                double dailyRate = 550.00;

                // 3) Pure daily-pay computation (NO overtime)
                double overtimeHours = 0.0;     // force no OT
                double basePay = daysWorked * dailyRate;
                double totalPay = basePay;
                double deductions = totalPay * 0.05;   // sample deduction
                double netPay = totalPay - deductions;

                // 4) Display (RegularHours textbox shows DAYS worked)
                txtRegularHours.Text = daysWorked.ToString("F0");
                txtOvertimeHours.Text = overtimeHours.ToString("F2");
                txtTotalPay.Text = totalPay.ToString("F2");
                txtDeductions.Text = deductions.ToString("F2");
                txtNetPay.Text = netPay.ToString("F2");

                lblStatus.Text = $"Payroll computed successfully for {cboEmployee.Text} ({daysWorked} days).";

                // lock fields
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

        // ✅ Save computed payroll
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
                    MessageBox.Show("Payroll saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPayrollHistory();
                }
                else
                {
                    MessageBox.Show("Failed to save payroll record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payroll: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Return to Dashboard
        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashboardForm("Admin").ShowDialog();
            this.Close();
        }

        // ✅ Optional: Generate Payslip (PDF placeholder)
        private void btnGeneratePayslip_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewPayroll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payroll record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int payrollId = Convert.ToInt32(guna2DataGridViewPayroll.SelectedRows[0].Cells["ID"].Value);
            MessageBox.Show($"Payslip generation for Payroll ID {payrollId} will be implemented here.",
                            "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
