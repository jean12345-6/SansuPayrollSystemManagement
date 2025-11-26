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
            // panelBackground - Dark background matching Dashboard
       // ============================================================
            this.panelBackground.Dock = DockStyle.Fill;
    this.panelBackground.FillColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelBackground.Controls.Add(this.card);

       // ============================================================
            // card (center container) - Enhanced shadow with gold accent
            // ============================================================
   this.card.FillColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.card.Radius = 40;
   this.card.ShadowColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.card.ShadowDepth = 35;
            this.card.ShadowShift = 8;
       this.card.Size = new Size(1400, 800);
     this.card.BackColor = Color.Transparent;
            this.card.Controls.Add(this.panelRight);
         this.card.Controls.Add(this.panelLeft);

     // ============================================================
       // LEFT PANEL - Dashboard theme with gold
    // ============================================================
          this.panelLeft.Dock = DockStyle.Left;
   this.panelLeft.FillColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
    this.panelLeft.Padding = new Padding(40);
            this.panelLeft.Size = new Size(480, 800);

 // LEFT TEXT - Hero Section
            this.lblHeroTitle1.Text = "Manage";
 this.lblHeroTitle1.Font = new Font("Century Gothic", 32, FontStyle.Bold);
         this.lblHeroTitle1.ForeColor = Color.Black;
 this.lblHeroTitle1.Location = new Point(40, 60);
            this.lblHeroTitle1.AutoSize = true;

            this.lblHeroTitle2.Text = "Payroll &";
            this.lblHeroTitle2.Font = new Font("Century Gothic", 32, FontStyle.Bold);
            this.lblHeroTitle2.ForeColor = Color.Black;
 this.lblHeroTitle2.Location = new Point(40, 130);
    this.lblHeroTitle2.AutoSize = true;

            this.lblHeroTitle3.Text = "HR Smartly";
            this.lblHeroTitle3.Font = new Font("Century Gothic", 32, FontStyle.Bold);
 this.lblHeroTitle3.ForeColor = Color.Black;
            this.lblHeroTitle3.Location = new Point(40, 200);
 this.lblHeroTitle3.AutoSize = true;

      this.lblHeroSubtitle.Text =
 "Join Sansu Restaurant and manage employee records, attendance, and payroll effortlessly with our professional dashboard.";
     this.lblHeroSubtitle.ForeColor = Color.Black;
     this.lblHeroSubtitle.Font = new Font("Segoe UI", 11);
     this.lblHeroSubtitle.Location = new Point(40, 300);
    this.lblHeroSubtitle.MaximumSize = new Size(380, 0);

     this.panelLeft.Controls.Add(this.lblHeroTitle1);
   this.panelLeft.Controls.Add(this.lblHeroTitle2);
            this.panelLeft.Controls.Add(this.lblHeroTitle3);
  this.panelLeft.Controls.Add(this.lblHeroSubtitle);

    // ============================================================
            // RIGHT PANEL (FORM) - Dark theme
    // ============================================================
         this.panelRight.Dock = DockStyle.Fill;
        this.panelRight.Padding = new Padding(50, 50, 50, 40);
            this.panelRight.FillColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));

     int startY = 20;
   int spacing = 60;

   // Brand Label
     this.lblBrand.Text = "🏢 SANSU HR MANAGEMENT";
          this.lblBrand.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblBrand.ForeColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblBrand.Location = new Point(50, startY);
    this.lblBrand.AutoSize = true;

            // Title
            this.lblWelcomeTitle.Text = "Create Account";
            this.lblWelcomeTitle.Font = new Font("Century Gothic", 24, FontStyle.Bold);
   this.lblWelcomeTitle.ForeColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
        this.lblWelcomeTitle.Location = new Point(50, startY + 35);
 this.lblWelcomeTitle.AutoSize = true;

         // Subtitle
         this.lblWelcomeSubtitle.Text = "Register as a new user to get started";
          this.lblWelcomeSubtitle.Font = new Font("Segoe UI", 10);
     this.lblWelcomeSubtitle.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
    this.lblWelcomeSubtitle.Location = new Point(50, startY + 85);
 this.lblWelcomeSubtitle.AutoSize = true;

            int fieldY = startY + 140;

    // ========== FORM FIELDS WITH PROPER STYLING ==========

          // FULL NAME
  this.lblFullName.Text = "Full Name *";
            this.lblFullName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
       this.lblFullName.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
  this.lblFullName.Location = new Point(50, fieldY);
    this.lblFullName.AutoSize = true;

    this.txtFullName.Location = new Point(50, fieldY + 25);
            this.txtFullName.Size = new Size(380, 42);
            this.txtFullName.BorderRadius = 8;
this.txtFullName.BorderColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFullName.FocusedState.BorderColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
          this.txtFullName.FocusedState.FillColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtFullName.FillColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtFullName.ForeColor = Color.White;
            fieldY += spacing;

    // USERNAME
   this.lblUsername.Text = "Username *";
   this.lblUsername.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblUsername.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
          this.lblUsername.Location = new Point(50, fieldY);
            this.lblUsername.AutoSize = true;

       this.txtUsername.Location = new Point(50, fieldY + 25);
  this.txtUsername.Size = new Size(380, 42);
