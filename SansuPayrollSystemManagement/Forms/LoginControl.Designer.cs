namespace SansuPayrollSystemManagement
{
    partial class LoginControl
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelBackground;
        private Guna.UI2.WinForms.Guna2ShadowPanel shadowCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer Code
        private void InitializeComponent()
        {
            this.panelBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.shadowCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.shadowCard.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelBackground
            // 
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.FillColor = System.Drawing.Color.White;
            this.panelBackground.Controls.Add(this.shadowCard);
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1942, 1102);

            // 
            // shadowCard
            // 
            this.shadowCard.BackColor = System.Drawing.Color.Transparent;
            this.shadowCard.FillColor = System.Drawing.Color.White;
            this.shadowCard.Radius = 12;
            this.shadowCard.ShadowColor = System.Drawing.Color.Black;
            this.shadowCard.ShadowDepth = 40;
            this.shadowCard.Size = new System.Drawing.Size(500, 420);

            // Default center placement (runtime resize will recenter it)
            //this.shadowCard.Location = new System.Drawing.Point(
            //    (1942 - 500) / 2,
            //    (1102 - 420) / 2
            //);

            this.shadowCard.Controls.Add(this.lnkForgotPassword);
            this.shadowCard.Controls.Add(this.chkRememberMe);
            this.shadowCard.Controls.Add(this.btnLogin);
            this.shadowCard.Controls.Add(this.txtPassword);
            this.shadowCard.Controls.Add(this.txtUsername);
            this.shadowCard.Controls.Add(this.lblPassword);
            this.shadowCard.Controls.Add(this.lblUsername);
            this.shadowCard.Controls.Add(this.lblTitle);

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 25);
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.Text = "Welcome Back";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(40, 110);
            this.lblUsername.Size = new System.Drawing.Size(150, 25);
            this.lblUsername.Text = "Username";

            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 6;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(40, 135);
            this.txtUsername.Size = new System.Drawing.Size(420, 45);

            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(40, 195);
            this.lblPassword.Size = new System.Drawing.Size(150, 25);
            this.lblPassword.Text = "Password";

            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 6;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(40, 220);
            this.txtPassword.Size = new System.Drawing.Size(420, 45);
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // chkRememberMe
            // 
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkRememberMe.Location = new System.Drawing.Point(40, 280);
            this.chkRememberMe.Text = "Remember me";

            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkForgotPassword.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkForgotPassword.Location = new System.Drawing.Point(350, 282);
            this.lnkForgotPassword.Text = "Forgot Password?";
            this.lnkForgotPassword.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgotPassword_LinkClicked);

            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(0, 174, 239);
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(40, 330);
            this.btnLogin.Size = new System.Drawing.Size(420, 50);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // LoginControl
            // 
            this.Controls.Add(this.panelBackground);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(1942, 1102);

            this.panelBackground.ResumeLayout(false);
            this.shadowCard.ResumeLayout(false);
            this.shadowCard.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}
