using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class DashboardOverviewControl : UserControl
    {
        private readonly DBHelper db = new DBHelper();

        public DashboardOverviewControl()
        {
            InitializeComponent();
            this.Load += DashboardOverviewControl_Load;
        }

        private void DashboardOverviewControl_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSummaryCards();
                LoadSubSummary();
                LoadPayrollTrendChart();
                LoadRecentPayroll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message,
                    "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== SUMMARY CARDS ====================

        private void LoadSummaryCards()
        {
            // Total employees
            object empObj = db.ExecuteScalar("SELECT COUNT(*) FROM Employees");
            int totalEmployees = Convert.ToInt32(empObj);

            // Present today (based on Attendance table)
            string sqlPresent = @"
                SELECT COUNT(DISTINCT EmployeeID)
                FROM Attendance
                WHERE Date = CURDATE() AND TimeIn IS NOT NULL";
            object presObj = db.ExecuteScalar(sqlPresent);
            int presentToday = Convert.ToInt32(presObj);

            // Paid this month (NetPay)
            string sqlPaid = @"
                SELECT IFNULL(SUM(NetPay),0)
                FROM Payroll
                WHERE MONTH(PayPeriodEnd) = MONTH(CURDATE())
                  AND YEAR(PayPeriodEnd) = YEAR(CURDATE())";
            decimal paidThisMonth = Convert.ToDecimal(db.ExecuteScalar(sqlPaid));

            // Total payroll cost (TotalPay or GrossPay depending on your schema)
            string sqlTotalCost = @"SELECT IFNULL(SUM(TotalPay),0) FROM Payroll";
            decimal totalCost = Convert.ToDecimal(db.ExecuteScalar(sqlTotalCost));

            lblEmpValue.Text = totalEmployees.ToString();
            lblPresentValue.Text = presentToday.ToString();
            lblPaidValue.Text = string.Format("₱ {0:N2}", paidThisMonth);
            lblTotalCostValue.Text = string.Format("₱ {0:N2}", totalCost);
        }

        private void LoadSubSummary()
        {
            // Outstanding payroll = total cost - paid this month
            string sqlPaid = @"
                SELECT IFNULL(SUM(NetPay),0)
                FROM Payroll
                WHERE MONTH(PayPeriodEnd) = MONTH(CURDATE())
                  AND YEAR(PayPeriodEnd) = YEAR(CURDATE())";
            decimal paidThisMonth = Convert.ToDecimal(db.ExecuteScalar(sqlPaid));

            string sqlTotalCost = @"SELECT IFNULL(SUM(TotalPay),0) FROM Payroll";
            decimal totalCost = Convert.ToDecimal(db.ExecuteScalar(sqlTotalCost));

            decimal outstanding = totalCost - paidThisMonth;
            if (outstanding < 0) outstanding = 0;

            // You said there is NO Sales table yet – we show 0.00 for now.
            decimal totalSalesToday = 0m;

            // Average Attendance Score from Performance table (this month)
            string sqlAvg = @"
                SELECT IFNULL(AVG(AttendanceScore),0)
                FROM Performance
                WHERE MONTH(Date) = MONTH(CURDATE())
                  AND YEAR(Date) = YEAR(CURDATE())";
            decimal avgAttendance = Convert.ToDecimal(db.ExecuteScalar(sqlAvg));

            lblOutstandingValue.Text = string.Format("₱ {0:N2}", outstanding);
            lblSalesValue.Text = string.Format("₱ {0:N2}", totalSalesToday);
            lblAvgAttendanceValue.Text = avgAttendance.ToString("0.00");
        }

        // ==================== CHART ====================

        private void LoadPayrollTrendChart()
        {
            string sql = @"
                SELECT DATE_FORMAT(PayPeriodEnd, '%Y-%m') AS Period,
                       IFNULL(SUM(NetPay),0) AS TotalNetPay
                FROM Payroll
                GROUP BY DATE_FORMAT(PayPeriodEnd, '%Y-%m')
                ORDER BY DATE_FORMAT(PayPeriodEnd, '%Y-%m')";

            DataTable dt = db.GetData(sql);

            var series = chartPayrollTrend.Series["NetPay"];
            series.Points.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string period = row["Period"].ToString();
                decimal value;
                if (!decimal.TryParse(row["TotalNetPay"].ToString(), out value))
                    value = 0;

                series.Points.AddXY(period, value);
            }
        }

        // ==================== RECENT PAYROLL TABLE ====================

        private void LoadRecentPayroll()
        {
            string sql = @"
                SELECT 
                    p.PayrollID      AS `Payroll No`,
                    e.FullName       AS `Employee`,
                    p.PayPeriodStart AS `Period Start`,
                    p.PayPeriodEnd   AS `Period End`,
                    p.NetPay         AS `Net Pay`
                FROM Payroll p
                JOIN Employees e ON p.EmployeeID = e.EmployeeID
                ORDER BY p.PayPeriodEnd DESC
                LIMIT 10";

            DataTable dt = db.GetData(sql);
            dgvRecentPayroll.DataSource = dt;
        }

        private void DashboardOverviewControl_Load_1(object sender, EventArgs e)
        {

        }

        private void tblSummaryRow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
