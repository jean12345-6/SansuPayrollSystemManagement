using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Forms;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class DashboardForm : Form
    {
        private readonly DBHelper db = new DBHelper();
        private string userRole;
        private string loggedInName;

        // FIXED CONSTRUCTOR — accepts both FULL NAME and ROLE
        public DashboardForm(string fullName, string role)
        {
            InitializeComponent();
            loggedInName = fullName;
            userRole = role;
        }

        // ===========================================
        // FORM LOAD
        // ===========================================
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Set welcome label with employee name
            if (!string.IsNullOrWhiteSpace(loggedInName))
                lblSubTitle.Text = $"Welcome, {loggedInName} — to Sansu Payroll Performance Dashboard.";
            else
                lblSubTitle.Text = "Welcome to Sansu Payroll Performance Dashboard.";

            OpenDashboard();
        }

        // ===========================================
        // NAVIGATION
        // ===========================================
        public void OpenDashboard()
        {
            panelContainer.Controls.Clear();
            panelDashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(panelDashboard);
            panelDashboard.Visible = true;

            LoadDashboardStats();
            LoadRecentActivity();
        }

        public void LoadPage(UserControl page)
        {
            panelContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }

        private void OpenEmployeesPage() => LoadPage(new EmployeeControl(userRole));
        private void OpenAttendancePage() => LoadPage(new AttendanceControl(userRole));
        private void OpenPayrollPage() => LoadPage(new PayrollControl(userRole));
        private void OpenPerformancePage() => LoadPage(new PerformanceControl(userRole));
        private void OpenSettingsPage() => LoadPage(new SettingsControl(userRole));

        // Side menu buttons
        private void guna2ButtonDashboard_Click(object sender, EventArgs e) => OpenDashboard();
        private void guna2ButtonManageEmployees_Click(object sender, EventArgs e) => OpenEmployeesPage();
        private void guna2ButtonAttendance_Click(object sender, EventArgs e) => OpenAttendancePage();
        private void guna2ButtonPayroll_Click(object sender, EventArgs e) => OpenPayrollPage();
        private void guna2ButtonPerformance_Click(object sender, EventArgs e) => OpenPerformancePage();
        private void guna2ButtonSettings_Click(object sender, EventArgs e) => OpenSettingsPage();

        // Bottom icon buttons
        private void btnIconEmployees_Click(object sender, EventArgs e) => OpenEmployeesPage();
        private void btnIconAttendance_Click(object sender, EventArgs e) => OpenAttendancePage();
        private void btnIconPayroll_Click(object sender, EventArgs e) => OpenPayrollPage();
        private void btnIconPerformance_Click(object sender, EventArgs e) => OpenPerformancePage();
        private void btnIconSettings_Click(object sender, EventArgs e) => OpenSettingsPage();

        // ===========================================
        // DASHBOARD KPIs
        // ===========================================
        private void LoadDashboardStats()
{
    try
    {
        // ===========================================
        // 1. TOTAL EMPLOYEES
        // ===========================================
        string sqlEmployees = "SELECT COUNT(*) FROM Employees;";
        int totalEmployees = Convert.ToInt32(db.ExecuteScalar(sqlEmployees));


        // ===========================================
        // 2. PRESENT TODAY (distinct employees who time-in)
        // ===========================================
        string sqlPresentToday = @"
            SELECT COUNT(DISTINCT EmployeeID)
            FROM Attendance
            WHERE Date = CURDATE()
              AND TimeIn IS NOT NULL;";
        int presentToday = Convert.ToInt32(db.ExecuteScalar(sqlPresentToday));


        // ===========================================
        // 3. PAID THIS MONTH  
        // Sum of NetPay for payrolls where PayPeriodEnd is in THIS month
        // ===========================================
        string sqlPaidThisMonth = @"
            SELECT IFNULL(SUM(NetPay),0)
            FROM Payroll
            WHERE MONTH(PayPeriodEnd) = MONTH(CURDATE())
              AND YEAR(PayPeriodEnd) = YEAR(CURDATE());";

        decimal paidThisMonth = Convert.ToDecimal(db.ExecuteScalar(sqlPaidThisMonth));


        // ===========================================
        // 4. TOTAL PAYROLL COST (LIFETIME)
        // Sum of ALL NetPay values
        // ===========================================
        string sqlTotalCost = @"
            SELECT IFNULL(SUM(NetPay),0)
            FROM Payroll;";

        decimal totalPayrollCost = Convert.ToDecimal(db.ExecuteScalar(sqlTotalCost));


        // ===========================================
        // UPDATE LABELS
        // ===========================================
        lblKpiEmployees.Text = totalEmployees.ToString();
        lblKpiPresentToday.Text = presentToday.ToString();
        lblKpiPaidThisMonth.Text = FormatPeso(paidThisMonth);
        lblKpiTotalPayrollCost.Text = FormatPeso(totalPayrollCost);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading dashboard stats:\n" + ex.Message,
            "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


        private string FormatPeso(decimal value)
        {
            return "₱ " + value.ToString("N2");
        }

        // ===========================================
        // RECENT ACTIVITY GRID
        // ===========================================
        private void LoadRecentActivity()
        {
            try
            {
                string sql = @"
                    SELECT 
                        DateTimeLogged,
                        FullName,
                        Action
                    FROM ActivityLog
                    ORDER BY DateTimeLogged DESC
                    LIMIT 20;";

                DataTable dt = db.GetData(sql);

                dgvRecentActivity.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvRecentActivity.Rows.Add(
                        Convert.ToDateTime(row["DateTimeLogged"]).ToString("MMM dd, yyyy hh:mm tt"),
                        row["FullName"].ToString(),
                        row["Action"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load recent activity:\n" + ex.Message);
            }
        }

        // ===========================================
        // LOGOUT
        // ===========================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to log out?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e) => OpenDashboard();
        private void btnPrevPage_Click(object sender, EventArgs e) { }
        private void btnNextPage_Click(object sender, EventArgs e) { }

        // Empty handlers
        private void guna2ShadowPanelEmployees_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvRecentActivity_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void flowKpiRow_Paint(object sender, PaintEventArgs e) { }
        private void panelDashboard_Paint(object sender, PaintEventArgs e) { }
        private void shadowPresent_Paint(object sender, PaintEventArgs e) { }
    }
}