using System.Windows.Forms;
using System.Drawing;

namespace SansuPayrollSystemManagement
{
    partial class SignupForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelBackground;
        private Guna.UI2.WinForms.Guna2ShadowPanel card;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelRight;

        private Label lblHeroTitle1;
        private Label lblHeroTitle2;
        private Label lblHeroTitle3;
        private Label lblHeroSubtitle;

        private Label lblBrand;
        private Label lblWelcomeTitle;
        private Label lblWelcomeSubtitle;

        private Label lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;

        private Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;

        private Label lblContact;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;

        private Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;

        private Label lblRole;
        private Guna.UI2.WinForms.Guna2ComboBox cboRole;

        private Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;

        private Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;

        private Guna.UI2.WinForms.Guna2Button btnSignup;
        private LinkLabel lnkBackToLogin;

        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;

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
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();

            this.lblBrand = new Label();
            this.lblWelcomeTitle = new Label();
            this.lblWelcomeSubtitle = new Label();

            this.lblFullName = new Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblUsername = new Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblContact = new Label();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblEmail = new Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblRole = new Label();
            this.cboRole = new Guna.UI2.WinForms.Guna2ComboBox();

            this.lblPassword = new Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();

            this.lblConfirmPassword = new Label();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();

            this.btnSignup = new Guna.UI2.WinForms.Guna2Button();
            this.lnkBackToLogin = new LinkLabel();

            this.lblHeroTitle1 = new Label();
            this.lblHeroTitle2 = new Label();
            this.lblHeroTitle3 = new Label();
            this.lblHeroSubtitle = new Label();

            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();

            // ============================================================
            // panelBackground
            // ============================================================
            this.panelBackground.Dock = DockStyle.Fill;
            this.panelBackground.FillColor = Color.FromArgb(245, 247, 250);
            this.panelBackground.Controls.Add(this.card);

            // ============================================================
            // card (center container)
            // ============================================================
            this.card.FillColor = Color.White;
            this.card.Radius = 40;
            this.card.ShadowColor = Color.FromArgb(150, 150, 150);
            this.card.ShadowDepth = 30;
            this.card.ShadowShift = 8;
            this.card.Size = new Size(1400, 750);
            this.card.BackColor = Color.Transparent;
            this.card.Controls.Add(this.panelRight);
            this.card.Controls.Add(this.panelLeft);

            // ============================================================
            // LEFT ORANGE PANEL
            // ============================================================
            this.panelLeft.Dock = DockStyle.Left;
            this.panelLeft.FillColor = Color.FromArgb(255, 137, 0);
            this.panelLeft.Padding = new Padding(40);
            this.panelLeft.Size = new Size(520, 750);

            // LEFT TEXT
            this.lblHeroTitle1.Text = "Simplify";
            this.lblHeroTitle1.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            this.lblHeroTitle1.ForeColor = Color.White;
            this.lblHeroTitle1.Location = new Point(0, 10);

            this.lblHeroTitle2.Text = "management with";
            this.lblHeroTitle2.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            this.lblHeroTitle2.ForeColor = Color.White;
            this.lblHeroTitle2.Location = new Point(0, 70);

            this.lblHeroTitle3.Text = "our dashboard.";
            this.lblHeroTitle3.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            this.lblHeroTitle3.ForeColor = Color.White;
            this.lblHeroTitle3.Location = new Point(0, 130);

            this.lblHeroSubtitle.Text =
                "Manage Sansu Restaurant's HR and payroll in one place " +
                "with our user-friendly admin dashboard.";
            this.lblHeroSubtitle.ForeColor = Color.White;
            this.lblHeroSubtitle.Font = new Font("Segoe UI", 10);
            this.lblHeroSubtitle.Location = new Point(0, 210);
            this.lblHeroSubtitle.MaximumSize = new Size(400, 0);

            this.panelLeft.Controls.Add(this.lblHeroTitle1);
            this.panelLeft.Controls.Add(this.lblHeroTitle2);
            this.panelLeft.Controls.Add(this.lblHeroTitle3);
            this.panelLeft.Controls.Add(this.lblHeroSubtitle);

            // ============================================================
            // RIGHT PANEL (FORM)
            // ============================================================
            this.panelRight.Dock = DockStyle.Fill;
            this.panelRight.Padding = new Padding(60, 60, 60, 40);
            this.panelRight.FillColor = Color.White;

            int startY = 10;
            int spacing = 55;

            // Brand
            this.lblBrand.Text = "Sansu HR Management";
            this.lblBrand.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblBrand.Location = new Point(0, startY);

            // Title
            this.lblWelcomeTitle.Text = "Create Account";
            this.lblWelcomeTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            this.lblWelcomeTitle.Location = new Point(0, startY + 40);

