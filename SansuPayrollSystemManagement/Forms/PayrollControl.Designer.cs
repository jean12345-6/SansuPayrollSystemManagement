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
            this.cardBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.cardSalaryPaid = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSalaryPaid = new System.Windows.Forms.Label();
            this.cardTotalCost = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPrevPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportPdf = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.cardBalance.SuspendLayout();
            this.cardSalaryPaid.SuspendLayout();
            this.cardTotalCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1 (PAYROLL MANAGEMENT title)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYROLL MANAGEMENT";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmployee.Location = new System.Drawing.Point(20, 80);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(96, 24);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(130, 76);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(440, 32);
            this.cboEmployee.TabIndex = 2;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPeriod.Location = new System.Drawing.Point(20, 120);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(70, 24);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "Period:";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpStart.Location = new System.Drawing.Point(130, 116);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(260, 29);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label2 ("to")
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(400, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpEnd.Location = new System.Drawing.Point(440, 116);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(260, 29);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Location = new System.Drawing.Point(720, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGeneratePayslip
            // 
            this.btnGeneratePayslip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeneratePayslip.Location = new System.Drawing.Point(830, 76);
            this.btnGeneratePayslip.Name = "btnGeneratePayslip";
            this.btnGeneratePayslip.Size = new System.Drawing.Size(120, 32);
            this.btnGeneratePayslip.TabIndex = 8;
            this.btnGeneratePayslip.Text = "Generate";
            this.btnGeneratePayslip.Click += new System.EventHandler(this.btnGeneratePayslip_Click);
            // 
            // btnComputePayroll
            // 
            this.btnComputePayroll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComputePayroll.Location = new System.Drawing.Point(720, 116);
            this.btnComputePayroll.Name = "btnComputePayroll";
            this.btnComputePayroll.Size = new System.Drawing.Size(100, 32);
            this.btnComputePayroll.TabIndex = 9;
            this.btnComputePayroll.Text = "Compute";
            this.btnComputePayroll.Click += new System.EventHandler(this.btnComputePayroll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.Location = new System.Drawing.Point(830, 116);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearch.Location = new System.Drawing.Point(20, 165);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(107, 17);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search (Name):";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchEmployee.Location = new System.Drawing.Point(130, 160);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(260, 30);
            this.txtSearchEmployee.TabIndex = 12;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(410, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboStatusFilter.Location = new System.Drawing.Point(470, 160);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(160, 30);
            this.cboStatusFilter.TabIndex = 14;
            this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
            // 
            // panelSummary (3 top cards)
            // 
            this.panelSummary.Location = new System.Drawing.Point(24, 200);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(940, 100);
            this.panelSummary.TabIndex = 15;
            this.panelSummary.Controls.Add(this.cardTotalCost);
            this.panelSummary.Controls.Add(this.cardSalaryPaid);
            this.panelSummary.Controls.Add(this.cardBalance);
            // 
            // cardTotalCost
            // 
            this.cardTotalCost.Location = new System.Drawing.Point(5, 10);
            this.cardTotalCost.Name = "cardTotalCost";
            this.cardTotalCost.Size = new System.Drawing.Size(300, 80);
            this.cardTotalCost.TabIndex = 0;
            this.cardTotalCost.Controls.Add(this.lblTotalCost);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Location = new System.Drawing.Point(15, 30);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(115, 24);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "TOTAL COST";
            // 
            // cardSalaryPaid
            // 
            this.cardSalaryPaid.Location = new System.Drawing.Point(320, 10);
            this.cardSalaryPaid.Name = "cardSalaryPaid";
            this.cardSalaryPaid.Size = new System.Drawing.Size(300, 80);
            this.cardSalaryPaid.TabIndex = 1;
            this.cardSalaryPaid.Controls.Add(this.lblSalaryPaid);
            // 
            // lblSalaryPaid
            // 
            this.lblSalaryPaid.AutoSize = true;
            this.lblSalaryPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSalaryPaid.Location = new System.Drawing.Point(15, 30);
            this.lblSalaryPaid.Name = "lblSalaryPaid";
            this.lblSalaryPaid.Size = new System.Drawing.Size(139, 24);
            this.lblSalaryPaid.TabIndex = 0;
            this.lblSalaryPaid.Text = "SALARY PAID";
            // 
            // cardBalance
            // 
            this.cardBalance.Location = new System.Drawing.Point(635, 10);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.Size = new System.Drawing.Size(300, 80);
            this.cardBalance.TabIndex = 2;
            this.cardBalance.Controls.Add(this.lblBalance);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(15, 30);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(106, 24);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "BALANCE";
            // 
            // dgvPayroll
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayroll.Location = new System.Drawing.Point(24, 310);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowTemplate.Height = 28;
            this.dgvPayroll.Size = new System.Drawing.Size(940, 360);
            this.dgvPayroll.TabIndex = 16;
            this.dgvPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll_CellContentClick);
            this.dgvPayroll.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayroll_CellFormatting);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevPage.Location = new System.Drawing.Point(24, 680);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(80, 30);
            this.btnPrevPage.TabIndex = 17;
            this.btnPrevPage.Text = "< Prev";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextPage.Location = new System.Drawing.Point(120, 680);
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
            this.lblPageInfo.Location = new System.Drawing.Point(220, 687);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(62, 15);
            this.lblPageInfo.TabIndex = 19;
            this.lblPageInfo.Text = "Page 0 of 0";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(720, 680);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(110, 30);
            this.btnExportExcel.TabIndex = 20;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportPdf.Location = new System.Drawing.Point(854, 680);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(110, 30);
            this.btnExportPdf.TabIndex = 21;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // PayrollControl
            // 
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
            this.Size = new System.Drawing.Size(1000, 730);
            this.Load += new System.EventHandler(this.PayrollControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.cardBalance.ResumeLayout(false);
            this.cardBalance.PerformLayout();
            this.cardSalaryPaid.ResumeLayout(false);
            this.cardSalaryPaid.PerformLayout();
            this.cardTotalCost.ResumeLayout(false);
            this.cardTotalCost.PerformLayout();
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
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchEmployee;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatusFilter;
        private Guna.UI2.WinForms.Guna2Button btnPrevPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2Button btnExportPdf;
    }
}
