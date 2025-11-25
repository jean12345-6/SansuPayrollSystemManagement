using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SansuPayrollSystemManagement
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
            this.Resize += LoginControl_Resize;
            this.Load += LoginControl_Load;
        }
        private void LoginControl_Resize(object sender, EventArgs e)
        {
            // Center the login card
            shadowCard.Left = (this.Width - shadowCard.Width) / 2;
            shadowCard.Top = (this.Height - shadowCard.Height) / 2;
        }

        // ============================================================
        // LOAD — RESTORE REMEMBER ME
        // ============================================================
        private void LoginControl_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.RememberMe)
                {
                    chkRememberMe.Checked = true;
                    txtUsername.Text = Properties.Settings.Default.RememberedUsername;
                }
            }
            catch { }
        }

        // ============================================================
        // LOGIN BUTTON
        // ============================================================
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
                string connStr = "server=localhost;database=sansu_payroll_db;uid=root;pwd=;";
                string query = "SELECT UserID, PasswordHash FROM Users WHERE Username=@u LIMIT 1";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@u", username);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            MessageBox.Show("Invalid username or password.");
                            return;
                        }

                        string storedHash = dr.GetString("PasswordHash");

                        bool match = Services.HashHelper.VerifyPassword(password, storedHash);
                        if (!match)
                        {
                            MessageBox.Show("Invalid username or password.");
                            return;
                        }
                    }
                }

                SaveRememberMe(username);
                //LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed:\n" + ex.Message);
            }
        }

        // ============================================================
        // REMEMBER ME SAVE
        // ============================================================
        private void SaveRememberMe(string username)
        {
            try
            {
                if (chkRememberMe.Checked)
                {
                    Properties.Settings.Default.RememberMe = true;
                    Properties.Settings.Default.RememberedUsername = username;
                }
                else
                {
                    Properties.Settings.Default.RememberMe = false;
                    Properties.Settings.Default.RememberedUsername = "";
                }

                Properties.Settings.Default.Save();
            }
            catch { }
        }

        // ============================================================
        // FORGOT PASSWORD
        // ============================================================
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Please contact your HR or System Administrator to reset your password.",
                "Forgot Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ============================================================
        // LOAD DASHBOARD
        // ============================================================
        //private void LoadDashboard()
        //{
        //    Form parent = this.FindForm();
        //    DashboardForm dashboard = new DashboardForm();

        //    dashboard.FormClosed += (s, e) => parent.Close();

        //    parent.Hide();
        //    dashboard.Show();
        //}
    }
}
