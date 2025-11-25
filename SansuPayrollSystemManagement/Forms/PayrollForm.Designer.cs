namespace SansuPayrollSystemManagement
{
    partial class PayrollForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBackDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCompute = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnGeneratePayslip = new Guna.UI2.WinForms.Guna2Button();
            this.computationPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPagIbig = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhilHealth = new System.Windows.Forms.TextBox();
            this.txtSSS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.txtRegularHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DataGridViewPayroll = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.computationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnBackDashboard);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.FillColor = System.Drawing.Color.LightCyan;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(710, 58);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnBackDashboard
            // 
            this.btnBackDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackDashboard.ForeColor = System.Drawing.Color.White;
            this.btnBackDashboard.Location = new System.Drawing.Point(446, 10);
            this.btnBackDashboard.Name = "btnBackDashboard";
            this.btnBackDashboard.Size = new System.Drawing.Size(245, 35);
            this.btnBackDashboard.TabIndex = 11;
            this.btnBackDashboard.Text = "Back to Dashboard";
            //this.btnBackDashboard.Click += new System.EventHandler(this.btnBackDashboard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "SANSU PAYROLL MANAGEMENT";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(12, 97);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(99, 25);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Text = "Employee";
            // 
            // cboEmployee
            // 
            this.cboEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(117, 89);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(272, 33);
            this.cboEmployee.TabIndex = 3;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(395, 97);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 25);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "Period";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(469, 100);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(108, 22);
            this.dtpStart.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "to";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(612, 100);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(108, 22);
            this.dtpEnd.TabIndex = 7;
            // 
            // btnCompute
            // 
            this.btnCompute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(17, 140);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(135, 35);
            this.btnCompute.TabIndex = 8;
            this.btnCompute.Text = "Compute";
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(158, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGeneratePayslip
            // 
            this.btnGeneratePayslip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePayslip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePayslip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratePayslip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneratePayslip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeneratePayslip.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePayslip.Location = new System.Drawing.Point(299, 140);
            this.btnGeneratePayslip.Name = "btnGeneratePayslip";
            this.btnGeneratePayslip.Size = new System.Drawing.Size(179, 35);
            this.btnGeneratePayslip.TabIndex = 10;
            this.btnGeneratePayslip.Text = "Generate Payslip";
            this.btnGeneratePayslip.Click += new System.EventHandler(this.btnGeneratePayslip_Click);
            // 
            // computationPanel
            // 
            this.computationPanel.Controls.Add(this.txtPagIbig);
            this.computationPanel.Controls.Add(this.label11);
            this.computationPanel.Controls.Add(this.txtPhilHealth);
            this.computationPanel.Controls.Add(this.txtSSS);
            this.computationPanel.Controls.Add(this.label9);
            this.computationPanel.Controls.Add(this.label10);
            this.computationPanel.Controls.Add(this.label8);
            this.computationPanel.Controls.Add(this.txtNetPay);
            this.computationPanel.Controls.Add(this.txtDeductions);
            this.computationPanel.Controls.Add(this.txtTotalPay);
            this.computationPanel.Controls.Add(this.label7);
            this.computationPanel.Controls.Add(this.label6);
            this.computationPanel.Controls.Add(this.label5);
            this.computationPanel.Controls.Add(this.txtOvertimeHours);
            this.computationPanel.Controls.Add(this.txtRegularHours);
            this.computationPanel.Controls.Add(this.label3);
            this.computationPanel.Controls.Add(this.label2);
            this.computationPanel.Location = new System.Drawing.Point(17, 199);
            this.computationPanel.Name = "computationPanel";
            this.computationPanel.Size = new System.Drawing.Size(703, 380);
            this.computationPanel.TabIndex = 11;
            // 
            // txtPagIbig
            // 
            this.txtPagIbig.Location = new System.Drawing.Point(185, 202);
            this.txtPagIbig.Name = "txtPagIbig";
            this.txtPagIbig.Size = new System.Drawing.Size(210, 22);
            this.txtPagIbig.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Pag-IBIG:";
            // 
            // txtPhilHealth
            // 
            this.txtPhilHealth.Location = new System.Drawing.Point(185, 174);
            this.txtPhilHealth.Name = "txtPhilHealth";
            this.txtPhilHealth.Size = new System.Drawing.Size(210, 22);
            this.txtPhilHealth.TabIndex = 27;
            // 
            // txtSSS
            // 
            this.txtSSS.Location = new System.Drawing.Point(183, 145);
            this.txtSSS.Name = "txtSSS";
            this.txtSSS.Size = new System.Drawing.Size(210, 22);
            this.txtSSS.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "PhilHealth:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "SSS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(456, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "COMPUTATION DETAILS (READ ONLY)";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(185, 314);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(210, 22);
            this.txtNetPay.TabIndex = 23;
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(183, 277);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(210, 22);
            this.txtDeductions.TabIndex = 22;
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(183, 249);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(210, 22);
            this.txtTotalPay.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Net Pay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Deductions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Pay:";
            // 
            // txtOvertimeHours
            // 
            this.txtOvertimeHours.Location = new System.Drawing.Point(185, 105);
            this.txtOvertimeHours.Name = "txtOvertimeHours";
            this.txtOvertimeHours.Size = new System.Drawing.Size(210, 22);
            this.txtOvertimeHours.TabIndex = 17;
            // 
            // txtRegularHours
            // 
            this.txtRegularHours.Location = new System.Drawing.Point(183, 76);
            this.txtRegularHours.Name = "txtRegularHours";
            this.txtRegularHours.Size = new System.Drawing.Size(210, 22);
            this.txtRegularHours.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Overtime Hours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Days Worked:";
            // 
            // guna2DataGridViewPayroll
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewPayroll.ColumnHeadersHeight = 4;
            this.guna2DataGridViewPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewPayroll.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewPayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewPayroll.Location = new System.Drawing.Point(10, 585);
            this.guna2DataGridViewPayroll.Name = "guna2DataGridViewPayroll";
            this.guna2DataGridViewPayroll.RowHeadersVisible = false;
            this.guna2DataGridViewPayroll.RowHeadersWidth = 51;
            this.guna2DataGridViewPayroll.RowTemplate.Height = 24;
            this.guna2DataGridViewPayroll.Size = new System.Drawing.Size(701, 96);
            this.guna2DataGridViewPayroll.TabIndex = 12;
            this.guna2DataGridViewPayroll.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewPayroll.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewPayroll.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewPayroll.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewPayroll.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewPayroll.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewPayroll.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewPayroll.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewPayroll.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewPayroll.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewPayroll.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewPayroll.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewPayroll.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridViewPayroll.ThemeStyle.ReadOnly = false;
            this.guna2DataGridViewPayroll.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewPayroll.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewPayroll.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewPayroll.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewPayroll.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridViewPayroll.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewPayroll.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 710);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 753);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.guna2DataGridViewPayroll);
            this.Controls.Add(this.computationPanel);
            this.Controls.Add(this.btnGeneratePayslip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "PayrollForm";
            this.Text = "PayrollForm";
            this.Load += new System.EventHandler(this.PayrollForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.computationPanel.ResumeLayout(false);
            this.computationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewPayroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2Button btnBackDashboard;
        private Guna.UI2.WinForms.Guna2Button btnCompute;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnGeneratePayslip;
        private Guna.UI2.WinForms.Guna2Panel computationPanel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewPayroll;
        private System.Windows.Forms.TextBox txtOvertimeHours;
        private System.Windows.Forms.TextBox txtRegularHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhilHealth;
        private System.Windows.Forms.TextBox txtSSS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPagIbig;
        private System.Windows.Forms.Label label11;
    }
}