this.txtUsername.BorderRadius = 8;
            this.txtUsername.BorderColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.txtUsername.FocusedState.BorderColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
  this.txtUsername.FocusedState.FillColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
  this.txtUsername.FillColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
     this.txtUsername.ForeColor = Color.White;
        fieldY += spacing;

       // CONTACT
          this.lblContact.Text = "Contact Number";
       this.lblContact.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblContact.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblContact.Location = new Point(50, fieldY);
            this.lblContact.AutoSize = true;

   this.txtContact.Location = new Point(50, fieldY + 25);
     this.txtContact.Size = new Size(380, 42);
         this.txtContact.BorderRadius = 8;
      this.txtContact.BorderColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.txtContact.FocusedState.BorderColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
  this.txtContact.FocusedState.FillColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
     this.txtContact.FillColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtContact.ForeColor = Color.White;
            fieldY += spacing;

 // EMAIL
            this.lblEmail.Text = "Email";
        this.lblEmail.Font = new Font("Segoe UI", 10, FontStyle.Bold);
         this.lblEmail.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblEmail.Location = new Point(50, fieldY);
     this.lblEmail.AutoSize = true;

  this.txtEmail.Location = new Point(50, fieldY + 25);
    this.txtEmail.Size = new Size(380, 42);
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.BorderColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
   this.txtEmail.FocusedState.BorderColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
        this.txtEmail.FocusedState.FillColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
   this.txtEmail.FillColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtEmail.ForeColor = Color.White;
         fieldY += spacing;

  // ROLE
this.lblRole.Text = "Role *";
            this.lblRole.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblRole.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
         this.lblRole.Location = new Point(50, fieldY);
   this.lblRole.AutoSize = true;

  this.cboRole.Location = new Point(50, fieldY + 25);
    this.cboRole.Size = new Size(380, 42);
         this.cboRole.BorderRadius = 8;
     this.cboRole.BorderColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.cboRole.FocusedState.BorderColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
   this.cboRole.FillColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cboRole.ForeColor = Color.White;
            fieldY += spacing;

 // PASSWORD
  this.lblPassword.Text = "Password *";
       this.lblPassword.Font = new Font("Segoe UI", 10, FontStyle.Bold);
         this.lblPassword.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
     this.lblPassword.Location = new Point(50, fieldY);
         this.lblPassword.AutoSize = true;

     this.txtPassword.Location = new Point(50, fieldY + 25);
 this.txtPassword.Size = new Size(380, 42);
         this.txtPassword.BorderRadius = 8;
          this.txtPassword.BorderColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
          this.txtPassword.FocusedState.BorderColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtPassword.FocusedState.FillColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPassword.FillColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
       this.txtPassword.ForeColor = Color.White;
            this.txtPassword.UseSystemPasswordChar = true;
            fieldY += spacing;

            // CONFIRM PASSWORD
            this.lblConfirmPassword.Text = "Confirm Password *";
        this.lblConfirmPassword.Font = new Font("Segoe UI", 10, FontStyle.Bold);
      this.lblConfirmPassword.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
          this.lblConfirmPassword.Location = new Point(50, fieldY);
   this.lblConfirmPassword.AutoSize = true;

     this.txtConfirmPassword.Location = new Point(50, fieldY + 25);
            this.txtConfirmPassword.Size = new Size(380, 42);
            this.txtConfirmPassword.BorderRadius = 8;
    this.txtConfirmPassword.BorderColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
    this.txtConfirmPassword.FocusedState.BorderColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
    this.txtConfirmPassword.FocusedState.FillColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
     this.txtConfirmPassword.FillColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
      this.txtConfirmPassword.ForeColor = Color.White;
  this.txtConfirmPassword.UseSystemPasswordChar = true;
   fieldY += spacing + 10;

            // SIGNUP BUTTON - Professional Gold
     this.btnSignup.Text = "CREATE ACCOUNT";
      this.btnSignup.BorderRadius = 10;
      this.btnSignup.FillColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
          this.btnSignup.ForeColor = Color.Black;
    this.btnSignup.Font = new Font("Segoe UI", 11, FontStyle.Bold);
      this.btnSignup.HoverState.FillColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnSignup.Location = new Point(50, fieldY);
          this.btnSignup.Size = new Size(380, 48);
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);

     fieldY += 65;

       // BACK TO LOGIN
  this.lnkBackToLogin.Text = "← Back to Login";
            this.lnkBackToLogin.Font = new Font("Segoe UI", 10);
         this.lnkBackToLogin.Location = new Point(50, fieldY);
  this.lnkBackToLogin.LinkColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lnkBackToLogin.VisitedLinkColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
    this.lnkBackToLogin.AutoSize = true;
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
      // CONTROL BOXES (X AND —) - Styled
            // ============================================================
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.FillColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnClose.IconColor = Color.Black;
        this.btnClose.Location = new Point(1900, 15);

            this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
   this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
        this.btnMinimize.FillColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
    this.btnMinimize.IconColor = Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
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
