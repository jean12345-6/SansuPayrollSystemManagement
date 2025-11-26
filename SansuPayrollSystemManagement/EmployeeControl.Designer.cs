using System.Drawing;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    partial class EmployeeControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconPerformance = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconPayroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeaderUnderline = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.panelContainer);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1924, 1055);
            this.panelBackground.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelContainer.Controls.Add(this.panelContent);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1924, 1055);
            this.panelContainer.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelContent.Controls.Add(this.guna2Button1);
            this.panelContent.Controls.Add(this.btnIconSettings);
            this.panelContent.Controls.Add(this.btnIconPerformance);
            this.panelContent.Controls.Add(this.btnIconPayroll);
            this.panelContent.Controls.Add(this.btnIconAttendance);
            this.panelContent.Controls.Add(this.btnIconEmployees);
            this.panelContent.Controls.Add(this.btnLogout);
            this.panelContent.Controls.Add(this.dgvEmployees);
            this.panelContent.Controls.Add(this.btnSearch);
            this.panelContent.Controls.Add(this.txtSearch);
            this.panelContent.Controls.Add(this.btnAddEmployee);
            this.panelContent.Controls.Add(this.panelHeaderUnderline);
            this.panelContent.Controls.Add(this.lblSubTitle);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(3000, 1300);
            this.panelContent.TabIndex = 0;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 39;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(698, 880);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(300, 80);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "🏠 DASHBOARD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnIconSettings.TabIndex = 12;
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
            this.btnIconPerformance.TabIndex = 11;
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
            this.btnIconPayroll.TabIndex = 10;
            this.btnIconPayroll.Text = "💰 PAYROLL";
            this.btnIconPayroll.Click += new System.EventHandler(this.btnIconPayroll_Click);
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
            this.btnIconAttendance.TabIndex = 9;
            this.btnIconAttendance.Text = "📅 ATTENDANCE";
            this.btnIconAttendance.Click += new System.EventHandler(this.btnIconAttendance_Click);
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
            this.btnIconEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIconEmployees.ForeColor = System.Drawing.Color.Black;
            this.btnIconEmployees.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnIconEmployees.Location = new System.Drawing.Point(13, 880);
            this.btnIconEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconEmployees.Name = "btnIconEmployees";
            this.btnIconEmployees.Size = new System.Drawing.Size(300, 80);
            this.btnIconEmployees.TabIndex = 8;
            this.btnIconEmployees.Text = "👥 EMPLOYEES";
            this.btnIconEmployees.Click += new System.EventHandler(this.btnIconEmployees_Click);
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
            // dgvEmployees
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployees.ColumnHeadersHeight = 40;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvEmployees.Location = new System.Drawing.Point(30, 220);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 38;
            this.dgvEmployees.Size = new System.Drawing.Size(1934, 620);
            this.dgvEmployees.TabIndex = 6;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmployees.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmployees.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvEmployees.ThemeStyle.ReadOnly = false;
            this.dgvEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvEmployees.ThemeStyle.RowsStyle.Height = 38;
            this.dgvEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            //this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnSearch.Location = new System.Drawing.Point(1550, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 49);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(30, 147);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search employee name…";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1500, 49);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BorderRadius = 8;
            this.btnAddEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(1750, 147);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(205, 49);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "+ Add Employee";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // panelHeaderUnderline
            // 
            this.panelHeaderUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.panelHeaderUnderline.Location = new System.Drawing.Point(30, 115);
            this.panelHeaderUnderline.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeaderUnderline.Name = "panelHeaderUnderline";
            this.panelHeaderUnderline.Size = new System.Drawing.Size(1967, 10);
            this.panelHeaderUnderline.TabIndex = 2;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSubTitle.Location = new System.Drawing.Point(30, 77);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(800, 30);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Manage all employees and their information";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panelBackground);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1924, 1055);
            this.panelBackground.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBackground;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panelHeaderUnderline;
        private Guna.UI2.WinForms.Guna2Button btnAddEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployees;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnIconSettings;
        private Guna.UI2.WinForms.Guna2Button btnIconPerformance;
        private Guna.UI2.WinForms.Guna2Button btnIconPayroll;
        private Guna.UI2.WinForms.Guna2Button btnIconAttendance;
        private Guna.UI2.WinForms.Guna2Button btnIconEmployees;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
