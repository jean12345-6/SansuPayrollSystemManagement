using System.Windows.Forms;
using System.Drawing;

namespace SansuPayrollSystemManagement
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelBackground;


        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer Code

        private void InitializeComponent()
        {
            this.panelBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.card = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.lblWelcomeSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblSignup = new System.Windows.Forms.Label();
            this.lnkSignup = new System.Windows.Forms.LinkLabel();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeroTitle1 = new System.Windows.Forms.Label();
            this.lblHeroTitle2 = new System.Windows.Forms.Label();
            this.lblHeroTitle3 = new System.Windows.Forms.Label();
            this.lblHeroSubtitle = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelBackground.SuspendLayout();
            this.card.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.card);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1942, 1100);
            this.panelBackground.TabIndex = 2;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.Controls.Add(this.panelRight);
            this.card.Controls.Add(this.panelLeft);
            this.card.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.card.Location = new System.Drawing.Point(-26, -84);
            this.card.Name = "card";
            this.card.Radius = 40;
            this.card.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.card.ShadowDepth = 30;
            this.card.ShadowShift = 8;
            this.card.Size = new System.Drawing.Size(2028, 1366);
            this.card.TabIndex = 0;
            this.card.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lblWelcomeTitle);
            this.panelRight.Controls.Add(this.lblWelcomeSubtitle);
            this.panelRight.Controls.Add(this.lblUsername);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.chkRemember);
            this.panelRight.Controls.Add(this.lnkForgotPassword);
            this.panelRight.Controls.Add(this.btnLogin);
            this.panelRight.Controls.Add(this.lblSignup);
            this.panelRight.Controls.Add(this.lnkSignup);
            this.panelRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelRight.Location = new System.Drawing.Point(172, 344);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(60, 60, 60, 40);
            this.panelRight.Size = new System.Drawing.Size(840, 725);
            this.panelRight.TabIndex = 0;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(251, 93);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(372, 67);
            this.lblWelcomeTitle.TabIndex = 1;
            this.lblWelcomeTitle.Text = "Welcome Back";
            // 
            // lblWelcomeSubtitle
            // 
            this.lblWelcomeSubtitle.AutoSize = true;
            this.lblWelcomeSubtitle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblWelcomeSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblWelcomeSubtitle.Location = new System.Drawing.Point(239, 160);
            this.lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            this.lblWelcomeSubtitle.Size = new System.Drawing.Size(393, 30);
            this.lblWelcomeSubtitle.TabIndex = 2;
            this.lblWelcomeSubtitle.Text = "Please log in to your Sansu HR account.";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblUsername.Location = new System.Drawing.Point(216, 237);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 30);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 6;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(221, 273);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Enter username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(453, 58);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblPassword.Location = new System.Drawing.Point(216, 355);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 30);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 6;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(221, 390);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(453, 58);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkRemember.Location = new System.Drawing.Point(221, 470);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(156, 29);
            this.chkRemember.TabIndex = 7;
            this.chkRemember.Text = "Remember Me";
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lnkForgotPassword.Location = new System.Drawing.Point(529, 475);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(145, 20);
            this.lnkForgotPassword.TabIndex = 8;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "Forgot Password?";
            this.lnkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgotPassword_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(221, 546);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(453, 60);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSignup.Location = new System.Drawing.Point(313, 631);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(191, 23);
            this.lblSignup.TabIndex = 10;
            this.lblSignup.Text = "Don\'t have an account?";
            // 
            // lnkSignup
            // 
            this.lnkSignup.AutoSize = true;
            this.lnkSignup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lnkSignup.Location = new System.Drawing.Point(467, 631);
            this.lnkSignup.Name = "lnkSignup";
            this.lnkSignup.Size = new System.Drawing.Size(63, 23);
            this.lnkSignup.TabIndex = 11;
            this.lnkSignup.TabStop = true;
            this.lnkSignup.Text = "Signup";
            this.lnkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignup_LinkClicked);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lblHeroTitle1);
            this.panelLeft.Controls.Add(this.lblHeroTitle2);
            this.panelLeft.Controls.Add(this.lblHeroTitle3);
            this.panelLeft.Controls.Add(this.lblHeroSubtitle);
            this.panelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.panelLeft.Location = new System.Drawing.Point(1002, 344);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(40);
            this.panelLeft.Size = new System.Drawing.Size(767, 725);
            this.panelLeft.TabIndex = 1;
            // 
            // lblHeroTitle1
            // 
            this.lblHeroTitle1.AutoSize = true;
            this.lblHeroTitle1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle1.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle1.Location = new System.Drawing.Point(69, 54);
            this.lblHeroTitle1.Name = "lblHeroTitle1";
            this.lblHeroTitle1.Size = new System.Drawing.Size(198, 60);
            this.lblHeroTitle1.TabIndex = 0;
            this.lblHeroTitle1.Text = "Simplify";
            // 
            // lblHeroTitle2
            // 
            this.lblHeroTitle2.AutoSize = true;
            this.lblHeroTitle2.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle2.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle2.Location = new System.Drawing.Point(69, 96);
            this.lblHeroTitle2.Name = "lblHeroTitle2";
            this.lblHeroTitle2.Size = new System.Drawing.Size(402, 60);
            this.lblHeroTitle2.TabIndex = 1;
            this.lblHeroTitle2.Text = "management with";
            // 
            // lblHeroTitle3
            // 
            this.lblHeroTitle3.AutoSize = true;
            this.lblHeroTitle3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle3.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle3.Location = new System.Drawing.Point(69, 151);
            this.lblHeroTitle3.Name = "lblHeroTitle3";
            this.lblHeroTitle3.Size = new System.Drawing.Size(340, 60);
            this.lblHeroTitle3.TabIndex = 2;
            this.lblHeroTitle3.Text = "our dashboard.";
            // 
            // lblHeroSubtitle
            // 
            this.lblHeroSubtitle.AutoSize = true;
            this.lblHeroSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeroSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblHeroSubtitle.Location = new System.Drawing.Point(69, 221);
            this.lblHeroSubtitle.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblHeroSubtitle.Name = "lblHeroSubtitle";
            this.lblHeroSubtitle.Size = new System.Drawing.Size(395, 46);
            this.lblHeroSubtitle.TabIndex = 3;
            this.lblHeroSubtitle.Text = "Manage Sansu Restaurant\'s HR and payroll in one place with our user-friendly admi" +
    "n dashboard.";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.Goldenrod;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(695, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 23);
            this.btnMinimize.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Goldenrod;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(729, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(1942, 1100);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelBackground.ResumeLayout(false);
            this.card.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel card;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private Label lblWelcomeTitle;
        private Label lblWelcomeSubtitle;
        private Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private CheckBox chkRemember;
        private LinkLabel lnkForgotPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Label lblSignup;
        private LinkLabel lnkSignup;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Label lblHeroTitle1;
        private Label lblHeroTitle2;
        private Label lblHeroTitle3;
        private Label lblHeroSubtitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
    }
}
