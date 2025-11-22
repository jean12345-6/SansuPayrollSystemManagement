namespace SansuPayrollSystemManagement.Forms
{
    partial class PerformanceControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dgvPerformance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PERFORMANCE";
            // 
            // cboEmployee
            // 
            this.cboEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboEmployee.Location = new System.Drawing.Point(160, 90);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(350, 37);
            this.cboEmployee.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmployee.Location = new System.Drawing.Point(30, 95);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(128, 29);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpDate.Location = new System.Drawing.Point(610, 90);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(280, 34);
            this.dtpDate.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDate.Location = new System.Drawing.Point(540, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 29);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalSales.Location = new System.Drawing.Point(30, 150);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(226, 29);
            this.lblTotalSales.TabIndex = 5;
            this.lblTotalSales.Text = "Total Sales: ₱0.00";
            // 
            // dgvPerformance
            // 
            this.dgvPerformance.AllowUserToAddRows = false;
            this.dgvPerformance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPerformance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvPerformance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerformance.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerformance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPerformance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerformance.Location = new System.Drawing.Point(31, 182);
            this.dgvPerformance.Name = "dgvPerformance";
            this.dgvPerformance.ReadOnly = true;
            this.dgvPerformance.RowHeadersVisible = false;
            this.dgvPerformance.RowHeadersWidth = 51;
            this.dgvPerformance.RowTemplate.Height = 30;
            this.dgvPerformance.Size = new System.Drawing.Size(1260, 600);
            this.dgvPerformance.TabIndex = 6;
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
            this.dgvPerformance.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPerformance.ThemeStyle.ReadOnly = true;
            this.dgvPerformance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerformance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerformance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerformance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPerformance.ThemeStyle.RowsStyle.Height = 30;
            this.dgvPerformance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerformance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPerformance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformance_CellContentClick);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1171, 792);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 35);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(30, 799);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 35);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "< Prev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(160, 799);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 35);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPageInfo.Location = new System.Drawing.Point(310, 807);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(94, 20);
            this.lblPageInfo.TabIndex = 9;
            this.lblPageInfo.Text = "Page 1 of 1";
            // 
            // PerformanceControl
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvPerformance);
            this.Name = "PerformanceControl";
            this.Size = new System.Drawing.Size(1750, 1000);
            this.Load += new System.EventHandler(this.PerformanceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotalSales;

        private Guna.UI2.WinForms.Guna2DataGridView dgvPerformance;

        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label lblPageInfo;
        private Guna.UI2.WinForms.Guna2Button btnExport;
    }
}
