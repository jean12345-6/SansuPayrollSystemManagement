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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYROLL MANAGEMENT";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpEnd.Location = new System.Drawing.Point(533, 115);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(260, 34);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(493, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpStart.Location = new System.Drawing.Point(223, 115);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(260, 34);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPeriod.Location = new System.Drawing.Point(20, 120);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(91, 29);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "Period:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(223, 75);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(440, 37);
            this.cboEmployee.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmployee.Location = new System.Drawing.Point(20, 80);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(128, 29);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // btnGeneratePayslip
            // 
            this.btnGeneratePayslip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeneratePayslip.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePayslip.Location = new System.Drawing.Point(1591, 80);
            this.btnGeneratePayslip.Name = "btnGeneratePayslip";
            this.btnGeneratePayslip.Size = new System.Drawing.Size(120, 32);
            this.btnGeneratePayslip.TabIndex = 8;
            this.btnGeneratePayslip.Text = "Generate";
            this.btnGeneratePayslip.Click += new System.EventHandler(this.btnGeneratePayslip_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1481, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnComputePayroll
            // 
            this.btnComputePayroll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComputePayroll.ForeColor = System.Drawing.Color.White;
            this.btnComputePayroll.Location = new System.Drawing.Point(1481, 120);
            this.btnComputePayroll.Name = "btnComputePayroll";
            this.btnComputePayroll.Size = new System.Drawing.Size(100, 32);
            this.btnComputePayroll.TabIndex = 9;
            this.btnComputePayroll.Text = "Compute";
            this.btnComputePayroll.Click += new System.EventHandler(this.btnComputePayroll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1591, 120);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvPayroll
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayroll.Location = new System.Drawing.Point(24, 310);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowHeadersWidth = 51;
            this.dgvPayroll.RowTemplate.Height = 28;
            this.dgvPayroll.Size = new System.Drawing.Size(1687, 594);
            this.dgvPayroll.TabIndex = 16;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPayroll.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayroll.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPayroll.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayroll.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayroll.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayroll.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPayroll.ThemeStyle.ReadOnly = false;
            this.dgvPayroll.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayroll.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayroll.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayroll.ThemeStyle.RowsStyle.Height = 28;
            this.dgvPayroll.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayroll.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll_CellContentClick);
            this.dgvPayroll.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayroll_CellFormatting);
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.cardTotalCost);
            this.panelSummary.Controls.Add(this.cardSalaryPaid);
            this.panelSummary.Controls.Add(this.cardBalance);
            this.panelSummary.Location = new System.Drawing.Point(24, 200);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1687, 100);
            this.panelSummary.TabIndex = 15;
            // 
            // cardTotalCost
            // 
            this.cardTotalCost.Controls.Add(this.lblTotalCost);
            this.cardTotalCost.Location = new System.Drawing.Point(5, 10);
            this.cardTotalCost.Name = "cardTotalCost";
            this.cardTotalCost.Size = new System.Drawing.Size(541, 80);
            this.cardTotalCost.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Location = new System.Drawing.Point(15, 30);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(176, 29);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "TOTAL COST";
            // 
            // cardSalaryPaid
            // 
            this.cardSalaryPaid.Controls.Add(this.lblSalaryPaid);
            this.cardSalaryPaid.Location = new System.Drawing.Point(598, 10);
            this.cardSalaryPaid.Name = "cardSalaryPaid";
            this.cardSalaryPaid.Size = new System.Drawing.Size(491, 80);
            this.cardSalaryPaid.TabIndex = 1;
            // 
            // lblSalaryPaid
            // 
            this.lblSalaryPaid.AutoSize = true;
            this.lblSalaryPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSalaryPaid.Location = new System.Drawing.Point(15, 30);
            this.lblSalaryPaid.Name = "lblSalaryPaid";
            this.lblSalaryPaid.Size = new System.Drawing.Size(176, 29);
            this.lblSalaryPaid.TabIndex = 0;
            this.lblSalaryPaid.Text = "SALARY PAID";
            // 
            // cardBalance
            // 
            this.cardBalance.Controls.Add(this.lblBalance);
            this.cardBalance.Location = new System.Drawing.Point(1167, 10);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.Size = new System.Drawing.Size(491, 80);
            this.cardBalance.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(15, 30);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(130, 29);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "BALANCE";
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(28, 939);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(80, 30);
            this.btnPrevPage.TabIndex = 17;
            this.btnPrevPage.Text = "< Prev";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(124, 939);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(80, 30);
            this.btnNextPage.TabIndex = 18;
            this.btnNextPage.Text = "Next >";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPageInfo.Location = new System.Drawing.Point(224, 946);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(83, 18);
            this.lblPageInfo.TabIndex = 19;
            this.lblPageInfo.Text = "Page 0 of 0";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(1467, 934);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(110, 30);
            this.btnExportExcel.TabIndex = 20;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Location = new System.Drawing.Point(1601, 934);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(110, 30);
            this.btnExportPdf.TabIndex = 21;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearch.Location = new System.Drawing.Point(14, 161);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(128, 20);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search (Name):";
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.cboStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboStatusFilter.ItemHeight = 30;
            this.cboStatusFilter.Location = new System.Drawing.Point(563, 156);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(160, 36);
            this.cboStatusFilter.TabIndex = 14;
            this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(503, 161);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEmployee.DefaultText = "";
            this.txtSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchEmployee.Location = new System.Drawing.Point(223, 156);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PlaceholderText = "";
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.Size = new System.Drawing.Size(260, 30);
            this.txtSearchEmployee.TabIndex = 12;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // PayrollControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "PayrollControl";
            this.Size = new System.Drawing.Size(1750, 1000);
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
