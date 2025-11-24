using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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

            this.grpAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAccountTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveAccount = new Guna.UI2.WinForms.Guna2Button();

            this.grpSystem = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblPayroll = new System.Windows.Forms.Label();
            this.cboDefaultPayroll = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblExport = new System.Windows.Forms.Label();
            this.txtExportPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveSystem = new Guna.UI2.WinForms.Guna2Button();

            this.SuspendLayout();

            // ======================================
            // ROOT CONTROL
            // ======================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(1750, 1000);
            this.Load += new System.EventHandler(this.SettingsControl_Load);

            // ======================================
            // TITLE LABEL
            // ======================================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SETTINGS";

            // ======================================
            // ACCOUNT CARD (grpAccount)
            // ======================================
            this.grpAccount.BorderRadius = 18;
            this.grpAccount.ShadowDecoration.Enabled = true;
            this.grpAccount.ShadowDecoration.Depth = 5;
            this.grpAccount.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.FillColor = System.Drawing.Color.White;
            this.grpAccount.Location = new System.Drawing.Point(40, 130);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(820, 360);
            this.grpAccount.TabIndex = 1;

            // Account title
            this.lblAccountTitle.AutoSize = true;
            this.lblAccountTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblAccountTitle.Location = new System.Drawing.Point(30, 25);
            this.lblAccountTitle.Name = "lblAccountTitle";
            this.lblAccountTitle.Size = new System.Drawing.Size(255, 32);
            this.lblAccountTitle.TabIndex = 0;
            this.lblAccountTitle.Text = "Account Settings";

            // Username label
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUser.Location = new System.Drawing.Point(32, 85);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(99, 25);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";

            // Username textbox
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(190, 80);
            this.txtUsername.Size = new System.Drawing.Size(380, 36);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.PlaceholderText = "Enter username";

            // New password label
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNewPass.Location = new System.Drawing.Point(32, 140);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(131, 25);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "New password";

            // New password textbox
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPass.Location = new System.Drawing.Point(190, 135);
            this.txtNewPass.Size = new System.Drawing.Size(380, 36);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.PlaceholderText = "Enter new password";
            this.txtNewPass.PasswordChar = '●';

            // Confirm password label
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblConfirm.Location = new System.Drawing.Point(32, 195);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(148, 25);
            this.lblConfirm.TabIndex = 3;
            this.lblConfirm.Text = "Confirm password";

            // Confirm password textbox
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPass.Location = new System.Drawing.Point(190, 190);
            this.txtConfirmPass.Size = new System.Drawing.Size(380, 36);
            this.txtConfirmPass.TabIndex = 2;
            this.txtConfirmPass.PlaceholderText = "Re-enter password";
            this.txtConfirmPass.PasswordChar = '●';

            // Save Account button
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Text = "Save Account";
            this.btnSaveAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveAccount.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAccount.AutoRoundedCorners = true;
            this.btnSaveAccount.BorderRadius = 22;
            this.btnSaveAccount.FillColor = System.Drawing.Color.Goldenrod;
            this.btnSaveAccount.Location = new System.Drawing.Point(570, 260);
            this.btnSaveAccount.Size = new System.Drawing.Size(190, 45);
            this.btnSaveAccount.TabIndex = 3;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);

            // Add controls to Account panel
            this.grpAccount.Controls.Add(this.lblAccountTitle);
            this.grpAccount.Controls.Add(this.lblUser);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.lblNewPass);
            this.grpAccount.Controls.Add(this.txtNewPass);
            this.grpAccount.Controls.Add(this.lblConfirm);
            this.grpAccount.Controls.Add(this.txtConfirmPass);
            this.grpAccount.Controls.Add(this.btnSaveAccount);

            // ======================================
            // SYSTEM PREFERENCES CARD (grpSystem)
            // ======================================
            this.grpSystem.BorderRadius = 18;
            this.grpSystem.ShadowDecoration.Enabled = true;
            this.grpSystem.ShadowDecoration.Depth = 5;
            this.grpSystem.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.grpSystem.BackColor = System.Drawing.Color.Transparent;
            this.grpSystem.FillColor = System.Drawing.Color.White;
            this.grpSystem.Location = new System.Drawing.Point(40, 520);
            this.grpSystem.Name = "grpSystem";
            this.grpSystem.Size = new System.Drawing.Size(820, 330);
            this.grpSystem.TabIndex = 2;

            // System title
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.Location = new System.Drawing.Point(30, 25);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(276, 32);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "System Preferences";

            // Default payroll label
            this.lblPayroll.AutoSize = true;
            this.lblPayroll.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPayroll.Location = new System.Drawing.Point(32, 90);
            this.lblPayroll.Name = "lblPayroll";
            this.lblPayroll.Size = new System.Drawing.Size(131, 25);
            this.lblPayroll.TabIndex = 1;
            this.lblPayroll.Text = "Default payroll";

            // Default payroll combo
            this.cboDefaultPayroll.Name = "cboDefaultPayroll";
            this.cboDefaultPayroll.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboDefaultPayroll.Location = new System.Drawing.Point(190, 85);
            this.cboDefaultPayroll.Size = new System.Drawing.Size(380, 36);
            this.cboDefaultPayroll.TabIndex = 0;
            this.cboDefaultPayroll.DrawMode = DrawMode.OwnerDrawFixed;
            this.cboDefaultPayroll.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDefaultPayroll.ItemHeight = 30;

            // Export path label
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblExport.Location = new System.Drawing.Point(32, 150);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(110, 25);
            this.lblExport.TabIndex = 2;
            this.lblExport.Text = "Export folder";

            // Export path textbox
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtExportPath.Location = new System.Drawing.Point(190, 145);
            this.txtExportPath.Size = new System.Drawing.Size(360, 36);
            this.txtExportPath.TabIndex = 1;
            this.txtExportPath.PlaceholderText = "Choose export folder";

            // Browse button
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.AutoRoundedCorners = true;
            this.btnBrowse.BorderRadius = 20;
            this.btnBrowse.FillColor = System.Drawing.Color.Goldenrod;
            this.btnBrowse.Location = new System.Drawing.Point(570, 145);
            this.btnBrowse.Size = new System.Drawing.Size(120, 42);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // Save Settings button
            this.btnSaveSystem.Name = "btnSaveSystem";
            this.btnSaveSystem.Text = "Save Settings";
            this.btnSaveSystem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveSystem.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSystem.AutoRoundedCorners = true;
            this.btnSaveSystem.BorderRadius = 22;
            this.btnSaveSystem.FillColor = System.Drawing.Color.Goldenrod;
            this.btnSaveSystem.Location = new System.Drawing.Point(570, 230);
            this.btnSaveSystem.Size = new System.Drawing.Size(190, 45);
            this.btnSaveSystem.TabIndex = 3;
            this.btnSaveSystem.Click += new System.EventHandler(this.btnSaveSystem_Click);

            // Add controls to System panel
            this.grpSystem.Controls.Add(this.lblSystemTitle);
            this.grpSystem.Controls.Add(this.lblPayroll);
            this.grpSystem.Controls.Add(this.cboDefaultPayroll);
            this.grpSystem.Controls.Add(this.lblExport);
            this.grpSystem.Controls.Add(this.txtExportPath);
            this.grpSystem.Controls.Add(this.btnBrowse);
            this.grpSystem.Controls.Add(this.btnSaveSystem);

            // ======================================
            // ADD TO ROOT
            // ======================================
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpSystem);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        // Account card
        private Guna2Panel grpAccount;
        private System.Windows.Forms.Label lblAccountTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirm;
        private Guna2TextBox txtUsername;
        private Guna2TextBox txtNewPass;
        private Guna2TextBox txtConfirmPass;
        private Guna2Button btnSaveAccount;

        // System card
        private Guna2Panel grpSystem;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblPayroll;
        private Guna2ComboBox cboDefaultPayroll;
        private System.Windows.Forms.Label lblExport;
        private Guna2TextBox txtExportPath;
        private Guna2Button btnBrowse;
        private Guna2Button btnSaveSystem;
    }
}
