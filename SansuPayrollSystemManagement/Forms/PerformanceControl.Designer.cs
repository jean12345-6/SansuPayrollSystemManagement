namespace SansuPayrollSystemManagement.Forms
{
    partial class PerformanceControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.cardTotalSales = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalSalesCaption = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.cardAvgFeedback = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAvgFeedbackCaption = new System.Windows.Forms.Label();
            this.lblAvgFeedback = new System.Windows.Forms.Label();
            this.cardAvgAttendance = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAvgAttendanceCaption = new System.Windows.Forms.Label();
            this.lblAvgAttendance = new System.Windows.Forms.Label();
            this.dgvPerformance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPrevPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnExportPdf = new Guna.UI2.WinForms.Guna2Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panelSummary.SuspendLayout();
            this.cardTotalSales.SuspendLayout();
            this.cardAvgFeedback.SuspendLayout();
            this.cardAvgAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).BeginInit();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PERFORMANCE";
            // 
            // lblEmployee
            // 
            this.lblEmployee.Location = new System.Drawing.Point(0, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(100, 23);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.Location = new System.Drawing.Point(0, 0);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(121, 24);
            this.cboEmployee.TabIndex = 2;
            // 
            // lblPeriod
            // 
            this.lblPeriod.Location = new System.Drawing.Point(0, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(100, 23);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "Period:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(0, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(100, 23);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "to";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search (Name):";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEmployee.DefaultText = "";
            this.txtSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchEmployee.Location = new System.Drawing.Point(0, 0);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PlaceholderText = "";
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.Size = new System.Drawing.Size(229, 48);
            this.txtSearchEmployee.TabIndex = 8;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.cboStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboStatusFilter.ItemHeight = 30;
            this.cboStatusFilter.Location = new System.Drawing.Point(0, 0);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(140, 36);
            this.cboStatusFilter.TabIndex = 10;
            this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.cardTotalSales);
            this.panelSummary.Controls.Add(this.cardAvgFeedback);
            this.panelSummary.Controls.Add(this.cardAvgAttendance);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.Location = new System.Drawing.Point(0, 100);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1750, 100);
            this.panelSummary.TabIndex = 1;
            // 
            // cardTotalSales
            // 
            this.cardTotalSales.Controls.Add(this.lblTotalSalesCaption);
            this.cardTotalSales.Controls.Add(this.lblTotalSales);
            this.cardTotalSales.Location = new System.Drawing.Point(0, 0);
            this.cardTotalSales.Name = "cardTotalSales";
            this.cardTotalSales.Size = new System.Drawing.Size(200, 100);
            this.cardTotalSales.TabIndex = 0;
            // 
            // lblTotalSalesCaption
            // 
            this.lblTotalSalesCaption.Location = new System.Drawing.Point(0, 0);
            this.lblTotalSalesCaption.Name = "lblTotalSalesCaption";
            this.lblTotalSalesCaption.Size = new System.Drawing.Size(100, 23);
            this.lblTotalSalesCaption.TabIndex = 0;
            this.lblTotalSalesCaption.Text = "Total Sales";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Location = new System.Drawing.Point(0, 0);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(100, 23);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "0.00";
            // 
            // cardAvgFeedback
            // 
            this.cardAvgFeedback.Controls.Add(this.lblAvgFeedbackCaption);
            this.cardAvgFeedback.Controls.Add(this.lblAvgFeedback);
            this.cardAvgFeedback.Location = new System.Drawing.Point(0, 0);
            this.cardAvgFeedback.Name = "cardAvgFeedback";
            this.cardAvgFeedback.Size = new System.Drawing.Size(200, 100);
            this.cardAvgFeedback.TabIndex = 1;
            // 
            // lblAvgFeedbackCaption
            // 
            this.lblAvgFeedbackCaption.Location = new System.Drawing.Point(0, 0);
            this.lblAvgFeedbackCaption.Name = "lblAvgFeedbackCaption";
            this.lblAvgFeedbackCaption.Size = new System.Drawing.Size(100, 23);
            this.lblAvgFeedbackCaption.TabIndex = 0;
            this.lblAvgFeedbackCaption.Text = "Average Feedback Score";
            // 
            // lblAvgFeedback
            // 
            this.lblAvgFeedback.Location = new System.Drawing.Point(0, 0);
            this.lblAvgFeedback.Name = "lblAvgFeedback";
            this.lblAvgFeedback.Size = new System.Drawing.Size(100, 23);
            this.lblAvgFeedback.TabIndex = 1;
            this.lblAvgFeedback.Text = "0.00";
            // 
            // cardAvgAttendance
            // 
            this.cardAvgAttendance.Controls.Add(this.lblAvgAttendanceCaption);
            this.cardAvgAttendance.Controls.Add(this.lblAvgAttendance);
            this.cardAvgAttendance.Location = new System.Drawing.Point(0, 0);
            this.cardAvgAttendance.Name = "cardAvgAttendance";
            this.cardAvgAttendance.Size = new System.Drawing.Size(200, 100);
            this.cardAvgAttendance.TabIndex = 2;
            // 
            // lblAvgAttendanceCaption
            // 
            this.lblAvgAttendanceCaption.Location = new System.Drawing.Point(0, 0);
            this.lblAvgAttendanceCaption.Name = "lblAvgAttendanceCaption";
            this.lblAvgAttendanceCaption.Size = new System.Drawing.Size(100, 23);
            this.lblAvgAttendanceCaption.TabIndex = 0;
            this.lblAvgAttendanceCaption.Text = "Average Attendance Score";
            // 
            // lblAvgAttendance
            // 
            this.lblAvgAttendance.Location = new System.Drawing.Point(0, 0);
            this.lblAvgAttendance.Name = "lblAvgAttendance";
            this.lblAvgAttendance.Size = new System.Drawing.Size(100, 23);
            this.lblAvgAttendance.TabIndex = 1;
            this.lblAvgAttendance.Text = "0.00";
            // 
            // dgvPerformance
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPerformance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerformance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPerformance.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerformance.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerformance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerformance.Location = new System.Drawing.Point(0, 200);
            this.dgvPerformance.Name = "dgvPerformance";
            this.dgvPerformance.RowHeadersVisible = false;
            this.dgvPerformance.RowHeadersWidth = 51;
            this.dgvPerformance.Size = new System.Drawing.Size(1750, 700);
            this.dgvPerformance.TabIndex = 0;
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPerformance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerformance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerformance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPerformance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPerformance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerformance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPerformance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPerformance.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvPerformance.ThemeStyle.ReadOnly = false;
            this.dgvPerformance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerformance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerformance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerformance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPerformance.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPerformance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerformance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPerformance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformance_CellContentClick);
            this.dgvPerformance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPerformance_CellFormatting);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(1035, 0);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(180, 45);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "< Prev";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(545, 0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(180, 45);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "Next >";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Location = new System.Drawing.Point(21, 6);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(100, 23);
            this.lblPageInfo.TabIndex = 2;
            this.lblPageInfo.Text = "Page 0 of 0";
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Location = new System.Drawing.Point(138, 0);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(180, 45);
            this.btnExportPdf.TabIndex = 3;
            this.btnExportPdf.Text = "Export";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.lblEmployee);
            this.topPanel.Controls.Add(this.cboEmployee);
            this.topPanel.Controls.Add(this.lblPeriod);
            this.topPanel.Controls.Add(this.dtpStart);
            this.topPanel.Controls.Add(this.lblTo);
            this.topPanel.Controls.Add(this.dtpEnd);
            this.topPanel.Controls.Add(this.lblSearch);
            this.topPanel.Controls.Add(this.txtSearchEmployee);
            this.topPanel.Controls.Add(this.lblStatus);
            this.topPanel.Controls.Add(this.cboStatusFilter);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1750, 100);
            this.topPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnPrevPage);
            this.bottomPanel.Controls.Add(this.btnNextPage);
            this.bottomPanel.Controls.Add(this.lblPageInfo);
            this.bottomPanel.Controls.Add(this.btnExportPdf);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 900);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1750, 100);
            this.bottomPanel.TabIndex = 3;
            // 
            // PerformanceControl
            // 
            this.Controls.Add(this.dgvPerformance);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "PerformanceControl";
            this.Size = new System.Drawing.Size(1750, 1000);
            this.Load += new System.EventHandler(this.PerformanceControl_Load);
            this.panelSummary.ResumeLayout(false);
            this.cardTotalSales.ResumeLayout(false);
            this.cardAvgFeedback.ResumeLayout(false);
            this.cardAvgAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchEmployee;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatusFilter;

        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private Guna.UI2.WinForms.Guna2Panel cardTotalSales;
        private System.Windows.Forms.Label lblTotalSalesCaption;
        private System.Windows.Forms.Label lblTotalSales;
        private Guna.UI2.WinForms.Guna2Panel cardAvgFeedback;
        private System.Windows.Forms.Label lblAvgFeedbackCaption;
        private System.Windows.Forms.Label lblAvgFeedback;
        private Guna.UI2.WinForms.Guna2Panel cardAvgAttendance;
        private System.Windows.Forms.Label lblAvgAttendanceCaption;
        private System.Windows.Forms.Label lblAvgAttendance;

        private Guna.UI2.WinForms.Guna2DataGridView dgvPerformance;

        private System.Windows.Forms.Panel bottomPanel;
        private Guna.UI2.WinForms.Guna2Button btnPrevPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
        private Guna.UI2.WinForms.Guna2Button btnExportPdf;
    }
}
