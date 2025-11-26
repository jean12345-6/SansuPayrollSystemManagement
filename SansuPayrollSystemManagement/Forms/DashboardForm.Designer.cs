using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
     {
  components.Dispose();
     }
         base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconPerformance = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconPayroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panelHeaderUnderline = new System.Windows.Forms.Panel();
            this.shadowPaid = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblKpiPaidThisMonth = new System.Windows.Forms.Label();
            this.lblCardPaidTitle = new System.Windows.Forms.Label();
            this.shadowEmployees = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblKpiEmployees = new System.Windows.Forms.Label();
            this.lblCardEmployeesTitle = new System.Windows.Forms.Label();
            this.shadowTotal = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblKpiTotalPayrollCost = new System.Windows.Forms.Label();
            this.lblCardTotalTitle = new System.Windows.Forms.Label();
            this.shadowPresent = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblKpiPresentToday = new System.Windows.Forms.Label();
            this.lblCardPresentTitle = new System.Windows.Forms.Label();
            this.dgvRecentActivity = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.shadowPaid.SuspendLayout();
            this.shadowEmployees.SuspendLayout();
            this.shadowTotal.SuspendLayout();
            this.shadowPresent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.panelContainer);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1924, 1055);
            this.guna2Panel2.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelContainer.Controls.Add(this.panelDashboard);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1924, 1055);
            this.panelContainer.TabIndex = 0;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelDashboard.Controls.Add(this.btnLogout);
            this.panelDashboard.Controls.Add(this.btnIconSettings);
            this.panelDashboard.Controls.Add(this.btnIconPerformance);
            this.panelDashboard.Controls.Add(this.btnIconPayroll);
            this.panelDashboard.Controls.Add(this.btnIconEmployees);
            this.panelDashboard.Controls.Add(this.btnIconAttendance);
            this.panelDashboard.Controls.Add(this.lblTitle);
            this.panelDashboard.Controls.Add(this.lblSubTitle);
            this.panelDashboard.Controls.Add(this.panelHeaderUnderline);
            this.panelDashboard.Controls.Add(this.shadowPaid);
            this.panelDashboard.Controls.Add(this.shadowEmployees);
            this.panelDashboard.Controls.Add(this.shadowTotal);
            this.panelDashboard.Controls.Add(this.shadowPresent);
            this.panelDashboard.Controls.Add(this.dgvRecentActivity);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1924, 1055);
            this.panelDashboard.TabIndex = 0;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnLogout.Location = new System.Drawing.Point(1854, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnIconSettings
            // 
            this.btnIconSettings.Animated = true;
            this.btnIconSettings.AutoRoundedCorners = true;
            this.btnIconSettings.BorderRadius = 39;
            this.btnIconSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIconSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIconSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconSettings.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnIconSettings.Location = new System.Drawing.Point(1736, 880);
            this.btnIconSettings.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconSettings.Name = "btnIconSettings";
            this.btnIconSettings.Size = new System.Drawing.Size(300, 80);
            this.btnIconSettings.TabIndex = 4;
            this.btnIconSettings.Text = "⚙️ SETTINGS";
            this.btnIconSettings.Click += new System.EventHandler(this.btnIconSettings_Click);
            // 
            // btnIconPerformance
            // 
            this.btnIconPerformance.Animated = true;
            this.btnIconPerformance.AutoRoundedCorners = true;
            this.btnIconPerformance.BorderRadius = 39;
            this.btnIconPerformance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIconPerformance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIconPerformance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconPerformance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconPerformance.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnIconPerformance.Location = new System.Drawing.Point(1389, 880);
            this.btnIconPerformance.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconPerformance.Name = "btnIconPerformance";
            this.btnIconPerformance.Size = new System.Drawing.Size(300, 80);
            this.btnIconPerformance.TabIndex = 3;
            this.btnIconPerformance.Text = "⭐ PERFORMANCE";
            this.btnIconPerformance.Click += new System.EventHandler(this.btnIconPerformance_Click);
            // 
            // btnIconPayroll
            // 
            this.btnIconPayroll.Animated = true;
            this.btnIconPayroll.AutoRoundedCorners = true;
            this.btnIconPayroll.BorderRadius = 39;
            this.btnIconPayroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIconPayroll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIconPayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconPayroll.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconPayroll.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnIconPayroll.Location = new System.Drawing.Point(1042, 880);
            this.btnIconPayroll.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconPayroll.Name = "btnIconPayroll";
            this.btnIconPayroll.Size = new System.Drawing.Size(300, 80);
            this.btnIconPayroll.TabIndex = 2;
            this.btnIconPayroll.Text = "💰 PAYROLL";
            this.btnIconPayroll.Click += new System.EventHandler(this.btnIconPayroll_Click);
            // 
            // btnIconEmployees
            // 
            this.btnIconEmployees.Animated = true;
            this.btnIconEmployees.AutoRoundedCorners = true;
            this.btnIconEmployees.BorderRadius = 39;
            this.btnIconEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIconEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIconEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIconEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIconEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIconEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIconEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconEmployees.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconEmployees.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnIconEmployees.Location = new System.Drawing.Point(13, 880);
            this.btnIconEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconEmployees.Name = "btnIconEmployees";
            this.btnIconEmployees.Size = new System.Drawing.Size(300, 80);
            this.btnIconEmployees.TabIndex = 0;
            this.btnIconEmployees.Text = "👥 EMPLOYEES";
            this.btnIconEmployees.Click += new System.EventHandler(this.btnIconEmployees_Click);
            // 
            // btnIconAttendance
            // 
            this.btnIconAttendance.Animated = true;
            this.btnIconAttendance.AutoRoundedCorners = true;
            this.btnIconAttendance.BorderRadius = 39;
            this.btnIconAttendance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIconAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIconAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconAttendance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconAttendance.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnIconAttendance.Location = new System.Drawing.Point(356, 880);
            this.btnIconAttendance.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconAttendance.Name = "btnIconAttendance";
            this.btnIconAttendance.Size = new System.Drawing.Size(300, 80);
            this.btnIconAttendance.TabIndex = 1;
            this.btnIconAttendance.Text = "📅 ATTENDANCE";
            this.btnIconAttendance.Click += new System.EventHandler(this.btnIconAttendance_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard Overview";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSubTitle.Location = new System.Drawing.Point(30, 77);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(800, 30);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Welcome to Sansu Payroll Performance Dashboard.";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHeaderUnderline
            // 
            this.panelHeaderUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.panelHeaderUnderline.Location = new System.Drawing.Point(30, 115);
            this.panelHeaderUnderline.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeaderUnderline.Name = "panelHeaderUnderline";
            this.panelHeaderUnderline.Size = new System.Drawing.Size(1967, 10);
            this.panelHeaderUnderline.TabIndex = 6;
            // 
            // shadowPaid
            // 
            this.shadowPaid.BackColor = System.Drawing.Color.Transparent;
            this.shadowPaid.Controls.Add(this.lblKpiPaidThisMonth);
            this.shadowPaid.Controls.Add(this.lblCardPaidTitle);
            this.shadowPaid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.shadowPaid.Location = new System.Drawing.Point(20, 150);
            this.shadowPaid.Margin = new System.Windows.Forms.Padding(0);
            this.shadowPaid.Name = "shadowPaid";
            this.shadowPaid.Radius = 12;
            this.shadowPaid.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.shadowPaid.ShadowDepth = 20;
            this.shadowPaid.Size = new System.Drawing.Size(501, 155);
            this.shadowPaid.TabIndex = 2;
            // 
            // lblKpiPaidThisMonth
            // 
            this.lblKpiPaidThisMonth.AutoSize = true;
            this.lblKpiPaidThisMonth.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblKpiPaidThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblKpiPaidThisMonth.Location = new System.Drawing.Point(20, 48);
            this.lblKpiPaidThisMonth.Name = "lblKpiPaidThisMonth";
            this.lblKpiPaidThisMonth.Size = new System.Drawing.Size(164, 62);
            this.lblKpiPaidThisMonth.TabIndex = 1;
            this.lblKpiPaidThisMonth.Text = "₱ 0.00";
            // 
            // lblCardPaidTitle
            // 
            this.lblCardPaidTitle.AutoSize = true;
            this.lblCardPaidTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardPaidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCardPaidTitle.Location = new System.Drawing.Point(22, 12);
            this.lblCardPaidTitle.Name = "lblCardPaidTitle";
            this.lblCardPaidTitle.Size = new System.Drawing.Size(197, 23);
            this.lblCardPaidTitle.TabIndex = 0;
            this.lblCardPaidTitle.Text = "💸 Paid This Month (₱)";
            // 
            // shadowEmployees
            // 
            this.shadowEmployees.BackColor = System.Drawing.Color.Transparent;
            this.shadowEmployees.Controls.Add(this.lblKpiEmployees);
            this.shadowEmployees.Controls.Add(this.lblCardEmployeesTitle);
            this.shadowEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.shadowEmployees.Location = new System.Drawing.Point(521, 150);
            this.shadowEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.shadowEmployees.Name = "shadowEmployees";
            this.shadowEmployees.Radius = 12;
            this.shadowEmployees.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.shadowEmployees.ShadowDepth = 20;
            this.shadowEmployees.Size = new System.Drawing.Size(501, 155);
            this.shadowEmployees.TabIndex = 0;
            // 
            // lblKpiEmployees
            // 
            this.lblKpiEmployees.AutoSize = true;
            this.lblKpiEmployees.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblKpiEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblKpiEmployees.Location = new System.Drawing.Point(20, 48);
            this.lblKpiEmployees.Name = "lblKpiEmployees";
            this.lblKpiEmployees.Size = new System.Drawing.Size(54, 62);
            this.lblKpiEmployees.TabIndex = 1;
            this.lblKpiEmployees.Text = "0";
            // 
            // lblCardEmployeesTitle
            // 
            this.lblCardEmployeesTitle.AutoSize = true;
            this.lblCardEmployeesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardEmployeesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCardEmployeesTitle.Location = new System.Drawing.Point(22, 12);
            this.lblCardEmployeesTitle.Name = "lblCardEmployeesTitle";
            this.lblCardEmployeesTitle.Size = new System.Drawing.Size(168, 23);
            this.lblCardEmployeesTitle.TabIndex = 0;
            this.lblCardEmployeesTitle.Text = "👥 Total Employees";
            // 
            // shadowTotal
            // 
            this.shadowTotal.BackColor = System.Drawing.Color.Transparent;
            this.shadowTotal.Controls.Add(this.lblKpiTotalPayrollCost);
            this.shadowTotal.Controls.Add(this.lblCardTotalTitle);
            this.shadowTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.shadowTotal.Location = new System.Drawing.Point(1022, 150);
            this.shadowTotal.Margin = new System.Windows.Forms.Padding(0);
            this.shadowTotal.Name = "shadowTotal";
            this.shadowTotal.Radius = 12;
            this.shadowTotal.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.shadowTotal.ShadowDepth = 20;
            this.shadowTotal.Size = new System.Drawing.Size(501, 155);
            this.shadowTotal.TabIndex = 3;
            // 
            // lblKpiTotalPayrollCost
            // 
            this.lblKpiTotalPayrollCost.AutoSize = true;
            this.lblKpiTotalPayrollCost.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotalPayrollCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblKpiTotalPayrollCost.Location = new System.Drawing.Point(20, 48);
            this.lblKpiTotalPayrollCost.Name = "lblKpiTotalPayrollCost";
            this.lblKpiTotalPayrollCost.Size = new System.Drawing.Size(164, 62);
            this.lblKpiTotalPayrollCost.TabIndex = 1;
            this.lblKpiTotalPayrollCost.Text = "₱ 0.00";
            // 
            // lblCardTotalTitle
            // 
            this.lblCardTotalTitle.AutoSize = true;
            this.lblCardTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCardTotalTitle.Location = new System.Drawing.Point(22, 12);
            this.lblCardTotalTitle.Name = "lblCardTotalTitle";
            this.lblCardTotalTitle.Size = new System.Drawing.Size(206, 23);
            this.lblCardTotalTitle.TabIndex = 0;
            this.lblCardTotalTitle.Text = "🧾 Total Payroll Cost (₱)";
            // 
            // shadowPresent
            // 
            this.shadowPresent.BackColor = System.Drawing.Color.Transparent;
            this.shadowPresent.Controls.Add(this.lblKpiPresentToday);
            this.shadowPresent.Controls.Add(this.lblCardPresentTitle);
            this.shadowPresent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.shadowPresent.Location = new System.Drawing.Point(1522, 150);
            this.shadowPresent.Margin = new System.Windows.Forms.Padding(0);
            this.shadowPresent.Name = "shadowPresent";
            this.shadowPresent.Radius = 12;
            this.shadowPresent.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.shadowPresent.ShadowDepth = 20;
            this.shadowPresent.Size = new System.Drawing.Size(501, 155);
            this.shadowPresent.TabIndex = 1;
            this.shadowPresent.Paint += new System.Windows.Forms.PaintEventHandler(this.shadowPresent_Paint);
            // 
            // lblKpiPresentToday
            // 
            this.lblKpiPresentToday.AutoSize = true;
            this.lblKpiPresentToday.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblKpiPresentToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblKpiPresentToday.Location = new System.Drawing.Point(20, 48);
            this.lblKpiPresentToday.Name = "lblKpiPresentToday";
            this.lblKpiPresentToday.Size = new System.Drawing.Size(54, 62);
            this.lblKpiPresentToday.TabIndex = 1;
            this.lblKpiPresentToday.Text = "0";
            // 
            // lblCardPresentTitle
            // 
            this.lblCardPresentTitle.AutoSize = true;
            this.lblCardPresentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardPresentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCardPresentTitle.Location = new System.Drawing.Point(22, 12);
            this.lblCardPresentTitle.Name = "lblCardPresentTitle";
            this.lblCardPresentTitle.Size = new System.Drawing.Size(150, 23);
            this.lblCardPresentTitle.TabIndex = 0;
            this.lblCardPresentTitle.Text = "📅 Present Today";
            // 
            // dgvRecentActivity
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvRecentActivity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentActivity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentActivity.ColumnHeadersHeight = 40;
            this.dgvRecentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRecentActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.user,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentActivity.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentActivity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvRecentActivity.Location = new System.Drawing.Point(20, 341);
            this.dgvRecentActivity.Margin = new System.Windows.Forms.Padding(0);
            this.dgvRecentActivity.Name = "dgvRecentActivity";
            this.dgvRecentActivity.RowHeadersVisible = false;
            this.dgvRecentActivity.RowHeadersWidth = 51;
            this.dgvRecentActivity.RowTemplate.Height = 38;
            this.dgvRecentActivity.Size = new System.Drawing.Size(2013, 527);
            this.dgvRecentActivity.TabIndex = 5;
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRecentActivity.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvRecentActivity.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvRecentActivity.ThemeStyle.ReadOnly = false;
            this.dgvRecentActivity.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvRecentActivity.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentActivity.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvRecentActivity.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvRecentActivity.ThemeStyle.RowsStyle.Height = 38;
            this.dgvRecentActivity.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvRecentActivity.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRecentActivity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentActivity_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // user
            // 
            this.user.HeaderText = "Performed By";
            this.user.MinimumWidth = 6;
            this.user.Name = "user";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.shadowPaid.ResumeLayout(false);
            this.shadowPaid.PerformLayout();
            this.shadowEmployees.ResumeLayout(false);
            this.shadowEmployees.PerformLayout();
            this.shadowTotal.ResumeLayout(false);
            this.shadowTotal.PerformLayout();
            this.shadowPresent.ResumeLayout(false);
            this.shadowPresent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
 private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblTitle;
 private System.Windows.Forms.Label lblSubTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel shadowEmployees;
 private Guna.UI2.WinForms.Guna2ShadowPanel shadowPresent;
        private Guna.UI2.WinForms.Guna2ShadowPanel shadowPaid;
        private Guna.UI2.WinForms.Guna2ShadowPanel shadowTotal;
 private System.Windows.Forms.Label lblCardEmployeesTitle;
    private System.Windows.Forms.Label lblCardPresentTitle;
        private System.Windows.Forms.Label lblCardPaidTitle;
        private System.Windows.Forms.Label lblCardTotalTitle;
        private System.Windows.Forms.Label lblKpiEmployees;
    private System.Windows.Forms.Label lblKpiPresentToday;
        private System.Windows.Forms.Label lblKpiPaidThisMonth;
        private System.Windows.Forms.Label lblKpiTotalPayrollCost;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentActivity;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn Action;
private System.Windows.Forms.Panel panelHeaderUnderline;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnIconEmployees;
     private Guna.UI2.WinForms.Guna2Button btnIconAttendance;
        private Guna.UI2.WinForms.Guna2Button btnIconPayroll;
 private Guna.UI2.WinForms.Guna2Button btnIconPerformance;
 private Guna.UI2.WinForms.Guna2Button btnIconSettings;

    }
}
