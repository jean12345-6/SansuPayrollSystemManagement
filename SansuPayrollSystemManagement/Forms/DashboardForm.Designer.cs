using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
            this.dgvRecentActivity = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowBottomNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIconEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconPayroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconPerformance = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconSettings = new Guna.UI2.WinForms.Guna2Button();
            this.panelNotification = new System.Windows.Forms.Panel();
            this.lblNotification = new System.Windows.Forms.Label();
            this.flowKpiRow = new System.Windows.Forms.FlowLayoutPanel();
            this.shadowEmployees = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblKpiEmployees = new System.Windows.Forms.Label();
            this.lblCardEmployeesTitle = new System.Windows.Forms.Label();
            this.shadowPresent = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblKpiPresentToday = new System.Windows.Forms.Label();
            this.lblCardPresentTitle = new System.Windows.Forms.Label();
            this.shadowPaid = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblKpiPaidThisMonth = new System.Windows.Forms.Label();
            this.lblCardPaidTitle = new System.Windows.Forms.Label();
            this.shadowTotal = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblKpiTotalPayrollCost = new System.Windows.Forms.Label();
            this.lblCardTotalTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).BeginInit();
            this.flowBottomNav.SuspendLayout();
            this.panelNotification.SuspendLayout();
            this.flowKpiRow.SuspendLayout();
            this.shadowEmployees.SuspendLayout();
            this.shadowPresent.SuspendLayout();
            this.shadowPaid.SuspendLayout();
            this.shadowTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.panelContainer);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1924, 1055);
            this.guna2Panel2.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.panelDashboard);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1924, 1055);
            this.panelContainer.TabIndex = 0;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.White;
            this.panelDashboard.Controls.Add(this.dgvRecentActivity);
            this.panelDashboard.Controls.Add(this.flowBottomNav);
            this.panelDashboard.Controls.Add(this.panelNotification);
            this.panelDashboard.Controls.Add(this.flowKpiRow);
            this.panelDashboard.Controls.Add(this.lblSubTitle);
            this.panelDashboard.Controls.Add(this.lblTitle);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1924, 1055);
            this.panelDashboard.TabIndex = 0;
            // 
            // dgvRecentActivity
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRecentActivity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentActivity.ColumnHeadersHeight = 18;
            this.dgvRecentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRecentActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.user,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentActivity.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentActivity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentActivity.Location = new System.Drawing.Point(40, 321);
            this.dgvRecentActivity.Name = "dgvRecentActivity";
            this.dgvRecentActivity.RowHeadersVisible = false;
            this.dgvRecentActivity.RowHeadersWidth = 51;
            this.dgvRecentActivity.RowTemplate.Height = 24;
            this.dgvRecentActivity.Size = new System.Drawing.Size(1884, 337);
            this.dgvRecentActivity.TabIndex = 5;
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRecentActivity.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentActivity.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRecentActivity.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvRecentActivity.ThemeStyle.ReadOnly = false;
            this.dgvRecentActivity.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentActivity.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentActivity.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecentActivity.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRecentActivity.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRecentActivity.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentActivity.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // flowBottomNav
            // 
            this.flowBottomNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowBottomNav.BackColor = System.Drawing.Color.Transparent;
            this.flowBottomNav.Controls.Add(this.btnIconEmployees);
            this.flowBottomNav.Controls.Add(this.btnIconAttendance);
            this.flowBottomNav.Controls.Add(this.btnIconPayroll);
            this.flowBottomNav.Controls.Add(this.btnIconPerformance);
            this.flowBottomNav.Controls.Add(this.btnIconSettings);
            this.flowBottomNav.Location = new System.Drawing.Point(40, 896);
            this.flowBottomNav.Margin = new System.Windows.Forms.Padding(0);
            this.flowBottomNav.Name = "flowBottomNav";
            this.flowBottomNav.Size = new System.Drawing.Size(1847, 150);
            this.flowBottomNav.TabIndex = 4;
            // 
            // btnIconEmployees
            // 
            this.btnIconEmployees.Animated = true;
            this.btnIconEmployees.AutoRoundedCorners = true;
            this.btnIconEmployees.BorderRadius = 44;
            this.btnIconEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIconEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIconEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIconEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIconEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btnIconEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIconEmployees.ForeColor = System.Drawing.Color.White;
            this.btnIconEmployees.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnIconEmployees.Location = new System.Drawing.Point(20, 20);
            this.btnIconEmployees.Margin = new System.Windows.Forms.Padding(20);
            this.btnIconEmployees.Name = "btnIconEmployees";
            this.btnIconEmployees.Size = new System.Drawing.Size(260, 90);
            this.btnIconEmployees.TabIndex = 0;
            this.btnIconEmployees.Text = "EMPLOYEES";
            this.btnIconEmployees.Click += new System.EventHandler(this.btnIconEmployees_Click);
            // 
            // btnIconAttendance
            // 
            this.btnIconAttendance.Animated = true;
            this.btnIconAttendance.AutoRoundedCorners = true;
            this.btnIconAttendance.BorderRadius = 44;
            this.btnIconAttendance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnIconAttendance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIconAttendance.ForeColor = System.Drawing.Color.White;
            this.btnIconAttendance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.btnIconAttendance.Location = new System.Drawing.Point(320, 20);
            this.btnIconAttendance.Margin = new System.Windows.Forms.Padding(20);
            this.btnIconAttendance.Name = "btnIconAttendance";
            this.btnIconAttendance.Size = new System.Drawing.Size(260, 90);
            this.btnIconAttendance.TabIndex = 1;
            this.btnIconAttendance.Text = "ATTENDANCE";
            this.btnIconAttendance.Click += new System.EventHandler(this.btnIconAttendance_Click);
            // 
            // btnIconPayroll
            // 
            this.btnIconPayroll.Animated = true;
            this.btnIconPayroll.AutoRoundedCorners = true;
            this.btnIconPayroll.BorderRadius = 44;
            this.btnIconPayroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnIconPayroll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIconPayroll.ForeColor = System.Drawing.Color.White;
            this.btnIconPayroll.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.btnIconPayroll.Location = new System.Drawing.Point(620, 20);
            this.btnIconPayroll.Margin = new System.Windows.Forms.Padding(20);
            this.btnIconPayroll.Name = "btnIconPayroll";
            this.btnIconPayroll.Size = new System.Drawing.Size(260, 90);
            this.btnIconPayroll.TabIndex = 2;
            this.btnIconPayroll.Text = "PAYROLL";
            this.btnIconPayroll.Click += new System.EventHandler(this.btnIconPayroll_Click);
            // 
            // btnIconPerformance
            // 
            this.btnIconPerformance.Animated = true;
            this.btnIconPerformance.AutoRoundedCorners = true;
            this.btnIconPerformance.BorderRadius = 44;
            this.btnIconPerformance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.btnIconPerformance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIconPerformance.ForeColor = System.Drawing.Color.White;
            this.btnIconPerformance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.btnIconPerformance.Location = new System.Drawing.Point(920, 20);
            this.btnIconPerformance.Margin = new System.Windows.Forms.Padding(20);
            this.btnIconPerformance.Name = "btnIconPerformance";
            this.btnIconPerformance.Size = new System.Drawing.Size(260, 90);
            this.btnIconPerformance.TabIndex = 3;
            this.btnIconPerformance.Text = "PERFORMANCE";
            this.btnIconPerformance.Click += new System.EventHandler(this.btnIconPerformance_Click);
            // 
            // btnIconSettings
            // 
            this.btnIconSettings.Animated = true;
            this.btnIconSettings.AutoRoundedCorners = true;
            this.btnIconSettings.BorderRadius = 44;
            this.btnIconSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnIconSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIconSettings.ForeColor = System.Drawing.Color.White;
            this.btnIconSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(110)))));
            this.btnIconSettings.Location = new System.Drawing.Point(1220, 20);
            this.btnIconSettings.Margin = new System.Windows.Forms.Padding(20);
            this.btnIconSettings.Name = "btnIconSettings";
            this.btnIconSettings.Size = new System.Drawing.Size(260, 90);
            this.btnIconSettings.TabIndex = 4;
            this.btnIconSettings.Text = "SETTINGS";
            this.btnIconSettings.Click += new System.EventHandler(this.btnIconSettings_Click);
            // 
            // panelNotification
            // 
            this.panelNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.panelNotification.Controls.Add(this.lblNotification);
            this.panelNotification.Location = new System.Drawing.Point(40, 270);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(1842, 45);
            this.panelNotification.TabIndex = 3;
            // 
            // lblNotification
            // 
            this.lblNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNotification.ForeColor = System.Drawing.Color.White;
            this.lblNotification.Location = new System.Drawing.Point(0, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblNotification.Size = new System.Drawing.Size(1842, 45);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "You are currently set up to run payroll every month.";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowKpiRow
            // 
            this.flowKpiRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowKpiRow.BackColor = System.Drawing.Color.Transparent;
            this.flowKpiRow.Controls.Add(this.shadowEmployees);
            this.flowKpiRow.Controls.Add(this.shadowPresent);
            this.flowKpiRow.Controls.Add(this.shadowPaid);
            this.flowKpiRow.Controls.Add(this.shadowTotal);
            this.flowKpiRow.Location = new System.Drawing.Point(40, 120);
            this.flowKpiRow.Name = "flowKpiRow";
            this.flowKpiRow.Size = new System.Drawing.Size(1842, 140);
            this.flowKpiRow.TabIndex = 2;
            this.flowKpiRow.Paint += new System.Windows.Forms.PaintEventHandler(this.flowKpiRow_Paint);
            // 
            // shadowEmployees
            // 
            this.shadowEmployees.BackColor = System.Drawing.Color.Transparent;
            this.shadowEmployees.Controls.Add(this.lblKpiEmployees);
            this.shadowEmployees.Controls.Add(this.lblCardEmployeesTitle);
            this.shadowEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.shadowEmployees.Location = new System.Drawing.Point(3, 3);
            this.shadowEmployees.Name = "shadowEmployees";
            this.shadowEmployees.Radius = 6;
            this.shadowEmployees.ShadowColor = System.Drawing.Color.Gray;
            this.shadowEmployees.ShadowDepth = 20;
            this.shadowEmployees.Size = new System.Drawing.Size(320, 120);
            this.shadowEmployees.TabIndex = 0;
            // 
            // lblKpiEmployees
            // 
            this.lblKpiEmployees.AutoSize = true;
            this.lblKpiEmployees.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblKpiEmployees.ForeColor = System.Drawing.Color.White;
            this.lblKpiEmployees.Location = new System.Drawing.Point(20, 50);
            this.lblKpiEmployees.Name = "lblKpiEmployees";
            this.lblKpiEmployees.Size = new System.Drawing.Size(46, 54);
            this.lblKpiEmployees.TabIndex = 1;
            this.lblKpiEmployees.Text = "0";
            // 
            // lblCardEmployeesTitle
            // 
            this.lblCardEmployeesTitle.AutoSize = true;
            this.lblCardEmployeesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardEmployeesTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardEmployeesTitle.Location = new System.Drawing.Point(22, 18);
            this.lblCardEmployeesTitle.Name = "lblCardEmployeesTitle";
            this.lblCardEmployeesTitle.Size = new System.Drawing.Size(132, 23);
            this.lblCardEmployeesTitle.TabIndex = 0;
            this.lblCardEmployeesTitle.Text = "Total Employees";
            // 
            // shadowPresent
            // 
            this.shadowPresent.BackColor = System.Drawing.Color.Transparent;
            this.shadowPresent.Controls.Add(this.lblKpiPresentToday);
            this.shadowPresent.Controls.Add(this.lblCardPresentTitle);
            this.shadowPresent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.shadowPresent.Location = new System.Drawing.Point(329, 3);
            this.shadowPresent.Name = "shadowPresent";
            this.shadowPresent.Radius = 6;
            this.shadowPresent.ShadowColor = System.Drawing.Color.Gray;
            this.shadowPresent.ShadowDepth = 20;
            this.shadowPresent.Size = new System.Drawing.Size(320, 120);
            this.shadowPresent.TabIndex = 1;
            // 
            // lblKpiPresentToday
            // 
            this.lblKpiPresentToday.AutoSize = true;
            this.lblKpiPresentToday.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblKpiPresentToday.ForeColor = System.Drawing.Color.White;
            this.lblKpiPresentToday.Location = new System.Drawing.Point(20, 50);
            this.lblKpiPresentToday.Name = "lblKpiPresentToday";
            this.lblKpiPresentToday.Size = new System.Drawing.Size(46, 54);
            this.lblKpiPresentToday.TabIndex = 1;
            this.lblKpiPresentToday.Text = "0";
            // 
            // lblCardPresentTitle
            // 
            this.lblCardPresentTitle.AutoSize = true;
            this.lblCardPresentTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardPresentTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardPresentTitle.Location = new System.Drawing.Point(22, 18);
            this.lblCardPresentTitle.Name = "lblCardPresentTitle";
            this.lblCardPresentTitle.Size = new System.Drawing.Size(116, 23);
            this.lblCardPresentTitle.TabIndex = 0;
            this.lblCardPresentTitle.Text = "Present Today";
            // 
            // shadowPaid
            // 
            this.shadowPaid.BackColor = System.Drawing.Color.Transparent;
            this.shadowPaid.Controls.Add(this.lblKpiPaidThisMonth);
            this.shadowPaid.Controls.Add(this.lblCardPaidTitle);
            this.shadowPaid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.shadowPaid.Location = new System.Drawing.Point(655, 3);
            this.shadowPaid.Name = "shadowPaid";
            this.shadowPaid.Radius = 6;
            this.shadowPaid.ShadowColor = System.Drawing.Color.Gray;
            this.shadowPaid.ShadowDepth = 20;
            this.shadowPaid.Size = new System.Drawing.Size(320, 120);
            this.shadowPaid.TabIndex = 2;
            // 
            // lblKpiPaidThisMonth
            // 
            this.lblKpiPaidThisMonth.AutoSize = true;
            this.lblKpiPaidThisMonth.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblKpiPaidThisMonth.ForeColor = System.Drawing.Color.White;
            this.lblKpiPaidThisMonth.Location = new System.Drawing.Point(20, 50);
            this.lblKpiPaidThisMonth.Name = "lblKpiPaidThisMonth";
            this.lblKpiPaidThisMonth.Size = new System.Drawing.Size(140, 54);
            this.lblKpiPaidThisMonth.TabIndex = 1;
            this.lblKpiPaidThisMonth.Text = "₱ 0.00";
            // 
            // lblCardPaidTitle
            // 
            this.lblCardPaidTitle.AutoSize = true;
            this.lblCardPaidTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardPaidTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardPaidTitle.Location = new System.Drawing.Point(22, 18);
            this.lblCardPaidTitle.Name = "lblCardPaidTitle";
            this.lblCardPaidTitle.Size = new System.Drawing.Size(158, 23);
            this.lblCardPaidTitle.TabIndex = 0;
            this.lblCardPaidTitle.Text = "Paid This Month (₱)";
            // 
            // shadowTotal
            // 
            this.shadowTotal.BackColor = System.Drawing.Color.Transparent;
            this.shadowTotal.Controls.Add(this.lblKpiTotalPayrollCost);
            this.shadowTotal.Controls.Add(this.lblCardTotalTitle);
            this.shadowTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.shadowTotal.Location = new System.Drawing.Point(981, 3);
            this.shadowTotal.Name = "shadowTotal";
            this.shadowTotal.Radius = 6;
            this.shadowTotal.ShadowColor = System.Drawing.Color.Gray;
            this.shadowTotal.ShadowDepth = 20;
            this.shadowTotal.Size = new System.Drawing.Size(320, 120);
            this.shadowTotal.TabIndex = 3;
            // 
            // lblKpiTotalPayrollCost
            // 
            this.lblKpiTotalPayrollCost.AutoSize = true;
            this.lblKpiTotalPayrollCost.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotalPayrollCost.ForeColor = System.Drawing.Color.White;
            this.lblKpiTotalPayrollCost.Location = new System.Drawing.Point(20, 50);
            this.lblKpiTotalPayrollCost.Name = "lblKpiTotalPayrollCost";
            this.lblKpiTotalPayrollCost.Size = new System.Drawing.Size(140, 54);
            this.lblKpiTotalPayrollCost.TabIndex = 1;
            this.lblKpiTotalPayrollCost.Text = "₱ 0.00";
            // 
            // lblCardTotalTitle
            // 
            this.lblCardTotalTitle.AutoSize = true;
            this.lblCardTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardTotalTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTotalTitle.Location = new System.Drawing.Point(22, 18);
            this.lblCardTotalTitle.Name = "lblCardTotalTitle";
            this.lblCardTotalTitle.Size = new System.Drawing.Size(165, 23);
            this.lblCardTotalTitle.TabIndex = 0;
            this.lblCardTotalTitle.Text = "Total Payroll Cost (₱)";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.Location = new System.Drawing.Point(44, 80);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(399, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Welcome to Sansu Payroll Performance Dashboard.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(471, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard Overview";
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
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).EndInit();
            this.flowBottomNav.ResumeLayout(false);
            this.panelNotification.ResumeLayout(false);
            this.flowKpiRow.ResumeLayout(false);
            this.shadowEmployees.ResumeLayout(false);
            this.shadowEmployees.PerformLayout();
            this.shadowPresent.ResumeLayout(false);
            this.shadowPresent.PerformLayout();
            this.shadowPaid.ResumeLayout(false);
            this.shadowPaid.PerformLayout();
            this.shadowTotal.ResumeLayout(false);
            this.shadowTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panelContainer;

        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.FlowLayoutPanel flowKpiRow;
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

        private System.Windows.Forms.Panel panelNotification;
        private System.Windows.Forms.Label lblNotification;

        private System.Windows.Forms.FlowLayoutPanel flowBottomNav;
        private Guna.UI2.WinForms.Guna2Button btnIconEmployees;
        private Guna.UI2.WinForms.Guna2Button btnIconAttendance;
        private Guna.UI2.WinForms.Guna2Button btnIconPayroll;
        private Guna.UI2.WinForms.Guna2Button btnIconPerformance;
        private Guna.UI2.WinForms.Guna2Button btnIconSettings;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentActivity;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn Action;
    }
}
