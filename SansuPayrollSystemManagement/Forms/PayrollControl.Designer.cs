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
            this.btnGeneratePayslip = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnComputePayroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.cardTotalCost.SuspendLayout();
            this.cardSalaryPaid.SuspendLayout();
            this.cardBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // PayrollControl (root)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Name = "PayrollControl";
            this.Size = new System.Drawing.Size(1750, 1000);
            this.Load += new System.EventHandler(this.PayrollControl_Load);
            // 
            // label1 - title
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(843, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYROLL MANAGEMENT";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblEmployee.Location = new System.Drawing.Point(20, 120);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(147, 33);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
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
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblPeriod.Location = new System.Drawing.Point(20, 170);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(111, 33);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "Period:";
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
            // label2 ("to")
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(460, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
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
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblSearch.Location = new System.Drawing.Point(20, 222);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(189, 30);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search (Name):";
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblStatus.Location = new System.Drawing.Point(500, 222);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 30);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
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
            // Top right buttons (Save / Generate / Compute / Back)
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 24;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnSave.FillColor = System.Drawing.Color.Goldenrod;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(1320, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGeneratePayslip
            // 
            this.btnGeneratePayslip.AutoRoundedCorners = true;
            this.btnGeneratePayslip.BorderRadius = 24;
            this.btnGeneratePayslip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePayslip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePayslip.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnGeneratePayslip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnGeneratePayslip.FillColor = System.Drawing.Color.SteelBlue;
            this.btnGeneratePayslip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeneratePayslip.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePayslip.Location = new System.Drawing.Point(1480, 120);
            this.btnGeneratePayslip.Name = "btnGeneratePayslip";
            this.btnGeneratePayslip.Size = new System.Drawing.Size(190, 50);
            this.btnGeneratePayslip.TabIndex = 8;
            this.btnGeneratePayslip.Text = "Generate Payslip";
            this.btnGeneratePayslip.Click += new System.EventHandler(this.btnGeneratePayslip_Click);
            // 
            // btnComputePayroll
            // 
            this.btnComputePayroll.AutoRoundedCorners = true;
            this.btnComputePayroll.BorderRadius = 24;
            this.btnComputePayroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputePayroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputePayroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnComputePayroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnComputePayroll.FillColor = System.Drawing.Color.Goldenrod;
            this.btnComputePayroll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnComputePayroll.ForeColor = System.Drawing.Color.Black;
            this.btnComputePayroll.Location = new System.Drawing.Point(1320, 180);
            this.btnComputePayroll.Name = "btnComputePayroll";
            this.btnComputePayroll.Size = new System.Drawing.Size(150, 50);
            this.btnComputePayroll.TabIndex = 9;
            this.btnComputePayroll.Text = "Compute";
            this.btnComputePayroll.Click += new System.EventHandler(this.btnComputePayroll_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 24;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnBack.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1480, 180);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 50);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelSummary (KPI row)
            // 
            this.panelSummary.BackColor = System.Drawing.Color.Transparent;
            this.panelSummary.Location = new System.Drawing.Point(24, 275);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1687, 130);
            this.panelSummary.TabIndex = 15;
            this.panelSummary.Controls.Add(this.cardTotalCost);
            this.panelSummary.Controls.Add(this.cardSalaryPaid);
            this.panelSummary.Controls.Add(this.cardBalance);
            // 
            // cardTotalCost
            // 
            this.cardTotalCost.BorderRadius = 10;
            this.cardTotalCost.FillColor = System.Drawing.Color.OrangeRed; // Total Payroll Cost color
            this.cardTotalCost.Location = new System.Drawing.Point(5, 10);
            this.cardTotalCost.Name = "cardTotalCost";
            this.cardTotalCost.Size = new System.Drawing.Size(540, 110);
            this.cardTotalCost.TabIndex = 0;
            this.cardTotalCost.Controls.Add(this.lblTotalCost);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.ForeColor = System.Drawing.Color.White;
            this.lblTotalCost.Location = new System.Drawing.Point(20, 30);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(145, 54);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "₱0.00";
            // 
            // cardSalaryPaid
            // 
            this.cardSalaryPaid.BorderRadius = 10;
            this.cardSalaryPaid.FillColor = System.Drawing.Color.FromArgb(55, 71, 79); // dark gray like Paid This Month
            this.cardSalaryPaid.Location = new System.Drawing.Point(573, 10);
            this.cardSalaryPaid.Name = "cardSalaryPaid";
            this.cardSalaryPaid.Size = new System.Drawing.Size(540, 110);
            this.cardSalaryPaid.TabIndex = 1;
            this.cardSalaryPaid.Controls.Add(this.lblSalaryPaid);
            // 
            // lblSalaryPaid
            // 
            this.lblSalaryPaid.AutoSize = true;
            this.lblSalaryPaid.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSalaryPaid.ForeColor = System.Drawing.Color.White;
            this.lblSalaryPaid.Location = new System.Drawing.Point(20, 30);
            this.lblSalaryPaid.Name = "lblSalaryPaid";
            this.lblSalaryPaid.Size = new System.Drawing.Size(145, 54);
            this.lblSalaryPaid.TabIndex = 0;
            this.lblSalaryPaid.Text = "₱0.00";
            // 
            // cardBalance
            // 
            this.cardBalance.BorderRadius = 10;
            this.cardBalance.FillColor = System.Drawing.Color.FromArgb(0, 121, 107); // teal / green like Present Today
            this.cardBalance.Location = new System.Drawing.Point(1141, 10);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.Size = new System.Drawing.Size(540, 110);
            this.cardBalance.TabIndex = 2;
            this.cardBalance.Controls.Add(this.lblBalance);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(20, 30);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(145, 54);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "₱0.00";
            // 
            // dgvPayroll
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayroll.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayroll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll.ColumnHeadersHeight = 45;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayroll.EnableHeadersVisualStyles = false;
            this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvPayroll.Location = new System.Drawing.Point(24, 420);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowHeadersWidth = 51;
            this.dgvPayroll.RowTemplate.Height = 50;
            this.dgvPayroll.Size = new System.Drawing.Size(1687, 460);
            this.dgvPayroll.TabIndex = 16;
            this.dgvPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll_CellContentClick);
            this.dgvPayroll.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayroll_CellFormatting);
            // 
            // Paging buttons
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.AutoRoundedCorners = true;
            this.btnPrevPage.BorderRadius = 19;
            this.btnPrevPage.FillColor = System.Drawing.Color.LightGray;
            this.btnPrevPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrevPage.ForeColor = System.Drawing.Color.Black;
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
            this.btnNextPage.FillColor = System.Drawing.Color.LightGray;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.ForeColor = System.Drawing.Color.Black;
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
            this.lblPageInfo.Location = new System.Drawing.Point(220, 909);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(94, 23);
            this.lblPageInfo.TabIndex = 19;
            this.lblPageInfo.Text = "Page 0 of 0";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AutoRoundedCorners = true;
            this.btnExportExcel.BorderRadius = 19;
            this.btnExportExcel.FillColor = System.Drawing.Color.SteelBlue;
            this.btnExportExcel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(1467, 900);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(110, 40);
            this.btnExportExcel.TabIndex = 20;
            this.btnExportExcel.Text = "Export";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.AutoRoundedCorners = true;
            this.btnExportPdf.BorderRadius = 19;
            this.btnExportPdf.FillColor = System.Drawing.Color.SteelBlue;
            this.btnExportPdf.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Location = new System.Drawing.Point(1601, 900);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(110, 40);
            this.btnExportPdf.TabIndex = 21;
            this.btnExportPdf.Text = "Export";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // add controls to root
            // 
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
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnComputePayroll);
            this.Controls.Add(this.btnGeneratePayslip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.label1);

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
        private Guna.UI2.WinForms.Guna2Button btnGeneratePayslip;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnComputePayroll;
        private Guna.UI2.WinForms.Guna2Button btnBack;
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
    }
}
