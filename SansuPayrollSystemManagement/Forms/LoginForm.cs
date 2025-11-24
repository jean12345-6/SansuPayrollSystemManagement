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
        private Point dragCursor;
        private Point dragForm;

        public LoginForm()
        {
            InitializeComponent();

            // Enable dragging for borderless window
            this.MouseDown += LoginForm_MouseDown;
            this.MouseMove += LoginForm_MouseMove;
            this.MouseUp += LoginForm_MouseUp;

            // Center the main card on load & resize
            this.Load += LoginForm_Load;
            this.Resize += LoginForm_Resize;
        }

        // ============================
        // DRAGGING (borderless form)
        // ============================
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursor));
                this.Location = Point.Add(dragForm, new Size(dif));
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // ============================
        // CENTER CARD
        // ============================
        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterCard();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterCard();
        }

        private void CenterCard()
        {
            if (card == null) return;

            int x = (this.ClientSize.Width - card.Width) / 2;
            int y = (this.ClientSize.Height - card.Height) / 2;
            card.Location = new Point(x, y);
        }

        // ============================
        // LOGIN CLICK
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
                string connStr = "server=localhost;database=sansu_payroll_db;uid=root;pwd=;";
                string query = "SELECT PasswordHash FROM Users WHERE Username=@u LIMIT 1";

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

                        if (!HashHelper.VerifyPassword(password, storedHash))
                        {
                            MessageBox.Show("Invalid username or password.");
                            return;
                        }
                    }
                }

                // Successful login → open dashboard
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed:\n" + ex.Message);
            }
        }

        // ============================
        // FORGOT PASSWORD
        // ============================
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Please contact HR or your System Administrator to reset your password.",
                "Forgot Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
