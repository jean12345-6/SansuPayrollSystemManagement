namespace SansuPayrollSystemManagement.Forms
{
    partial class SettingsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSaveAccount = new System.Windows.Forms.Button();

            this.grpSystem = new System.Windows.Forms.GroupBox();
            this.cboDefaultPayroll = new System.Windows.Forms.ComboBox();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSaveSystem = new System.Windows.Forms.Button();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblPayroll = new System.Windows.Forms.Label();

            this.grpAccount.SuspendLayout();
            this.grpSystem.SuspendLayout();
            this.SuspendLayout();

            // TITLE
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 32F);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Text = "SETTINGS";

            // ============================
            // ACCOUNT GROUPBOX
            // ============================
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.txtNewPass);
            this.grpAccount.Controls.Add(this.txtConfirmPass);
            this.grpAccount.Controls.Add(this.lblUser);
            this.grpAccount.Controls.Add(this.lblNewPass);
            this.grpAccount.Controls.Add(this.lblConfirm);
            this.grpAccount.Controls.Add(this.btnSaveAccount);
            this.grpAccount.Location = new System.Drawing.Point(40, 100);
            this.grpAccount.Size = new System.Drawing.Size(550, 250);
            this.grpAccount.Text = "Account Settings";

            // Username
            this.lblUser.Text = "Username:";
            this.lblUser.Location = new System.Drawing.Point(20, 40);

            this.txtUsername.Location = new System.Drawing.Point(150, 35);
            this.txtUsername.Width = 300;

            // New pass
            this.lblNewPass.Text = "New Password:";
            this.lblNewPass.Location = new System.Drawing.Point(20, 90);

            this.txtNewPass.Location = new System.Drawing.Point(150, 85);
            this.txtNewPass.Width = 300;
            this.txtNewPass.PasswordChar = '*';

            // Confirm pass
            this.lblConfirm.Text = "Confirm Password:";
            this.lblConfirm.Location = new System.Drawing.Point(20, 140);

            this.txtConfirmPass.Location = new System.Drawing.Point(150, 135);
            this.txtConfirmPass.Width = 300;
            this.txtConfirmPass.PasswordChar = '*';

            // Save Account
            this.btnSaveAccount.Text = "Save";
            this.btnSaveAccount.Location = new System.Drawing.Point(360, 190);
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);

            // ============================
            // SYSTEM SETTINGS
            // ============================
            this.grpSystem.Controls.Add(this.cboDefaultPayroll);
            this.grpSystem.Controls.Add(this.txtExportPath);
            this.grpSystem.Controls.Add(this.btnBrowse);
            this.grpSystem.Controls.Add(this.btnSaveSystem);
            this.grpSystem.Controls.Add(this.lblExport);
            this.grpSystem.Controls.Add(this.lblPayroll);
            this.grpSystem.Location = new System.Drawing.Point(40, 380);
            this.grpSystem.Size = new System.Drawing.Size(550, 250);
            this.grpSystem.Text = "System Preferences";

            // Payroll period
            this.lblPayroll.Text = "Default Payroll:";
            this.lblPayroll.Location = new System.Drawing.Point(20, 40);

            this.cboDefaultPayroll.Location = new System.Drawing.Point(150, 35);
            this.cboDefaultPayroll.Width = 300;

            // Export Path
            this.lblExport.Text = "Export Folder:";
            this.lblExport.Location = new System.Drawing.Point(20, 100);

            this.txtExportPath.Location = new System.Drawing.Point(150, 95);
            this.txtExportPath.Width = 250;

            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Location = new System.Drawing.Point(410, 93);
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // Save system
            this.btnSaveSystem.Text = "Save Settings";
            this.btnSaveSystem.Location = new System.Drawing.Point(360, 190);
            this.btnSaveSystem.Click += new System.EventHandler(this.btnSaveSystem_Click);

            // Add controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpSystem);

            this.Size = new System.Drawing.Size(1200, 900);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.grpSystem.ResumeLayout(false);
            this.grpSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnSaveAccount;

        private System.Windows.Forms.GroupBox grpSystem;
        private System.Windows.Forms.ComboBox cboDefaultPayroll;
        private System.Windows.Forms.TextBox txtExportPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSaveSystem;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblPayroll;
    }
}
