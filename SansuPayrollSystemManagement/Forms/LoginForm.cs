using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class LoginForm : Form
    {
        private DBHelper db = new DBHelper();
        private FingerprintService fpService = new FingerprintService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new MySqlConnection("server=localhost;user id=root;password=;database=sansu_payroll_db;"))
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            string sql = "SELECT UserID, EmployeeID, Username, PasswordHash, Role FROM Users WHERE Username=@u LIMIT 1";
            var p = new MySqlParameter[] { new MySqlParameter("@u", username) };
            DataTable dt = db.GetData(sql, p);
            if (dt.Rows.Count == 0)
            {
                lblError.Text = "User not found.";
                return;
            }
            var row = dt.Rows[0];
            string storedHash = row["PasswordHash"].ToString();
            if (password == storedHash)
            {
                OpenDashboard(row["Role"].ToString());
            }
            else
            {
                lblError.Text = "Invalid password.";
            }
        }

        private int MatchFingerprintAndGetEmployeeId()
        {
            byte[] scanned;
            try
            {
                scanned = fpService.CaptureTemplate();
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("Fingerprint capture not implemented. Replace FingerprintService with your SDK.");
                return -1;
            }

            string sql = "SELECT EmployeeID, FingerprintTemplate FROM Employees WHERE FingerprintTemplate IS NOT NULL";
            DataTable dt = db.GetData(sql);
            foreach (DataRow r in dt.Rows)
            {
                if (r["FingerprintTemplate"] == DBNull.Value) continue;
                byte[] stored = (byte[])r["FingerprintTemplate"];
                if (fpService.MatchTemplates(stored, scanned))
                {
                    return Convert.ToInt32(r["EmployeeID"]);
                }
            }
            return -1;
        }

        private void btnFingerprintLogin_Click(object sender, EventArgs e)
        {
            int empId = MatchFingerprintAndGetEmployeeId();
            if (empId == -1)
            {
                lblError.Text = "Fingerprint not recognized.";
                return;
            }

            // find the role (User may be linked in Users table)
            string sql = "SELECT Role FROM Users WHERE EmployeeID=@id LIMIT 1";
            var p = new MySqlParameter[] { new MySqlParameter("@id", empId) };
            DataTable dt = db.GetData(sql, p);
            string role = dt.Rows.Count > 0 ? dt.Rows[0]["Role"].ToString() : "Employee";
            OpenDashboard(role);
        }

        private void OpenDashboard(string role)
        {
            var dash = new DashboardForm(role);
            this.Hide();
            dash.ShowDialog();
            this.Show();
        }
    }
}
