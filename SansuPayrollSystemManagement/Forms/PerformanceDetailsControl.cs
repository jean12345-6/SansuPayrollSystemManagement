using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class PerformanceDetailsControl : UserControl
    {
        private readonly DBHelper db = new DBHelper();
        private readonly int _performanceId;

        public PerformanceDetailsControl(int performanceId)
        {
            InitializeComponent();
            _performanceId = performanceId;
        }

        private void PerformanceDetailsControl_Load(object sender, EventArgs e)
        {
            LoadPerformanceDetails();
        }

        private void LoadPerformanceDetails()
        {
            try
            {
                string sql = @"
                    SELECT 
                        p.PerformanceID,
                        p.EmployeeID,
                        p.Date,
                        p.Sales,
                        p.FeedbackScore,
                        p.AttendanceScore,
                        e.FullName,
                        e.Position
                    FROM Performance p
                    JOIN Employees e ON p.EmployeeID = e.EmployeeID
                    WHERE p.PerformanceID = @id";

                DataTable dt = db.GetData(sql, new MySqlParameter[]
                {
                    new MySqlParameter("@id", _performanceId)
                });

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Performance record not found.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow row = dt.Rows[0];

                // ===== Header =====
                lblEmployeeValue.Text = row["FullName"].ToString();
                lblPositionValue.Text = row["Position"].ToString();

                if (row["Date"] != DBNull.Value)
                {
                    DateTime d = Convert.ToDateTime(row["Date"]);
                    lblDateValue.Text = d.ToString("MMM dd, yyyy");
                }
                else
                {
                    lblDateValue.Text = "-";
                }

                // ===== Scores =====
                decimal sales = SafeDecimal(row["Sales"]);
                decimal feedback = SafeDecimal(row["FeedbackScore"]);
                decimal attendance = SafeDecimal(row["AttendanceScore"]);

                // Format like: ₱ 10,500.00
                lblSalesValue.Text = "₱ " + sales.ToString("N2");
                lblFeedbackScoreValue.Text = feedback.ToString("0.0");
                lblAttendanceScoreValue.Text = attendance.ToString("0.0");

                // Total score – same formula you use in PerformanceControl
                // Here: Feedback + Attendance (max 10 if both are 5.0)
                decimal totalScore = feedback + attendance;
                lblTotalScoreValue.Text = totalScore.ToString("0.0");

                // Status based on total score
                string status;
                if (totalScore >= 9)
                    status = "Outstanding";
                else if (totalScore >= 7)
                    status = "Very Good";
                else if (totalScore >= 5)
                    status = "Satisfactory";
                else
                    status = "Needs Improvement";

                lblStatusValue.Text = status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading performance details: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal SafeDecimal(object value)
        {
            if (value == null || value == DBNull.Value) return 0m;

            decimal result;
            return decimal.TryParse(value.ToString(), out result) ? result : 0m;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Control will usually be hosted in a popup Form like PayrollDetails
            var parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Close();
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
