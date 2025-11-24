using System.Windows.Forms;
using System.Drawing;


namespace SansuPayrollSystemManagement
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelBackground;
        private Guna.UI2.WinForms.Guna2ShadowPanel card;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelRight;

        private PictureBox imgIllustration;
        private Label lblHeroTitle1;
        private Label lblHeroTitle2;
        private Label lblHeroTitle3;
        private Label lblHeroSubtitle;

        private Label lblBrand;
        private Label lblWelcomeTitle;
        private Label lblWelcomeSubtitle;
        private Label lblUsername;
        private Label lblPassword;

        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private CheckBox chkRemember;
        private LinkLabel lnkForgotPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;

        private Label lblOrLoginWith;
        private LinkLabel lnkGoogle;
        private LinkLabel lnkFacebook;
        private LinkLabel lnkSignup;

        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.card = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.lblWelcomeSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblOrLoginWith = new System.Windows.Forms.Label();
            this.lnkGoogle = new System.Windows.Forms.LinkLabel();
            this.lnkFacebook = new System.Windows.Forms.LinkLabel();
            this.lnkSignup = new System.Windows.Forms.LinkLabel();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeroSubtitle = new System.Windows.Forms.Label();
            this.lblHeroTitle3 = new System.Windows.Forms.Label();
            this.lblHeroTitle2 = new System.Windows.Forms.Label();
            this.lblHeroTitle1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.imgIllustration = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            this.card.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIllustration)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.card);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1942, 1102);
            this.panelBackground.TabIndex = 2;
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.Controls.Add(this.panelRight);
            this.card.Controls.Add(this.panelLeft);
            this.card.FillColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(350, 200);
            this.card.Name = "card";
            this.card.Radius = 30;
            this.card.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.card.ShadowDepth = 20;
            this.card.ShadowShift = 4;
            this.card.Size = new System.Drawing.Size(1200, 650);
            this.card.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lblBrand);
            this.panelRight.Controls.Add(this.lblWelcomeTitle);
            this.panelRight.Controls.Add(this.lblWelcomeSubtitle);
            this.panelRight.Controls.Add(this.lblUsername);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.chkRemember);
            this.panelRight.Controls.Add(this.lnkForgotPassword);
            this.panelRight.Controls.Add(this.btnLogin);
            this.panelRight.Controls.Add(this.lblOrLoginWith);
            this.panelRight.Controls.Add(this.lnkGoogle);
            this.panelRight.Controls.Add(this.lnkFacebook);
            this.panelRight.Controls.Add(this.lnkSignup);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.FillColor = System.Drawing.Color.White;
            this.panelRight.Location = new System.Drawing.Point(520, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(60, 60, 60, 40);
            this.panelRight.ShadowDecoration.BorderRadius = 20;
            this.panelRight.Size = new System.Drawing.Size(680, 650);
            this.panelRight.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(196, 23);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Sansu HR Management";
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.Black;
            this.lblWelcomeTitle.Location = new System.Drawing.Point(0, 40);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(277, 50);
            this.lblWelcomeTitle.TabIndex = 1;
            this.lblWelcomeTitle.Text = "Welcome Back";
            // 
            // lblWelcomeSubtitle
            // 
            this.lblWelcomeSubtitle.AutoSize = true;
            this.lblWelcomeSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWelcomeSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblWelcomeSubtitle.Location = new System.Drawing.Point(3, 85);
            this.lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            this.lblWelcomeSubtitle.Size = new System.Drawing.Size(269, 20);
            this.lblWelcomeSubtitle.TabIndex = 2;
            this.lblWelcomeSubtitle.Text = "Please log in to your Sansu HR account.";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(0, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 6;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(0, 155);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Enter username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(430, 40);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(0, 210);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 6;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(0, 230);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(430, 40);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRemember.Location = new System.Drawing.Point(3, 283);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(104, 24);
            this.chkRemember.TabIndex = 7;
            this.chkRemember.Text = "Remember";
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lnkForgotPassword.Location = new System.Drawing.Point(320, 283);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(125, 20);
            this.lnkForgotPassword.TabIndex = 8;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "Forgot Password?";
            this.lnkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgotPassword_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 315);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(430, 45);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblOrLoginWith
            // 
            this.lblOrLoginWith.AutoSize = true;
            this.lblOrLoginWith.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblOrLoginWith.ForeColor = System.Drawing.Color.Gray;
            this.lblOrLoginWith.Location = new System.Drawing.Point(0, 370);
            this.lblOrLoginWith.Name = "lblOrLoginWith";
            this.lblOrLoginWith.Size = new System.Drawing.Size(93, 20);
            this.lblOrLoginWith.TabIndex = 10;
            this.lblOrLoginWith.Text = "or login with";
            // 
            // lnkGoogle
            // 
            this.lnkGoogle.AutoSize = true;
            this.lnkGoogle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lnkGoogle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lnkGoogle.Location = new System.Drawing.Point(75, 370);
            this.lnkGoogle.Name = "lnkGoogle";
            this.lnkGoogle.Size = new System.Drawing.Size(58, 20);
            this.lnkGoogle.TabIndex = 11;
            this.lnkGoogle.TabStop = true;
            this.lnkGoogle.Text = "Google";
            // 
            // lnkFacebook
            // 
            this.lnkFacebook.AutoSize = true;
            this.lnkFacebook.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lnkFacebook.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lnkFacebook.Location = new System.Drawing.Point(135, 370);
            this.lnkFacebook.Name = "lnkFacebook";
            this.lnkFacebook.Size = new System.Drawing.Size(72, 20);
            this.lnkFacebook.TabIndex = 12;
            this.lnkFacebook.TabStop = true;
            this.lnkFacebook.Text = "Facebook";
            // 
            // lnkSignup
            // 
            this.lnkSignup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkSignup.AutoSize = true;
            this.lnkSignup.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lnkSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lnkSignup.Location = new System.Drawing.Point(0, 960);
            this.lnkSignup.Name = "lnkSignup";
            this.lnkSignup.Size = new System.Drawing.Size(217, 20);
            this.lnkSignup.TabIndex = 13;
            this.lnkSignup.TabStop = true;
            this.lnkSignup.Text = "Don’t have an account?  Signup";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.imgIllustration);
            this.panelLeft.Controls.Add(this.lblHeroSubtitle);
            this.panelLeft.Controls.Add(this.lblHeroTitle3);
            this.panelLeft.Controls.Add(this.lblHeroTitle2);
            this.panelLeft.Controls.Add(this.lblHeroTitle1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(40);
            this.panelLeft.Size = new System.Drawing.Size(520, 650);
            this.panelLeft.TabIndex = 1;
            // 
            // lblHeroSubtitle
            // 
            this.lblHeroSubtitle.AutoSize = true;
            this.lblHeroSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeroSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblHeroSubtitle.Location = new System.Drawing.Point(0, 190);
            this.lblHeroSubtitle.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblHeroSubtitle.Name = "lblHeroSubtitle";
            this.lblHeroSubtitle.Size = new System.Drawing.Size(395, 46);
            this.lblHeroSubtitle.TabIndex = 1;
            this.lblHeroSubtitle.Text = "Manage Sansu Restaurant\'s HR and payroll in one place with our user-friendly admi" +
    "n dashboard.";
            // 
            // lblHeroTitle3
            // 
            this.lblHeroTitle3.AutoSize = true;
            this.lblHeroTitle3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle3.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle3.Location = new System.Drawing.Point(0, 120);
            this.lblHeroTitle3.Name = "lblHeroTitle3";
            this.lblHeroTitle3.Size = new System.Drawing.Size(340, 60);
            this.lblHeroTitle3.TabIndex = 2;
            this.lblHeroTitle3.Text = "our dashboard.";
            // 
            // lblHeroTitle2
            // 
            this.lblHeroTitle2.AutoSize = true;
            this.lblHeroTitle2.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle2.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle2.Location = new System.Drawing.Point(0, 65);
            this.lblHeroTitle2.Name = "lblHeroTitle2";
            this.lblHeroTitle2.Size = new System.Drawing.Size(402, 60);
            this.lblHeroTitle2.TabIndex = 3;
            this.lblHeroTitle2.Text = "management with";
            // 
            // lblHeroTitle1
            // 
            this.lblHeroTitle1.AutoSize = true;
            this.lblHeroTitle1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle1.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle1.Location = new System.Drawing.Point(0, 10);
            this.lblHeroTitle1.Name = "lblHeroTitle1";
            this.lblHeroTitle1.Size = new System.Drawing.Size(198, 60);
            this.lblHeroTitle1.TabIndex = 4;
            this.lblHeroTitle1.Text = "Simplify";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 30);
            this.btnMinimize.TabIndex = 0;
            // 
            // imgIllustration
            // 
            this.imgIllustration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgIllustration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgIllustration.Image = global::SansuPayrollSystemManagement.Properties.Resources._9879e9d9_10ba_42a9_8679_5765275cf8ed;
            this.imgIllustration.Location = new System.Drawing.Point(0, 810);
            this.imgIllustration.Name = "imgIllustration";
            this.imgIllustration.Size = new System.Drawing.Size(440, 280);
            this.imgIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIllustration.TabIndex = 0;
            this.imgIllustration.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgIllustration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
