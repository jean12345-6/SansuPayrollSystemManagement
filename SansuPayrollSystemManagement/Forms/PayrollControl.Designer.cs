namespace SansuPayrollSystemManagement.Forms
{
    partial class PayrollControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPayroll = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.panelSalaryPaid = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSalaryPaid = new System.Windows.Forms.Label();
            this.panelTotalCost = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.panelPayrollList = new Guna.UI2.WinForms.Guna2Panel();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.panelBalance.SuspendLayout();
            this.panelSalaryPaid.SuspendLayout();
            this.panelTotalCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 96);
            this.label1.TabIndex = 29;
            this.label1.Text = "PAYROLL MANAGEMENT";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(571, 174);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(322, 45);
            this.dtpEnd.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "to";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(200, 173);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(314, 45);
            this.dtpStart.TabIndex = 33;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(25, 179);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(120, 38);
            this.lblPeriod.TabIndex = 32;
            this.lblPeriod.Text = "Period:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(200, 119);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(693, 46);
            this.cboEmployee.TabIndex = 31;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(25, 126);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(162, 38);
            this.lblEmployee.TabIndex = 30;
            this.lblEmployee.Text = "Employee";
            // 
            // btnGeneratePayslip
            // 
            this.btnGeneratePayslip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePayslip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePayslip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratePayslip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneratePayslip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeneratePayslip.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePayslip.Location = new System.Drawing.Point(1058, 121);
            this.btnGeneratePayslip.Name = "btnGeneratePayslip";
            this.btnGeneratePayslip.Size = new System.Drawing.Size(144, 48);
            this.btnGeneratePayslip.TabIndex = 38;
            this.btnGeneratePayslip.Text = "Generate Payslip";
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(908, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 46);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            // 
            // btnComputePayroll
            // 
            this.btnComputePayroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputePayroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputePayroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComputePayroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComputePayroll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComputePayroll.ForeColor = System.Drawing.Color.White;
            this.btnComputePayroll.Location = new System.Drawing.Point(908, 173);
            this.btnComputePayroll.Name = "btnComputePayroll";
            this.btnComputePayroll.Size = new System.Drawing.Size(144, 45);
            this.btnComputePayroll.TabIndex = 36;
            this.btnComputePayroll.Text = "Compute";
            this.dgvPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll_CellContentClick);
            this.Load += new System.EventHandler(this.PayrollControl_Load);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1058, 173);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(144, 46);
            this.guna2Button1.TabIndex = 39;
            this.guna2Button1.Text = "Back To Dashboard";
            // 
            // dgvPayroll
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll.ColumnHeadersHeight = 4;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayroll.Location = new System.Drawing.Point(32, 234);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowHeadersWidth = 51;
            this.dgvPayroll.RowTemplate.Height = 24;
            this.dgvPayroll.Size = new System.Drawing.Size(1170, 482);
            this.dgvPayroll.TabIndex = 41;
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
            this.dgvPayroll.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPayroll.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPayroll.ThemeStyle.ReadOnly = false;
            this.dgvPayroll.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayroll.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayroll.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayroll.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPayroll.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayroll.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.panelBalance);
            this.panelSummary.Controls.Add(this.panelSalaryPaid);
            this.panelSummary.Controls.Add(this.panelTotalCost);
            this.panelSummary.Location = new System.Drawing.Point(1208, 234);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(439, 482);
            this.panelSummary.TabIndex = 42;
            // 
            // panelBalance
            // 
            this.panelBalance.Controls.Add(this.lblBalance);
            this.panelBalance.Location = new System.Drawing.Point(22, 293);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(200, 100);
            this.panelBalance.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(19, 35);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(69, 16);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "BALANCE";
            // 
            // panelSalaryPaid
            // 
            this.panelSalaryPaid.Controls.Add(this.lblSalaryPaid);
            this.panelSalaryPaid.Location = new System.Drawing.Point(22, 156);
            this.panelSalaryPaid.Name = "panelSalaryPaid";
            this.panelSalaryPaid.Size = new System.Drawing.Size(200, 100);
            this.panelSalaryPaid.TabIndex = 1;
            // 
            // lblSalaryPaid
            // 
            this.lblSalaryPaid.AutoSize = true;
            this.lblSalaryPaid.Location = new System.Drawing.Point(20, 56);
            this.lblSalaryPaid.Name = "lblSalaryPaid";
            this.lblSalaryPaid.Size = new System.Drawing.Size(94, 16);
            this.lblSalaryPaid.TabIndex = 3;
            this.lblSalaryPaid.Text = "SALARY PAID";
            // 
            // panelTotalCost
            // 
            this.panelTotalCost.Controls.Add(this.lblTotalCost);
            this.panelTotalCost.Location = new System.Drawing.Point(22, 29);
            this.panelTotalCost.Name = "panelTotalCost";
            this.panelTotalCost.Size = new System.Drawing.Size(200, 100);
            this.panelTotalCost.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(20, 39);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(91, 16);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "TOTAL COST";
            // 
            // panelPayrollList
            // 
            this.panelPayrollList.Location = new System.Drawing.Point(32, 722);
            this.panelPayrollList.Name = "panelPayrollList";
            this.panelPayrollList.Size = new System.Drawing.Size(1408, 87);
            this.panelPayrollList.TabIndex = 43;
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(32, 815);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1286, 100);
            this.panelContainer.TabIndex = 44;
            // 
            // PayrollControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelPayrollList);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnGeneratePayslip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnComputePayroll);
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
            this.panelBalance.ResumeLayout(false);
            this.panelBalance.PerformLayout();
            this.panelSalaryPaid.ResumeLayout(false);
            this.panelSalaryPaid.PerformLayout();
            this.panelTotalCost.ResumeLayout(false);
            this.panelTotalCost.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayroll;
        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private Guna.UI2.WinForms.Guna2Panel panelBalance;
        private System.Windows.Forms.Label lblBalance;
        private Guna.UI2.WinForms.Guna2Panel panelSalaryPaid;
        private System.Windows.Forms.Label lblSalaryPaid;
        private Guna.UI2.WinForms.Guna2Panel panelTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private Guna.UI2.WinForms.Guna2Panel panelPayrollList;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
    }
}
