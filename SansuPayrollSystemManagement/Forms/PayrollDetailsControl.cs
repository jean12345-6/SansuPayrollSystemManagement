using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class PayrollDetailsControl : UserControl
    {
        DBHelper db = new DBHelper();
        private int _payrollId;

        // ✅ Constructor that accepts payrollId
        public PayrollDetailsControl(int payrollId)
        {
            InitializeComponent();
            _payrollId = payrollId;
            LoadPayrollDetails();
        }

        private void LoadPayrollDetails()
        {
            try
            {
                string sql = @"
                    SELECT 
                        p.*,
                        e.FullName,
                        e.Position,
                        e.Salary AS MonthlySalary,
                        e.DailyRate
                    FROM Payroll p
                    JOIN Employees e ON p.EmployeeID = e.EmployeeID
                    WHERE p.PayrollID = @id";

                DataTable dt = db.GetData(sql, new MySqlParameter[]
{
    new MySqlParameter("@id", _payrollId)
});

                if (dt.Rows.Count == 0)
                    return;

                DataRow row = dt.Rows[0];

                // BASIC INFORMATION
                lblEmployeeName.Text = row["FullName"].ToString();
                lblPosition.Text = row["Position"].ToString();
                lblPeriod.Text =
                    $"{Convert.ToDateTime(row["PayPeriodStart"]).ToString("MMM dd")} - " +
                    $"{Convert.ToDateTime(row["PayPeriodEnd"]).ToString("MMM dd, yyyy")}";

                // EARNINGS
                txtDaysWorked.Text = row["DaysWorked"].ToString();
                txtOvertimeHours.Text = row["OvertimeHours"].ToString();
                txtBasicSalary.Text = row["BasicSalary"].ToString();
                txtGrossPay.Text = row["GrossPay"].ToString();

                // DEDUCTIONS
                txtSSS.Text = row["SSS"].ToString();
                txtPhilHealth.Text = row["PhilHealth"].ToString();
                txtPagIbig.Text = row["PagIbig"].ToString();
                txtLateDeduction.Text = row["LateDeduction"].ToString();
                txtAbsenceDeduction.Text = row["AbsenceDeduction"].ToString();
                txtTotalDeductions.Text = row["TotalDeductions"].ToString();

                // NET PAY
                txtNetPay.Text = row["NetPay"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payroll details: " + ex.Message);
            }
        }
    }
}