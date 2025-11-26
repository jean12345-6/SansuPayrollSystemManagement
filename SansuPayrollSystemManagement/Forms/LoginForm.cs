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
            GenerateHashFor("admin123");
            GenerateHashFor("12345");

            // Load saved settings
            txtUsername.Text = Properties.Settings.Default.SavedUsername;
            txtPassword.Text = Properties.Settings.Default.SavedPassword;
            chkRemember.Checked = Properties.Settings.Default.RememberMe;

            // Fix control box positions
            btnClose.BringToFront();
            btnMinimize.BringToFront();
            FixControlBoxes();

            // Fullscreen
            this.WindowState = FormWindowState.Maximized;

            // Center login card
            this.Load += (s, e) => CenterCard();
            this.Resize += (s, e) => CenterCard();

            // Enable drag-move window
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
        }

        // =========================================================
        // FIX CONTROL BOX POSITIONS
        // =========================================================
        private void GenerateHashFor(string password)
        {
            string hash = HashHelper.HashPassword(password);
            MessageBox.Show(hash);
        }
        private void FixControlBoxes()
        {
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            PositionControlBoxes();
            this.Resize += (s, e) => PositionControlBoxes();
        }

        private void PositionControlBoxes()
        {
            btnClose.Location = new Point(this.ClientSize.Width - 55, 20);
            btnMinimize.Location = new Point(this.ClientSize.Width - 100, 20);
        }

        // =========================================================
        // CENTER THE LOGIN CARD
        // =========================================================
        private void CenterCard()
        {
            if (card == null) return;

            int x = (this.ClientSize.Width - card.Width) / 2;
            int y = (this.ClientSize.Height - card.Height) / 2;
            card.Location = new Point(x, y);
        }

        // =========================================================
        // DRAGGING WINDOW
        // =========================================================
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

        // =========================================================
        // LOGIN BUTTON CLICK
        // =========================================================
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
                int employeeID = 0;

                // ============================
                // FETCH USER RECORD
                // ============================
                using (MySqlConnection conn = new MySqlConnection(
                    "server=localhost;database=sansu_payroll_db;uid=root;pwd=;"))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(@"
SELECT 
    u.PasswordHash,
    u.Role,
    u.EmployeeID,
    COALESCE(e.FullName, u.Username) AS FullName
FROM Users u
LEFT JOIN Employees e ON u.EmployeeID = e.EmployeeID
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

                    employeeID = dr["EmployeeID"] != DBNull.Value
                        ? Convert.ToInt32(dr["EmployeeID"])
                        : 0;
                }

                // ============================
                // VERIFY PASSWORD
                // ============================
                if (!HashHelper.VerifyPassword(password, storedHash))
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }

                // ============================
                // SAVE REMEMBER ME SETTINGS
                // ============================
                if (chkRemember.Checked)
                {
                    Properties.Settings.Default.SavedUsername = username;
                    Properties.Settings.Default.SavedPassword = password;
                    Properties.Settings.Default.RememberMe = true;
                }
                else
                {
                    Properties.Settings.Default.SavedUsername = "";
                    Properties.Settings.Default.SavedPassword = "";
                    Properties.Settings.Default.RememberMe = false;
                }
                Properties.Settings.Default.Save();

                // ============================
                // LOG ACTIVITY
                // ============================
                using (MySqlConnection connLog = new MySqlConnection(
                    "server=localhost;database=sansu_payroll_db;uid=root;pwd=;"))
                {
                    connLog.Open();

                    MySqlCommand logCmd = new MySqlCommand(@"
INSERT INTO ActivityLog (EmployeeID, FullName, Action)
VALUES (@id, @n, @a);", connLog);

                    logCmd.Parameters.AddWithValue("@id", employeeID);
                    logCmd.Parameters.AddWithValue("@n", fullName);
                    logCmd.Parameters.AddWithValue("@a", $"{role} Logged In");
                    logCmd.ExecuteNonQuery();
                }

                // ============================
                // OPEN DASHBOARD
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

        // =========================================================
        // SIGNUP + FORGOT
        // =========================================================
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

        // =========================================================
        // WINDOW CONTROL BUTTONS
        // =========================================================
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Ignore paint events
        private void panelBackground_Paint(object sender, PaintEventArgs e) { }
        private void panelRight_Paint(object sender, PaintEventArgs e) { }
        private void card_Paint(object sender, PaintEventArgs e) { }
    }
}
