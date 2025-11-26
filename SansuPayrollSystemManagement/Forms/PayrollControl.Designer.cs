namespace SansuPayrollSystemManagement.Forms
{
    partial class PayrollControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnComputePayroll = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPayroll = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.cardTotalCost = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.cardSalaryPaid = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSalaryPaid = new System.Windows.Forms.Label();
            this.cardBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnPrevPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportPdf = new Guna.UI2.WinForms.Guna2Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIconEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconPerformance = new Guna.UI2.WinForms.Guna2Button();
            this.btnIconSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.cardTotalCost.SuspendLayout();
            this.cardSalaryPaid.SuspendLayout();
            this.cardBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYROLL MANAGEMENT";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpEnd.Location = new System.Drawing.Point(505, 172);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(260, 32);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(460, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpStart.Location = new System.Drawing.Point(190, 172);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(260, 32);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblPeriod.Location = new System.Drawing.Point(20, 170);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(107, 33);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "Period:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(190, 119);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(420, 35);
            this.cboEmployee.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblEmployee.Location = new System.Drawing.Point(20, 120);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(155, 33);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 24;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(1320, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnComputePayroll
            // 
            this.btnComputePayroll.AutoRoundedCorners = true;
            this.btnComputePayroll.BorderRadius = 24;
            this.btnComputePayroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputePayroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputePayroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComputePayroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComputePayroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnComputePayroll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnComputePayroll.ForeColor = System.Drawing.Color.Black;
            this.btnComputePayroll.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnComputePayroll.Location = new System.Drawing.Point(1320, 180);
            this.btnComputePayroll.Name = "btnComputePayroll";
            this.btnComputePayroll.Size = new System.Drawing.Size(150, 50);
            this.btnComputePayroll.TabIndex = 9;
            this.btnComputePayroll.Text = "Compute";
            this.btnComputePayroll.Click += new System.EventHandler(this.btnComputePayroll_Click);
            // 
            // dgvPayroll
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayroll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvPayroll.Location = new System.Drawing.Point(24, 420);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowHeadersWidth = 51;
            this.dgvPayroll.RowTemplate.Height = 50;
            this.dgvPayroll.Size = new System.Drawing.Size(1974, 460);
            this.dgvPayroll.TabIndex = 16;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPayroll.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPayroll.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvPayroll.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvPayroll.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayroll.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayroll.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvPayroll.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayroll.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvPayroll.ThemeStyle.ReadOnly = false;
            this.dgvPayroll.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPayroll.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayroll.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayroll.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvPayroll.ThemeStyle.RowsStyle.Height = 50;
            this.dgvPayroll.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvPayroll.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll_CellContentClick);
            this.dgvPayroll.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayroll_CellFormatting);
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.Transparent;
            this.panelSummary.Controls.Add(this.cardTotalCost);
            this.panelSummary.Controls.Add(this.cardSalaryPaid);
            this.panelSummary.Controls.Add(this.cardBalance);
            this.panelSummary.Location = new System.Drawing.Point(24, 275);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1687, 130);
            this.panelSummary.TabIndex = 15;
            // 
            // cardTotalCost
            // 
            this.cardTotalCost.BorderRadius = 10;
            this.cardTotalCost.Controls.Add(this.lblTotalCost);
            this.cardTotalCost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardTotalCost.Location = new System.Drawing.Point(5, 10);
            this.cardTotalCost.Name = "cardTotalCost";
            this.cardTotalCost.Size = new System.Drawing.Size(540, 110);
            this.cardTotalCost.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblTotalCost.Location = new System.Drawing.Point(20, 30);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(129, 54);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "₱0.00";
            // 
            // cardSalaryPaid
            // 
            this.cardSalaryPaid.BorderRadius = 10;
            this.cardSalaryPaid.Controls.Add(this.lblSalaryPaid);
            this.cardSalaryPaid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardSalaryPaid.Location = new System.Drawing.Point(573, 10);
            this.cardSalaryPaid.Name = "cardSalaryPaid";
            this.cardSalaryPaid.Size = new System.Drawing.Size(540, 110);
            this.cardSalaryPaid.TabIndex = 1;
            // 
            // lblSalaryPaid
            // 
            this.lblSalaryPaid.AutoSize = true;
            this.lblSalaryPaid.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSalaryPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblSalaryPaid.Location = new System.Drawing.Point(20, 30);
            this.lblSalaryPaid.Name = "lblSalaryPaid";
            this.lblSalaryPaid.Size = new System.Drawing.Size(129, 54);
            this.lblSalaryPaid.TabIndex = 0;
            this.lblSalaryPaid.Text = "₱0.00";
            // 
            // cardBalance
            // 
            this.cardBalance.BorderRadius = 10;
            this.cardBalance.Controls.Add(this.lblBalance);
            this.cardBalance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardBalance.Location = new System.Drawing.Point(1141, 10);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.Size = new System.Drawing.Size(540, 110);
            this.cardBalance.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblBalance.Location = new System.Drawing.Point(20, 30);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(129, 54);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "₱0.00";
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.AutoRoundedCorners = true;
            this.btnPrevPage.BorderRadius = 19;
            this.btnPrevPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPrevPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrevPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnPrevPage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnPrevPage.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPrevPage.Location = new System.Drawing.Point(24, 900);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(80, 40);
            this.btnPrevPage.TabIndex = 17;
            this.btnPrevPage.Text = "< Prev";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.AutoRoundedCorners = true;
            this.btnNextPage.BorderRadius = 19;
            this.btnNextPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnNextPage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnNextPage.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNextPage.Location = new System.Drawing.Point(120, 900);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(80, 40);
            this.btnNextPage.TabIndex = 18;
            this.btnNextPage.Text = "Next >";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPageInfo.Location = new System.Drawing.Point(220, 909);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(95, 23);
            this.lblPageInfo.TabIndex = 19;
            this.lblPageInfo.Text = "Page 0 of 0";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AutoRoundedCorners = true;
            this.btnExportExcel.BorderRadius = 19;
            this.btnExportExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExportExcel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnExportExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnExportExcel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(1353, 900);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(163, 40);
            this.btnExportExcel.TabIndex = 20;
            this.btnExportExcel.Text = "Export Payslip";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.AutoRoundedCorners = true;
            this.btnExportPdf.BorderRadius = 19;
            this.btnExportPdf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExportPdf.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnExportPdf.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnExportPdf.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnExportPdf.Location = new System.Drawing.Point(1522, 900);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(189, 40);
            this.btnExportPdf.TabIndex = 21;
            this.btnExportPdf.Text = "Export All Payroll";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblSearch.Location = new System.Drawing.Point(20, 222);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(200, 30);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search (Name):";
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.cboStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cboStatusFilter.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboStatusFilter.ForeColor = System.Drawing.Color.Black;
            this.cboStatusFilter.ItemHeight = 30;
            this.cboStatusFilter.Location = new System.Drawing.Point(600, 218);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(180, 36);
            this.cboStatusFilter.TabIndex = 14;
            this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblStatus.Location = new System.Drawing.Point(500, 222);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 30);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEmployee.DefaultText = "";
            this.txtSearchEmployee.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSearchEmployee.Location = new System.Drawing.Point(220, 218);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PlaceholderText = "";
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.Size = new System.Drawing.Size(260, 38);
            this.txtSearchEmployee.TabIndex = 12;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // btnIconEmployees
            // 
            this.btnIconEmployees.Animated = true;
            this.btnIconEmployees.AutoRoundedCorners = true;
            this.btnIconEmployees.BorderRadius = 39;
            this.btnIconEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIconEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIconEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconEmployees.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnIconEmployees.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnIconEmployees.Location = new System.Drawing.Point(13, 1030);
            this.btnIconEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconEmployees.Name = "btnIconEmployees";
            this.btnIconEmployees.Size = new System.Drawing.Size(300, 80);
            this.btnIconEmployees.TabIndex = 22;
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
            this.btnIconAttendance.Location = new System.Drawing.Point(356, 1030);
            this.btnIconAttendance.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconAttendance.Name = "btnIconAttendance";
            this.btnIconAttendance.Size = new System.Drawing.Size(300, 80);
            this.btnIconAttendance.TabIndex = 23;
            this.btnIconAttendance.Text = "📅 ATTENDANCE";
            this.btnIconAttendance.Click += new System.EventHandler(this.btnIconAttendance_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(698, 1030);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(300, 80);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "🏠 DASHBOARD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnIconPerformance.Location = new System.Drawing.Point(1389, 1030);
            this.btnIconPerformance.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconPerformance.Name = "btnIconPerformance";
            this.btnIconPerformance.Size = new System.Drawing.Size(300, 80);
            this.btnIconPerformance.TabIndex = 25;
            this.btnIconPerformance.Text = "⭐ PERFORMANCE";
            this.btnIconPerformance.Click += new System.EventHandler(this.btnIconPerformance_Click);
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
            this.btnIconSettings.Location = new System.Drawing.Point(1736, 1030);
            this.btnIconSettings.Margin = new System.Windows.Forms.Padding(5);
            this.btnIconSettings.Name = "btnIconSettings";
            this.btnIconSettings.Size = new System.Drawing.Size(300, 80);
            this.btnIconSettings.TabIndex = 26;
            this.btnIconSettings.Text = "⚙️ SETTINGS";
            this.btnIconSettings.Click += new System.EventHandler(this.btnIconSettings_Click);
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
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // PayrollControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnIconSettings);
            this.Controls.Add(this.btnIconPerformance);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnIconAttendance);
            this.Controls.Add(this.btnIconEmployees);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.cboStatusFilter);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnComputePayroll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.label1);
            this.Name = "PayrollControl";
            this.Size = new System.Drawing.Size(1942, 1120);
            this.Load += new System.EventHandler(this.PayrollControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.cardTotalCost.ResumeLayout(false);
            this.cardTotalCost.PerformLayout();
            this.cardSalaryPaid.ResumeLayout(false);
            this.cardSalaryPaid.PerformLayout();
            this.cardBalance.ResumeLayout(false);
            this.cardBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnComputePayroll;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayroll;
        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private Guna.UI2.WinForms.Guna2Panel cardBalance;
        private System.Windows.Forms.Label lblBalance;
        private Guna.UI2.WinForms.Guna2Panel cardSalaryPaid;
        private System.Windows.Forms.Label lblSalaryPaid;
        private Guna.UI2.WinForms.Guna2Panel cardTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private Guna.UI2.WinForms.Guna2Button btnPrevPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2Button btnExportPdf;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatusFilter;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchEmployee;
        private Guna.UI2.WinForms.Guna2Button btnIconEmployees;
        private Guna.UI2.WinForms.Guna2Button btnIconAttendance;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnIconPerformance;
        private Guna.UI2.WinForms.Guna2Button btnIconSettings;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}
