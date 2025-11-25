using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class SettingsControl : UserControl
    {
        private readonly DBHelper db = new DBHelper();
        private string userRole = "employee";

        public SettingsControl()
        {
            InitializeComponent();
        }
        public SettingsControl(string role)
        {
            InitializeComponent();
            userRole = role?.ToLower() ?? "employee";
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            LoadDefaultPreferences();
            LoadUserSettings();
        }

        // ===============================
        // USER ACCOUNT
        // ===============================
        private void LoadUserSettings()
        {
            txtUsername.Text = LoginSession.Username;
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string sql = "UPDATE Users SET Username=@u, PasswordHash=@p WHERE UserID=@id";

            db.ExecuteNonQuery(sql, new MySqlParameter[]
{
    new MySqlParameter("@u", txtUsername.Text),
    new MySqlParameter("@p", txtNewPass.Text),
    new MySqlParameter("@id", LoginSession.UserID)
});


            MessageBox.Show("Account updated successfully!");
        }

        // ===============================
        // SYSTEM PREFERENCES
        // ===============================
        private void LoadDefaultPreferences()
        {
            cboDefaultPayroll.Items.Clear();
            cboDefaultPayroll.Items.Add("Current Month");
            cboDefaultPayroll.Items.Add("Current Cutoff");
            cboDefaultPayroll.Items.Add("Previous Month");

            // defaults
            cboDefaultPayroll.SelectedIndex = 0;
            txtExportPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog d = new FolderBrowserDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                    txtExportPath.Text = d.SelectedPath;
            }
        }

        private void btnSaveSystem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings saved!", "Info");
        }

        private void SettingsControl_Load_1(object sender, EventArgs e)
        {

        }
    }
}
