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

        // Root panel for the dashboard layout (inside panelContainer)
        private Panel dashboardRoot;

        // KPI value labels
        private Label lblKpiEmployees;
        private Label lblKpiPresentToday;
        private Label lblKpiPaidThisMonth;
        private Label lblKpiTotalPayrollCost;

        // Secondary info labels (if you want later – for now only main KPIs)
        private Label lblNotification;

        // Bottom icon buttons
        private Guna2Button btnIconEmployees;
        private Guna2Button btnIconAttendance;
        private Guna2Button btnIconPayroll;
        private Guna2Button btnIconPerformance;
        private Guna2Button btnIconSettings;

        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(string role)
        {
            InitializeComponent();
            userRole = role;
            //lblRole1.Text = $"Logged in as: {role}";
        }

        // ===========================
        // FORM LOAD
        // ===========================
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            BuildDashboardLayout();   // build PaySail-style UI inside panelContainer
            OpenDashboard();          // show dashboard
            LoadDashboardStats();     // load data from DB
        }

        // ===========================
        // BUILD LAYOUT (PaySail-style)
        // ===========================
        private void BuildDashboardLayout()
        {
            // Root container for everything inside panelContainer
            dashboardRoot = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            // ---------- Title + subtitle ----------
            var lblTitle = new Label
            {
                Text = "Dashboard Overview",
                AutoSize = true,
                Font = new Font("Century Gothic", 26, FontStyle.Bold),
                Location = new Point(40, 30)
            };

            var lblSub = new Label
            {
                Text = "Welcome to Sansu Payroll Performance Dashboard.",
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                Location = new Point(44, 80)
            };

            dashboardRoot.Controls.Add(lblTitle);
            dashboardRoot.Controls.Add(lblSub);

            // ---------- KPI row (4 cards) ----------
            var kpiRow = new FlowLayoutPanel
            {
                Location = new Point(40, 120),
                Size = new Size(1400, 140),
                AutoSize = false,
                WrapContents = false
            };

            // Card 1 – Total Employees (blue)
            var cardEmployees = CreateKpiCard("Total Employees", out lblKpiEmployees, "#00AEEF", "#FFFFFF");
            // Card 2 – Present Today (teal)
            var cardPresent = CreateKpiCard("Present Today", out lblKpiPresentToday, "#00796B", "#FFFFFF");
            // Card 3 – Paid This Month (₱) (dark)
            var cardPaid = CreateKpiCard("Paid This Month (₱)", out lblKpiPaidThisMonth, "#37474F", "#FFFFFF");
            // Card 4 – Total Payroll Cost (₱) (red)
            var cardTotal = CreateKpiCard("Total Payroll Cost (₱)", out lblKpiTotalPayrollCost, "#D84315", "#FFFFFF");

            kpiRow.Controls.Add(cardEmployees);
            kpiRow.Controls.Add(cardPresent);
            kpiRow.Controls.Add(cardPaid);
            kpiRow.Controls.Add(cardTotal);

            dashboardRoot.Controls.Add(kpiRow);

            // ---------- Notification bar ----------
            var notifBar = new Panel
            {
                Location = new Point(40, 270),
                Size = new Size(1400, 45),
                BackColor = Color.FromArgb(40, 53, 70)
            };

            lblNotification = new Label
            {
                Text = "You are currently set up to run payroll every month.",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Padding = new Padding(15, 0, 0, 0)
            };

            notifBar.Controls.Add(lblNotification);
            dashboardRoot.Controls.Add(notifBar);

            // ---------- Bottom icon row (navigation) ----------
            var iconRow = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 140,
                Padding = new Padding(0, 20, 0, 20),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoScroll = false
            };

            // Center the icons: create a spacer on left
            iconRow.Controls.Add(new Panel { Width = 200 });

            btnIconEmployees = CreateIconButton("EMPLOYEES");
            btnIconAttendance = CreateIconButton("ATTENDANCE");
            btnIconPayroll = CreateIconButton("PAYROLL");
            btnIconPerformance = CreateIconButton("PERFORMANCE");
            btnIconSettings = CreateIconButton("SETTINGS");

            btnIconEmployees.Click += (s, e) => OpenEmployeesPage();
            btnIconAttendance.Click += (s, e) => OpenAttendancePage();
            btnIconPayroll.Click += (s, e) => OpenPayrollPage();
            btnIconPerformance.Click += (s, e) => OpenPerformancePage();
            btnIconSettings.Click += (s, e) => OpenSettingsPage();

            iconRow.Controls.Add(btnIconEmployees);
            iconRow.Controls.Add(btnIconAttendance);
            iconRow.Controls.Add(btnIconPayroll);
            iconRow.Controls.Add(btnIconPerformance);
            iconRow.Controls.Add(btnIconSettings);

            dashboardRoot.Controls.Add(iconRow);
        }

        // Create one KPI card
        private Guna2ShadowPanel CreateKpiCard(string title, out Label valueLabel, string hexBackColor, string hexTextColor)
        {
            var panel = new Guna2ShadowPanel
            {
                Size = new Size(320, 120),
                Margin = new Padding(10, 0, 10, 0),
                ShadowColor = Color.Gray,
                ShadowDepth = 20,
                FillColor = ColorTranslator.FromHtml(hexBackColor),
                Radius = 6
            };

            var lblTitle = new Label
            {
                Text = title,
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = ColorTranslator.FromHtml(hexTextColor),
                Location = new Point(20, 15)
            };

            valueLabel = new Label
            {
                Text = "-",
                AutoSize = true,
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml(hexTextColor),
                Location = new Point(20, 50)
            };

            panel.Controls.Add(lblTitle);
            panel.Controls.Add(valueLabel);
            return panel;
        }

        // Create one bottom icon-style button
        private Guna2Button CreateIconButton(string text)
        {
            return new Guna2Button
            {
                Text = text,
                Size = new Size(180, 80),
                Margin = new Padding(20, 0, 20, 0),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FillColor = Color.White,
                ForeColor = Color.Black,
                BorderColor = Color.Silver,
                BorderThickness = 1,
                AutoRoundedCorners = true,
                BorderRadius = 35
            };
        }

        // ===========================
        // LOAD DATA FOR KPIs
        // ===========================
        private void LoadDashboardStats()
        {
            try
            {
                // Total employees
                object empObj = db.ExecuteScalar("SELECT COUNT(*) FROM Employees");
                int totalEmployees = Convert.ToInt32(empObj);

                // Present today
                string sqlPresent = @"
                    SELECT COUNT(DISTINCT EmployeeID)
                    FROM Attendance
                    WHERE Date = CURDATE() AND TimeIn IS NOT NULL;";
                object presObj = db.ExecuteScalar(sqlPresent);
                int presentToday = Convert.ToInt32(presObj);

                // Paid this month (NetPay)
                string sqlPaid = @"
                    SELECT IFNULL(SUM(NetPay),0)
                    FROM Payroll
                    WHERE MONTH(PayPeriodEnd) = MONTH(CURDATE())
                      AND YEAR(PayPeriodEnd) = YEAR(CURDATE());";
                decimal paidThisMonth = Convert.ToDecimal(db.ExecuteScalar(sqlPaid));

                // Total payroll cost (TotalPay)
                string sqlTotalCost = @"SELECT IFNULL(SUM(TotalPay),0) FROM Payroll;";
                decimal totalCost = Convert.ToDecimal(db.ExecuteScalar(sqlTotalCost));

                // Assign to labels (formatted)
                lblKpiEmployees.Text = totalEmployees.ToString();
                lblKpiPresentToday.Text = presentToday.ToString();
                lblKpiPaidThisMonth.Text = FormatPeso(paidThisMonth);
                lblKpiTotalPayrollCost.Text = FormatPeso(totalCost);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message,
                    "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatPeso(decimal value)
        {
            return "₱ " + value.ToString("N2");
        }

        // ===========================
        // NAVIGATION HELPERS
        // ===========================
        private void OpenDashboard()
        {
            panelContainer.Controls.Clear();
            dashboardRoot.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(dashboardRoot);
            LoadDashboardStats();
        }

        public void LoadPage(UserControl page)
        {
            panelContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }

        private void OpenEmployeesPage() => LoadPage(new EmployeeControl());
        private void OpenAttendancePage() => LoadPage(new AttendanceControl());
        private void OpenPayrollPage() => LoadPage(new PayrollControl());
        private void OpenPerformancePage() => LoadPage(new PerformanceControl());
        private void OpenSettingsPage() => LoadPage(new SettingsControl());

        // ===========================
        // LEFT NAV BUTTON HANDLERS
        // (they now just call the same helpers)
        // ===========================
        private void guna2ButtonDashboard_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }

        private void guna2ButtonManageEmployees_Click(object sender, EventArgs e)
        {
            OpenEmployeesPage();
        }

        private void guna2ButtonAttendance_Click(object sender, EventArgs e)
        {
            OpenAttendancePage();
        }

        private void guna2ButtonPayroll_Click(object sender, EventArgs e)
        {
            OpenPayrollPage();
        }

        private void guna2ButtonPerformance_Click(object sender, EventArgs e)
        {
            OpenPerformancePage();
        }

        private void guna2ButtonSettings_Click(object sender, EventArgs e)
        {
            OpenSettingsPage();
        }

        // Logout
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

        // Designer-generated empty handlers can stay:
        private void guna2ShadowPanelEmployees_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
