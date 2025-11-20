using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class PayrollControl : UserControl
    {
        DBHelper db = new DBHelper();

        public PayrollControl()
        {
            InitializeComponent();
        }

        private void PayrollControl_Load(object sender, EventArgs e)
        {
            LoadPayrollList();
            LoadSummaryCards();
        }

        // ============================================================
        //  LOAD PAYROLL LIST INTO GRID
        // ============================================================
        private void LoadPayrollList()
        {
            try
            {
                string sql = @"
                    SELECT 
                        p.PayrollID,
                        e.FullName AS Employee,
                        p.PayPeriodStart,
                        p.PayPeriodEnd,
                        p.TotalPay,
                        p.NetPay
                    FROM Payroll p
                    JOIN Employees e ON p.EmployeeID = e.EmployeeID
                    ORDER BY p.PayrollID DESC";

                DataTable dt = db.GetData(sql);

                dgvPayroll.DataSource = dt;

                // Add View Button
                if (!dgvPayroll.Columns.Contains("btnView"))
                {
                    DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
                    viewBtn.HeaderText = "";
                    viewBtn.Text = "View";
                    viewBtn.Name = "btnView";
                    viewBtn.Width = 80;
                    viewBtn.UseColumnTextForButtonValue = true;
                    dgvPayroll.Columns.Add(viewBtn);
                }

                dgvPayroll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPayroll.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvPayroll.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payroll list: " + ex.Message);
            }
        }

        // ============================================================
        //  VIEW BUTTON CLICK → OPEN DETAILS POPUP
        // ============================================================
        private void dgvPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPayroll.Columns[e.ColumnIndex].Name == "btnView")
            {
                int payrollId = Convert.ToInt32(
                    dgvPayroll.Rows[e.RowIndex].Cells["PayrollID"].Value);

                // Load PayrollDetailsControl with the payroll ID
                PayrollDetailsControl details = new PayrollDetailsControl(payrollId);

                // Create a popup form to show the details
                Form popup = new Form();
                popup.Text = "Payroll Details";
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.Size = new Size(1100, 700);
                popup.FormBorderStyle = FormBorderStyle.FixedDialog;
                popup.MaximizeBox = false;
                popup.MinimizeBox = false;

                details.Dock = DockStyle.Fill;
                popup.Controls.Add(details);

                popup.ShowDialog();
            }
        }

        // ============================================================
        //  SUMMARY CARDS (right side)
        // ============================================================
        private void LoadSummaryCards()
        {
            try
            {
                decimal totalCost = Convert.ToDecimal(
                    db.ExecuteScalar("SELECT IFNULL(SUM(TotalPay),0) FROM Payroll"));

                decimal totalSalary = Convert.ToDecimal(
                    db.ExecuteScalar("SELECT IFNULL(SUM(NetPay),0) FROM Payroll"));

                decimal balance = totalCost - totalSalary;

                lblTotalCost.Text = totalCost.ToString("C");
                lblSalaryPaid.Text = totalSalary.ToString("C");
                lblBalance.Text = balance.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading summary: " + ex.Message);
            }
        }
    }
}
