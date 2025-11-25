using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;

namespace SansuPayrollSystemManagement
{
    public partial class SignupForm : Form
    {
        private bool dragging = false;
        private Point dragStart;

        public SignupForm()
        {
            InitializeComponent();

            // Fullscreen window
            this.WindowState = FormWindowState.Maximized;

            // Center card after everything loads / resizes
            this.Load += (s, e) => CenterCard();
            this.Resize += (s, e) => CenterCard();

            // Position control boxes
            FixControlBoxes();

            // Enable dragging of borderless form
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;

            // Populate roles
            cboRole.Items.Clear();
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("HR");
            cboRole.Items.Add("Employee");
            cboRole.SelectedIndex = 2; // default Employee
        }

        // ============================
        // POSITION CONTROL BOXES
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
        // DRAGGING (borderless form)
        // ============================
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            dragging = true;
            dragStart = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) return;
            this.Left += e.X - dragStart.X;
            this.Top += e.Y - dragStart.Y;
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // ============================
        // SIGNUP BUTTON CLICK
        // ============================
        private void btnSignup_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string contact = txtContact.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPwd = txtConfirmPassword.Text.Trim();
            string role = cboRole.SelectedItem != null ? cboRole.SelectedItem.ToString() : "";

            // Basic validation
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPwd) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all required fields (*).",
                    "Signup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.",
                    "Signup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPwd)
            {
                MessageBox.Show("Password and Confirm Password do not match.",
                    "Signup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = "server=localhost;database=sansu_payroll_db;uid=root;pwd=;";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Check if username already exists
                    using (MySqlCommand checkCmd =
                        new MySqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@u", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@u", username);
                        long existing = (long)checkCmd.ExecuteScalar();
                        if (existing > 0)
                        {
                            MessageBox.Show("Username is already taken. Please choose another.",
                                "Signup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    using (MySqlTransaction tx = conn.BeginTransaction())
                    {
                        try
                        {
                            int employeeId;

                            // Insert into Employees (minimal info)
                            using (MySqlCommand empCmd = new MySqlCommand(@"
                                INSERT INTO Employees
                                    (FullName, Position, ContactInfo, Salary, DailyRate, DateHired)
                                VALUES
                                    (@FullName, @Position, @ContactInfo, 0, 0, CURDATE());", conn, tx))
                            {
                                empCmd.Parameters.AddWithValue("@FullName", fullName);
                                // Use role as position for now
                                empCmd.Parameters.AddWithValue("@Position", role);
                                empCmd.Parameters.AddWithValue("@ContactInfo",
                                    string.IsNullOrWhiteSpace(contact) ? (object)email ?? DBNull.Value : $"{contact} / {email}");

                                empCmd.ExecuteNonQuery();
                            }

                            using (MySqlCommand idCmd =
                                new MySqlCommand("SELECT LAST_INSERT_ID();", conn, tx))
                            {
                                employeeId = Convert.ToInt32(idCmd.ExecuteScalar());
                            }

                            // Hash password
                            string hash = HashHelper.HashPassword(password);

                            // Insert into Users
                            using (MySqlCommand userCmd = new MySqlCommand(@"
                                INSERT INTO Users (EmployeeID, Username, PasswordHash, Role)
                                VALUES (@EmployeeID, @Username, @PasswordHash, @Role);", conn, tx))
                            {
                                userCmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                                userCmd.Parameters.AddWithValue("@Username", username);
                                userCmd.Parameters.AddWithValue("@PasswordHash", hash);
                                userCmd.Parameters.AddWithValue("@Role", role);
                                userCmd.ExecuteNonQuery();
                            }

                            tx.Commit();

                            MessageBox.Show("Account created successfully!",
                                "Signup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Go back to login
                            OpenLoginAndClose();
                        }
                        catch
                        {
                            tx.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Signup failed:\n" + ex.Message,
                    "Signup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================
        // BACK TO LOGIN
        // ============================
        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLoginAndClose();
        }

        private void OpenLoginAndClose()
        {
            var login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