            // Subtitle
            this.lblWelcomeSubtitle.Text = "Fill in the details below to register a new user.";
            this.lblWelcomeSubtitle.Font = new Font("Segoe UI", 9);
            this.lblWelcomeSubtitle.ForeColor = Color.Gray;
            this.lblWelcomeSubtitle.Location = new Point(0, startY + 95);

            int fieldY = startY + 150;

            // FULL NAME
            this.lblFullName.Text = "Full Name *";
            this.lblFullName.Location = new Point(0, fieldY);
            this.txtFullName.Location = new Point(0, fieldY + 20);
            this.txtFullName.Size = new Size(420, 40);
            fieldY += spacing;

            // USERNAME
            this.lblUsername.Text = "Username *";
            this.lblUsername.Location = new Point(0, fieldY);
            this.txtUsername.Location = new Point(0, fieldY + 20);
            this.txtUsername.Size = new Size(420, 40);
            fieldY += spacing;

            // CONTACT
            this.lblContact.Text = "Contact Number";
            this.lblContact.Location = new Point(0, fieldY);
            this.txtContact.Location = new Point(0, fieldY + 20);
            this.txtContact.Size = new Size(420, 40);
            fieldY += spacing;

            // EMAIL
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(0, fieldY);
            this.txtEmail.Location = new Point(0, fieldY + 20);
            this.txtEmail.Size = new Size(420, 40);
            fieldY += spacing;

            // ROLE
            this.lblRole.Text = "Role *";
            this.lblRole.Location = new Point(0, fieldY);
            this.cboRole.Location = new Point(0, fieldY + 20);
            this.cboRole.Size = new Size(420, 40);
            fieldY += spacing;

            // PASSWORD
            this.lblPassword.Text = "Password *";
            this.lblPassword.Location = new Point(0, fieldY);
            this.txtPassword.Location = new Point(0, fieldY + 20);
            this.txtPassword.Size = new Size(420, 40);
            this.txtPassword.UseSystemPasswordChar = true;
            fieldY += spacing;

            // CONFIRM PASSWORD
            this.lblConfirmPassword.Text = "Confirm Password *";
            this.lblConfirmPassword.Location = new Point(0, fieldY);
            this.txtConfirmPassword.Location = new Point(0, fieldY + 20);
            this.txtConfirmPassword.Size = new Size(420, 40);
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            fieldY += spacing + 10;

            // SIGNUP BUTTON
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.BorderRadius = 8;
            this.btnSignup.Location = new Point(0, fieldY);
            this.btnSignup.Size = new Size(420, 45);
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);

            fieldY += 50;

            // BACK TO LOGIN
            this.lnkBackToLogin.Text = "Back to Login";
            this.lnkBackToLogin.Location = new Point(0, fieldY);
            this.lnkBackToLogin.LinkColor = Color.FromArgb(0, 120, 215);
            this.lnkBackToLogin.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkBackToLogin_LinkClicked);
            // Add controls to right panel
            this.panelRight.Controls.Add(this.lblBrand);
            this.panelRight.Controls.Add(this.lblWelcomeTitle);
            this.panelRight.Controls.Add(this.lblWelcomeSubtitle);

            this.panelRight.Controls.Add(this.lblFullName);
            this.panelRight.Controls.Add(this.txtFullName);

            this.panelRight.Controls.Add(this.lblUsername);
            this.panelRight.Controls.Add(this.txtUsername);

            this.panelRight.Controls.Add(this.lblContact);
            this.panelRight.Controls.Add(this.txtContact);

            this.panelRight.Controls.Add(this.lblEmail);
            this.panelRight.Controls.Add(this.txtEmail);

            this.panelRight.Controls.Add(this.lblRole);
            this.panelRight.Controls.Add(this.cboRole);

            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.txtPassword);

            this.panelRight.Controls.Add(this.lblConfirmPassword);
            this.panelRight.Controls.Add(this.txtConfirmPassword);

            this.panelRight.Controls.Add(this.btnSignup);
            this.panelRight.Controls.Add(this.lnkBackToLogin);

            // ============================================================
            // CONTROL BOXES (X AND —)
            // ============================================================
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.FillColor = Color.FromArgb(139, 152, 166);
            this.btnClose.IconColor = Color.White;
            this.btnClose.Location = new Point(1900, 15);

            this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = Color.FromArgb(139, 152, 166);
            this.btnMinimize.IconColor = Color.White;
            this.btnMinimize.Location = new Point(1850, 15);

            // ============================================================
            // SignupForm (MAIN FORM)
            // ============================================================
            this.ClientSize = new Size(1942, 1100);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Signup";
        }

        #endregion
    }
}
