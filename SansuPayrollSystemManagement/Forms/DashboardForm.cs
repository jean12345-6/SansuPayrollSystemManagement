using Guna.UI2.WinForms;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class DashboardForm : Form
    {
        private string userRole;

        // ✅ Default constructor (needed by the designer)
        public DashboardForm()
        {
            InitializeComponent();
        }

        // ✅ Constructor that accepts the role from LoginForm
        public DashboardForm(string role)
        {
            InitializeComponent();
            userRole = role;  // assign the role passed from LoginForm
            lblRole1.Text = $"Logged in as: {role}";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                btnManageEmployees.Visible = true;
            }
            else
            {
                btnManageEmployees.Visible = false;
            }
            this.WindowState = FormWindowState.Maximized;
            CreateDashboardPanels();
            lblEmpCount.Text = "99";
            lblAttCount.Text = "15";
            lblPayCount.Text = "7";
        }

        private void CreateDashboardPanels()
        {
            // ===== Panel 1: Employees =====
            var shadowPanelEmployees = new Guna2ShadowPanel
            {
                Name = "shadowPanelEmployees",
                Size = new Size(250, 120),
                FillColor = Color.White,
                Radius = 10,
                ShadowColor = Color.FromArgb(128, 128, 128),
                Location = new Point(40, 100)
            };

            var lblEmpTitle = new Label
            {
                Text = "Employees",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(20, 20)
            };

            var lblEmpCount = new Label
            {
                Text = "25", // sample data; later bind from DB
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 150, 243),
                Location = new Point(20, 50)
            };

            shadowPanelEmployees.Controls.Add(lblEmpTitle);
            shadowPanelEmployees.Controls.Add(lblEmpCount);

            // ===== Panel 2: Attendance =====
            var shadowPanelAttendance = new Guna2ShadowPanel
            {
                Name = "shadowPanelAttendance",
                Size = new Size(250, 120),
                FillColor = Color.White,
                Radius = 10,
                ShadowColor = Color.FromArgb(128, 128, 128),
                Location = new Point(320, 100)
            };

            var lblAttTitle = new Label
            {
                Text = "Attendance Today",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(20, 20)
            };

            var lblAttCount = new Label
            {
                Text = "22", // sample data; later bind from DB
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.FromArgb(76, 175, 80),
                Location = new Point(20, 50)
            };

            shadowPanelAttendance.Controls.Add(lblAttTitle);
            shadowPanelAttendance.Controls.Add(lblAttCount);

            // ===== Panel 3: Payroll =====
            var shadowPanelPayroll = new Guna2ShadowPanel
            {
                Name = "shadowPanelPayroll",
                Size = new Size(250, 120),
                FillColor = Color.White,
                Radius = 10,
                ShadowColor = Color.FromArgb(128, 128, 128),
                Location = new Point(600, 100)
            };

            var lblPayTitle = new Label
            {
                Text = "Pending Payroll",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(20, 20)
            };

            var lblPayCount = new Label
            {
                Text = "5", // sample data; later bind from DB
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 152, 0),
                Location = new Point(20, 50)
            };

            shadowPanelPayroll.Controls.Add(lblPayTitle);
            shadowPanelPayroll.Controls.Add(lblPayCount);

            // ===== Add all panels to form =====
            this.Controls.Add(shadowPanelEmployees);
            this.Controls.Add(shadowPanelAttendance);
            this.Controls.Add(shadowPanelPayroll);
        }

        private void guna2ButtonPayroll_Click(object sender, EventArgs e)
        {
            try
            {
                // Open Payroll form
                PayrollForm payrollForm = new PayrollForm();

                this.Hide(); // hide dashboard while payroll is open
                payrollForm.ShowDialog(); // open as modal window
                this.Show(); // show dashboard again when payroll form closes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Payroll Form: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ButtonPerformance_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonSettings_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardStats();

            // Optional feedback to the user
            lblStatus.Text = "Dashboard refreshed.";

        }
        private void LoadDashboardStats()
        {
            DBHelper db = new DBHelper();

            // Refresh real-time data from the database
            lblEmpCount.Text = db.ExecuteScalar("SELECT COUNT(*) FROM Employees").ToString();
            lblAttCount.Text = db.ExecuteScalar("SELECT COUNT(*) FROM Attendance WHERE Date = CURDATE()").ToString();
            lblPayCount.Text = db.ExecuteScalar("SELECT COUNT(*) FROM Payroll WHERE NetPay = 0").ToString();
        }

        private void guna2ButtonManageEmployees_Click(object sender, EventArgs e)
        {
            LoadPage(new EmployeeControl());
        }

        private void guna2ShadowPanelEmployees_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to log out?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                // Hide the dashboard
                this.Hide();

                // Go back to the login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Close the dashboard form properly
                this.Close();
            }
        }

        private void guna2ButtonAttendance_Click(object sender, EventArgs e)
        {
            LoadPage(new AttendanceControl());
        }
        private void LoadPage(UserControl page)
        {
            panelContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }
    }
}
