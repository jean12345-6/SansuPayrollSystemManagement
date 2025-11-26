using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.cardTotalSales = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.cardAvgFeedback = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAvgFeedbackTitle = new System.Windows.Forms.Label();
            this.lblAvgFeedbackValue = new System.Windows.Forms.Label();
            this.cardAttendance = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAttendanceTitle = new System.Windows.Forms.Label();
            this.lblAttendanceValue = new System.Windows.Forms.Label();
            this.dgvPerformance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.panelSummary.SuspendLayout();
            this.cardTotalSales.SuspendLayout();
            this.cardAvgFeedback.SuspendLayout();
            this.cardAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(655, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PERFORMANCE LOGS";
            // 
            // cboEmployee
            // 
            this.cboEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cboEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboEmployee.ForeColor = System.Drawing.Color.Black;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(162, 108);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(420, 37);
            this.cboEmployee.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblEmployee.Location = new System.Drawing.Point(28, 112);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(128, 29);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpDate.Location = new System.Drawing.Point(695, 108);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(320, 34);
            this.dtpDate.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblDate.Location = new System.Drawing.Point(620, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 29);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.cardTotalSales);
            this.panelSummary.Controls.Add(this.cardAvgFeedback);
            this.panelSummary.Controls.Add(this.cardAttendance);
            this.panelSummary.Location = new System.Drawing.Point(31, 160);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1688, 130);
            this.panelSummary.TabIndex = 5;
            // 
            // cardTotalSales
            // 
            this.cardTotalSales.BackColor = System.Drawing.Color.Transparent;
            this.cardTotalSales.BorderRadius = 12;
            this.cardTotalSales.Controls.Add(this.lblTotalSales);
            this.cardTotalSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardTotalSales.Location = new System.Drawing.Point(0, 0);
            this.cardTotalSales.Name = "cardTotalSales";
            this.cardTotalSales.Size = new System.Drawing.Size(540, 130);
            this.cardTotalSales.TabIndex = 0;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblTotalSales.Location = new System.Drawing.Point(26, 48);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(254, 31);
            this.lblTotalSales.TabIndex = 0;
            this.lblTotalSales.Text = "Total Sales: ₱0.00";
            // 
            // cardAvgFeedback
            // 
            this.cardAvgFeedback.BackColor = System.Drawing.Color.Transparent;
            this.cardAvgFeedback.BorderRadius = 12;
            this.cardAvgFeedback.Controls.Add(this.lblAvgFeedbackTitle);
            this.cardAvgFeedback.Controls.Add(this.lblAvgFeedbackValue);
            this.cardAvgFeedback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardAvgFeedback.Location = new System.Drawing.Point(574, 0);
            this.cardAvgFeedback.Name = "cardAvgFeedback";
            this.cardAvgFeedback.Size = new System.Drawing.Size(540, 130);
            this.cardAvgFeedback.TabIndex = 1;
            // 
            // lblAvgFeedbackTitle
            // 
            this.lblAvgFeedbackTitle.AutoSize = true;
            this.lblAvgFeedbackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAvgFeedbackTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblAvgFeedbackTitle.Location = new System.Drawing.Point(26, 26);
            this.lblAvgFeedbackTitle.Name = "lblAvgFeedbackTitle";
            this.lblAvgFeedbackTitle.Size = new System.Drawing.Size(241, 25);
            this.lblAvgFeedbackTitle.TabIndex = 0;
            this.lblAvgFeedbackTitle.Text = "Average Feedback Score:";
            // 
            // lblAvgFeedbackValue
            // 
            this.lblAvgFeedbackValue.AutoSize = true;
            this.lblAvgFeedbackValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblAvgFeedbackValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblAvgFeedbackValue.Location = new System.Drawing.Point(26, 64);
            this.lblAvgFeedbackValue.Name = "lblAvgFeedbackValue";
            this.lblAvgFeedbackValue.Size = new System.Drawing.Size(60, 36);
            this.lblAvgFeedbackValue.TabIndex = 1;
            this.lblAvgFeedbackValue.Text = "0.0";
            // 
            // cardAttendance
            // 
            this.cardAttendance.BackColor = System.Drawing.Color.Transparent;
            this.cardAttendance.BorderRadius = 12;
            this.cardAttendance.Controls.Add(this.lblAttendanceTitle);
            this.cardAttendance.Controls.Add(this.lblAttendanceValue);
            this.cardAttendance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardAttendance.Location = new System.Drawing.Point(1148, 0);
            this.cardAttendance.Name = "cardAttendance";
            this.cardAttendance.Size = new System.Drawing.Size(540, 130);
            this.cardAttendance.TabIndex = 2;
            // 
            // lblAttendanceTitle
            // 
            this.lblAttendanceTitle.AutoSize = true;
            this.lblAttendanceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblAttendanceTitle.Location = new System.Drawing.Point(26, 26);
            this.lblAttendanceTitle.Name = "lblAttendanceTitle";
            this.lblAttendanceTitle.Size = new System.Drawing.Size(212, 25);
            this.lblAttendanceTitle.TabIndex = 0;
            this.lblAttendanceTitle.Text = "Attendance Score (%):";
            // 
            // lblAttendanceValue
            // 
            this.lblAttendanceValue.AutoSize = true;
            this.lblAttendanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblAttendanceValue.Location = new System.Drawing.Point(26, 64);
            this.lblAttendanceValue.Name = "lblAttendanceValue";
            this.lblAttendanceValue.Size = new System.Drawing.Size(60, 36);
            this.lblAttendanceValue.TabIndex = 1;
            this.lblAttendanceValue.Text = "0.0";
            // 
            // dgvPerformance
            // 
            this.dgvPerformance.AllowUserToAddRows = false;
            this.dgvPerformance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvPerformance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerformance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPerformance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerformance.ColumnHeadersHeight = 40;
            this.dgvPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerformance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPerformance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvPerformance.Location = new System.Drawing.Point(31, 310);
            this.dgvPerformance.Name = "dgvPerformance";
            this.dgvPerformance.ReadOnly = true;
            this.dgvPerformance.RowHeadersVisible = false;
            this.dgvPerformance.RowHeadersWidth = 51;
            this.dgvPerformance.RowTemplate.Height = 30;
            this.dgvPerformance.Size = new System.Drawing.Size(1688, 600);
            this.dgvPerformance.TabIndex = 6;
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPerformance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPerformance.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPerformance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvPerformance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvPerformance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPerformance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.dgvPerformance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvPerformance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPerformance.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPerformance.ThemeStyle.ReadOnly = true;
            this.dgvPerformance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPerformance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerformance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.dgvPerformance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvPerformance.ThemeStyle.RowsStyle.Height = 30;
            this.dgvPerformance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.dgvPerformance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPerformance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformance_CellContentClick);
            // 
            // btnPrev
            // 
            this.btnPrev.BorderRadius = 8;
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnPrev.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnPrev.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Location = new System.Drawing.Point(31, 930);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 35);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "< Prev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 8;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(166, 930);
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
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPageInfo.Location = new System.Drawing.Point(310, 937);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(94, 20);
            this.lblPageInfo.TabIndex = 9;
            this.lblPageInfo.Text = "Page 1 of 1";
            // 
            // btnExport
            // 
            this.btnExport.BorderRadius = 8;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnExport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnExport.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(1599, 930);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 35);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 8;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(302, 930);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PerformanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.dgvPerformance);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBack);
            this.Name = "PerformanceControl";
            this.Size = new System.Drawing.Size(1750, 1000);
            this.Load += new System.EventHandler(this.PerformanceControl_Load);
            this.panelSummary.ResumeLayout(false);
            this.cardTotalSales.ResumeLayout(false);
            this.cardTotalSales.PerformLayout();
            this.cardAvgFeedback.ResumeLayout(false);
            this.cardAvgFeedback.PerformLayout();
            this.cardAttendance.ResumeLayout(false);
            this.cardAttendance.PerformLayout();
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

        private Guna2Panel panelSummary;
        private Guna2Panel cardTotalSales;
        private Guna2Panel cardAvgFeedback;
        private Guna2Panel cardAttendance;

        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblAvgFeedbackTitle;
        private System.Windows.Forms.Label lblAvgFeedbackValue;
        private System.Windows.Forms.Label lblAttendanceTitle;
        private System.Windows.Forms.Label lblAttendanceValue;

        private Guna2DataGridView dgvPerformance;

        private Guna2Button btnPrev;
        private Guna2Button btnNext;
        private System.Windows.Forms.Label lblPageInfo;
        private Guna2Button btnExport;
        private Guna2Button btnBack;
    }
}
