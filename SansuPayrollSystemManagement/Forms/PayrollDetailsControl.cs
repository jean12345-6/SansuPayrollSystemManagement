using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class PayrollDetailsControl : UserControl
    {
        private readonly DBHelper db = new DBHelper();
        private readonly int _payrollId;

        private PrintDocument payslipDocument = new PrintDocument();

        public PayrollDetailsControl(int payrollId)
        {
            InitializeComponent();
            _payrollId = payrollId;

            payslipDocument.PrintPage += PayslipDocument_PrintPage;
        }

        private void PayrollDetailsControl_Load(object sender, EventArgs e)
        {
            LoadPayrollDetails();
        }

        // =========================================================
        //  LOAD PAYROLL DETAILS (FROM Payroll TABLE ONLY)
        // =========================================================
        private void LoadPayrollDetails()
        {
            try
            {
                string sql = @"
                    SELECT 
                        p.*,
                        e.FullName,
                        e.Position
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

                // Header info
                lblEmployeeName.Text = row["FullName"].ToString();
                lblPosition.Text = row["Position"].ToString();

                DateTime periodStart = Convert.ToDateTime(row["PayPeriodStart"]);
                DateTime periodEnd = Convert.ToDateTime(row["PayPeriodEnd"]);
                lblPeriod.Text = $"{periodStart:MMM dd} - {periodEnd:MMM dd, yyyy}";

                // Earnings
                int daysWorked = row["DaysWorked"] != DBNull.Value ? Convert.ToInt32(row["DaysWorked"]) : 0;
                decimal overtimeHours = row["OvertimeHours"] != DBNull.Value ? Convert.ToDecimal(row["OvertimeHours"]) : 0m;
                decimal basicSalary = row["BasicSalary"] != DBNull.Value ? Convert.ToDecimal(row["BasicSalary"]) : 0m;
                decimal grossPay = row["GrossPay"] != DBNull.Value ? Convert.ToDecimal(row["GrossPay"]) : 0m;

                lblDaysWorkedValue.Text = daysWorked.ToString();
                lblOvertimeHoursValue.Text = overtimeHours.ToString("0.##");
                lblBasicSalaryValue.Text = FormatPeso(basicSalary);
                lblGrossPayValue.Text = FormatPeso(grossPay);

                // Deductions
                decimal sss = row["SSS"] != DBNull.Value ? Convert.ToDecimal(row["SSS"]) : 0m;
                decimal philHealth = row["PhilHealth"] != DBNull.Value ? Convert.ToDecimal(row["PhilHealth"]) : 0m;
                decimal pagIbig = row["PagIbig"] != DBNull.Value ? Convert.ToDecimal(row["PagIbig"]) : 0m;
                decimal lateDeduction = row["LateDeduction"] != DBNull.Value ? Convert.ToDecimal(row["LateDeduction"]) : 0m;
                decimal absenceDeduction = row["AbsenceDeduction"] != DBNull.Value ? Convert.ToDecimal(row["AbsenceDeduction"]) : 0m;
                decimal totalDeductions = row["TotalDeductions"] != DBNull.Value ? Convert.ToDecimal(row["TotalDeductions"]) : 0m;
                decimal netPay = row["NetPay"] != DBNull.Value ? Convert.ToDecimal(row["NetPay"]) : 0m;

                lblSSSValue.Text = FormatPeso(sss);
                lblPhilHealthValue.Text = FormatPeso(philHealth);
                lblPagIbigValue.Text = FormatPeso(pagIbig);
                lblLateDeductionValue.Text = FormatPeso(lateDeduction);
                lblAbsenceDeductionValue.Text = FormatPeso(absenceDeduction);
                lblTotalDeductionsValue.Text = FormatPeso(totalDeductions);
                lblNetPayValue.Text = FormatPeso(netPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payroll details:\n\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        //  PRINT PAYSLIP BUTTON CLICK
        // =========================================================
        private void btnPrintPayslip_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = payslipDocument,
                Width = 1200,
                Height = 900
            };
            preview.ShowDialog();
        }

        // =========================================================
        //  PAYSLIP PRINT LAYOUT
        // =========================================================
        private void PayslipDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font labelFont = new Font("Arial", 10, FontStyle.Bold);
            Font textFont = new Font("Arial", 10);

            int left = 50;
            int top = 40;
            int gap = 25;

            // Header
            e.Graphics.DrawString("Sansu Restaurant – PAYSLIP", headerFont, Brushes.Black, left, top);
            top += 45;

            // EMPLOYEE
            e.Graphics.DrawString("EMPLOYEE", subHeaderFont, Brushes.Black, left, top);
            top += 30;

            e.Graphics.DrawString($"Name: {lblEmployeeName.Text}", labelFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Position: {lblPosition.Text}", labelFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Pay Period: {lblPeriod.Text}", labelFont, Brushes.Black, left, top);
            top += gap * 2;

            // EARNINGS
            e.Graphics.DrawString("EARNINGS", subHeaderFont, Brushes.Black, left, top);
            top += 30;

            e.Graphics.DrawString($"Days Worked: {lblDaysWorkedValue.Text}", textFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Overtime Hours: {lblOvertimeHoursValue.Text}", textFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Basic Salary: {lblBasicSalaryValue.Text}", textFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Gross Pay: {lblGrossPayValue.Text}", textFont, Brushes.Black, left, top);
            top += gap * 2;

            // DEDUCTIONS
            e.Graphics.DrawString("DEDUCTIONS", subHeaderFont, Brushes.Black, left, top);
            top += 30;

            e.Graphics.DrawString($"SSS: {lblSSSValue.Text}", textFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"PhilHealth: {lblPhilHealthValue.Text}", textFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Pag-IBIG: {lblPagIbigValue.Text}", textFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Late Deduction: {lblLateDeductionValue.Text}", textFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Absence Deduction: {lblAbsenceDeductionValue.Text}", textFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Total Deductions: {lblTotalDeductionsValue.Text}", labelFont, Brushes.Black, left, top);
            top += gap * 2;

            // NET PAY BOX
            Rectangle netBox = new Rectangle(left, top, 700, 40);
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, netBox);
            e.Graphics.DrawRectangle(Pens.Black, netBox);

            e.Graphics.DrawString(
                $"NET PAY:     {lblNetPayValue.Text}",
                new Font("Arial", 14, FontStyle.Bold),
                Brushes.Black,
                left + 10,
                top + 10
            );

            top += 60;

            // Signatures
            e.Graphics.DrawString("Prepared by: _________________________", textFont, Brushes.Black, left, top);
            e.Graphics.DrawString("Approved by: _________________________", textFont, Brushes.Black, left + 350, top);
        }

        // =========================================================
        //  HELPERS
        // =========================================================
        private decimal SafeDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
                return 0;

            decimal v;
            return decimal.TryParse(value.ToString(), out v) ? v : 0;
        }

        private string FormatPeso(object value)
        {
            decimal v = SafeDecimal(value);
            return "₱ " + v.ToString("N2");
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e) { }

        private void headerPanel_Paint_1(object sender, PaintEventArgs e) { }
    }
}
