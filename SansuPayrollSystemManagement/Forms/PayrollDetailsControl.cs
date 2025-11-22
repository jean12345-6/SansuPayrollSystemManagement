using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;

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

            // Attach print event
            payslipDocument.PrintPage += PayslipDocument_PrintPage;
        }

        private void PayrollDetailsControl_Load(object sender, EventArgs e)
        {
            LoadPayrollDetails();
        }

        // =========================================================
        //  LOAD PAYROLL DETAILS
        // =========================================================
        private void LoadPayrollDetails()
        {
            try
            {
                string sql = @"
                    SELECT 
                        p.*,
                        e.EmployeeID,
                        e.FullName,
                        e.Position,
                        e.Salary AS MonthlySalary,
                        e.DailyRate
                    FROM Payroll p
                    JOIN Employees e ON p.EmployeeID = e.EmployeeID
                    WHERE p.PayrollID = @id";

                var dt = db.GetData(sql, new MySqlParameter[]
                {
                    new MySqlParameter("@id", _payrollId)
                });

                if (dt.Rows.Count == 0)
                    return;

                DataRow row = dt.Rows[0];

                // ===== HEADER INFO =====
                lblEmployeeName.Text = row["FullName"].ToString();
                lblPosition.Text = row["Position"].ToString();

                DateTime start = Convert.ToDateTime(row["PayPeriodStart"]);
                DateTime end = Convert.ToDateTime(row["PayPeriodEnd"]);
                lblPeriod.Text = $"{start:MMM dd} - {end:MMM dd, yyyy}";

                // ===== EARNINGS =====
                lblDaysWorkedValue.Text = FormatNumber(row["DaysWorked"]);
                lblOvertimeHoursValue.Text = FormatNumber(row["OvertimeHours"]);
                lblBasicSalaryValue.Text = FormatPeso(row["BasicSalary"]);
                lblGrossPayValue.Text = FormatPeso(row["GrossPay"]);

                // ===== DEDUCTIONS =====
                decimal sss = SafeDecimal(row["SSS"]);
                decimal philHealth = SafeDecimal(row["PhilHealth"]);
                decimal pagIbig = SafeDecimal(row["PagIbig"]);
                decimal late = SafeDecimal(row["LateDeduction"]);
                decimal absence = SafeDecimal(row["AbsenceDeduction"]);
                decimal dbTotal = SafeDecimal(row["TotalDeductions"]);

                lblSSSValue.Text = FormatPeso(sss);
                lblPhilHealthValue.Text = FormatPeso(philHealth);
                lblPagIbigValue.Text = FormatPeso(pagIbig);
                lblLateDeductionValue.Text = FormatPeso(late);
                lblAbsenceDeductionValue.Text = FormatPeso(absence);

                decimal computedTotal = sss + philHealth + pagIbig + late + absence;
                decimal finalTotal = dbTotal > 0 ? dbTotal : computedTotal;

                lblTotalDeductionsValue.Text = FormatPeso(finalTotal);

                // ===== NET PAY =====
                decimal netPay = SafeDecimal(row["NetPay"]);
                if (netPay <= 0 && SafeDecimal(row["GrossPay"]) > 0)
                    netPay = SafeDecimal(row["GrossPay"]) - finalTotal;

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
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = payslipDocument;
            preview.Width = 1200;
            preview.Height = 900;
            preview.ShowDialog();
        }

        // =========================================================
        //  ACTUAL PAYSLIP PRINT LAYOUT
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

            // ======================================
            // EMPLOYEE SECTION
            // ======================================
            e.Graphics.DrawString("EMPLOYEE", subHeaderFont, Brushes.Black, left, top);
            top += 30;

            e.Graphics.DrawString($"Name: {lblEmployeeName.Text}", labelFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Position: {lblPosition.Text}", labelFont, Brushes.Black, left, top);
            top += gap;

            e.Graphics.DrawString($"Pay Period: {lblPeriod.Text}", labelFont, Brushes.Black, left, top);
            top += gap * 2;

            // ======================================
            // EARNINGS
            // ======================================
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

            // ======================================
            // DEDUCTIONS
            // ======================================
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

            // ======================================
            // NET PAY BOX
            // ======================================
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

            // Signature Lines
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

        private string FormatNumber(object value)
        {
            decimal v = SafeDecimal(value);
            return v.ToString("0.##");
        }

        private string FormatPeso(object value)
        {
            decimal v = SafeDecimal(value);
            return "₱ " + v.ToString("N2");
        }
    }
}
