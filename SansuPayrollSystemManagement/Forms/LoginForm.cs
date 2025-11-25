using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;

namespace SansuPayrollSystemManagement
{
    public partial class LoginForm : Form
    {
        private bool dragging = false;
        private Point dragStart;

        public LoginForm()
        {
            InitializeComponent();

            // Fullscreen window
            this.WindowState = FormWindowState.Maximized;

            // Center card after load/resize
            this.Load += (s, e) => CenterCard();
            this.Resize += (s, e) => CenterCard();

            // Fix control boxes
            FixControlBoxes();

            // Allow drag
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
        }

        // ============================
        // FIX CONTROL BOX BUTTONS
        // ============================
        private void FixControlBoxes()
        {
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            PositionControlBoxes();
            this.Resize += (s, e) => PositionControlBoxes();
        }

        private void PositionControlBoxes()
        {
            btnMinimize.Location = new Point(this.ClientSize.Width - 100, 20);
            btnClose.Location = new Point(this.ClientSize.Width - 55, 20);
        }

        // ============================
        // CENTER CARD
        // ============================
        private void CenterCard()
        {
            if (card == null) return;

            int x = (this.ClientSize.Width - card.Width) / 2;
            int y = (this.ClientSize.Height - card.Height) / 2;

            card.Location = new Point(x, y);
        }

        // ============================
        // DRAGGING WINDOW
        // ============================
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStart = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Left += e.X - dragStart.X;
                this.Top += e.Y - dragStart.Y;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // ============================
        // LOGIN LOGIC
        // ============================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                string storedHash = "";
                string fullName = "";
                string role = "";

                using (MySqlConnection conn = new MySqlConnection(
                    "server=localhost;database=sansu_payroll_db;uid=root;pwd=;"))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(@"
SELECT 
    u.PasswordHash,
    u.Role,
    e.FullName
FROM Users u
JOIN Employees e ON u.EmployeeID = e.EmployeeID
WHERE u.Username = @u
LIMIT 1;", conn);

                    cmd.Parameters.AddWithValue("@u", username);

                    var dr = cmd.ExecuteReader();
                    if (!dr.Read())
                    {
                        MessageBox.Show("Invalid username or password.");
                        return;
                    }

                    storedHash = dr.GetString("PasswordHash");
                    role = dr.GetString("Role");
                    fullName = dr.GetString("FullName");
                }

                // Verify password
                if (!HashHelper.VerifyPassword(password, storedHash))
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }

                // ============================
                // ROLE-BASED LOGIN MESSAGE
                // ============================
                string actionMessage = "";
                string r = role.ToLower();

                if (r == "admin")
                    actionMessage = "Administrator Logged In";
                else if (r == "hr")
                    actionMessage = "HR Manager Logged In";
                else if (r == "manager")
                    actionMessage = "Manager Logged In";
                else
                    actionMessage = "Employee Logged In";

                // Store login activity
                using (MySqlConnection connLog = new MySqlConnection(
                    "server=localhost;database=sansu_payroll_db;uid=root;pwd=;"))
                {
                    connLog.Open();

                    MySqlCommand logCmd = new MySqlCommand(@"
INSERT INTO ActivityLog (FullName, Action)
VALUES (@n, @a);", connLog);

                    logCmd.Parameters.AddWithValue("@n", fullName);
                    logCmd.Parameters.AddWithValue("@a", actionMessage);
                    logCmd.ExecuteNonQuery();
                }

                // ============================
                // SUCCESS — OPEN DASHBOARD
                // ============================
                DashboardForm d = new DashboardForm(fullName, role);
                d.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed:\n" + ex.Message);
            }
        }

        // ============================
        // SIGNUP + FORGOT EVENTS
        // ============================
        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.Show();
            this.Hide();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact HR to reset your password.",
                "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
