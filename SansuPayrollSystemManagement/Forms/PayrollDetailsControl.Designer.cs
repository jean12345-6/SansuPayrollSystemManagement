using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SansuPayrollSystemManagement.Forms
{
    partial class PayrollDetailsControl
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel headerPanel;
        private Guna2CirclePictureBox picEmployee;
        private Label lblHeaderTitle;
        private Label lblCaptionName;
        private Label lblCaptionPosition;
        private Label lblCaptionPeriod;
        private Label lblEmployeeName;
        private Label lblPosition;
        private Label lblPeriod;
        private Panel panelHeaderUnderline;

        private TableLayoutPanel mainLayout;
        private Guna2Panel panelEarnings;
        private Label lblEarningsTitle;
        private Label lblDaysWorkedCaption;
        private Label lblOvertimeHoursCaption;
        private Label lblBasicSalaryCaption;
        private Label lblGrossPayCaption;
        private Label lblDaysWorkedValue;
        private Label lblOvertimeHoursValue;
        private Label lblBasicSalaryValue;
        private Label lblGrossPayValue;

        private Guna2Panel panelDeductions;
        private Label lblDeductionsTitle;
        private Label lblSSSCaption;
        private Label lblPhilHealthCaption;
        private Label lblPagIbigCaption;
        private Label lblLateDeductionCaption;
        private Label lblAbsenceDeductionCaption;
        private Label lblTotalDeductionsCaption;
        private Label lblSSSValue;
        private Label lblPhilHealthValue;
        private Label lblPagIbigValue;
        private Label lblLateDeductionValue;
        private Label lblAbsenceDeductionValue;
        private Label lblTotalDeductionsValue;

        private Guna2Panel panelNetPay;
        private Label lblNetPayTitle;
        private Label lblNetPayCaption;
        private Label lblNetPayValue;

        private Guna2Button btnPrintPayslip;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHeaderUnderline = new System.Windows.Forms.Panel();
            this.picEmployee = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblCaptionName = new System.Windows.Forms.Label();
            this.lblCaptionPosition = new System.Windows.Forms.Label();
            this.lblCaptionPeriod = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelEarnings = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGrossPayValue = new System.Windows.Forms.Label();
            this.lblBasicSalaryValue = new System.Windows.Forms.Label();
            this.lblOvertimeHoursValue = new System.Windows.Forms.Label();
            this.lblDaysWorkedValue = new System.Windows.Forms.Label();
            this.lblGrossPayCaption = new System.Windows.Forms.Label();
            this.lblBasicSalaryCaption = new System.Windows.Forms.Label();
            this.lblOvertimeHoursCaption = new System.Windows.Forms.Label();
            this.lblDaysWorkedCaption = new System.Windows.Forms.Label();
            this.lblEarningsTitle = new System.Windows.Forms.Label();
            this.panelDeductions = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalDeductionsValue = new System.Windows.Forms.Label();
            this.lblAbsenceDeductionValue = new System.Windows.Forms.Label();
            this.lblLateDeductionValue = new System.Windows.Forms.Label();
            this.lblPagIbigValue = new System.Windows.Forms.Label();
            this.lblPhilHealthValue = new System.Windows.Forms.Label();
            this.lblSSSValue = new System.Windows.Forms.Label();
            this.lblTotalDeductionsCaption = new System.Windows.Forms.Label();
            this.lblAbsenceDeductionCaption = new System.Windows.Forms.Label();
            this.lblLateDeductionCaption = new System.Windows.Forms.Label();
            this.lblPagIbigCaption = new System.Windows.Forms.Label();
            this.lblPhilHealthCaption = new System.Windows.Forms.Label();
            this.lblSSSCaption = new System.Windows.Forms.Label();
            this.lblDeductionsTitle = new System.Windows.Forms.Label();
            this.panelNetPay = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNetPayValue = new System.Windows.Forms.Label();
            this.lblNetPayCaption = new System.Windows.Forms.Label();
            this.lblNetPayTitle = new System.Windows.Forms.Label();
            this.btnPrintPayslip = new Guna.UI2.WinForms.Guna2Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.panelEarnings.SuspendLayout();
            this.panelDeductions.SuspendLayout();
            this.panelNetPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.headerPanel.Controls.Add(this.panelHeaderUnderline);
            this.headerPanel.Controls.Add(this.picEmployee);
            this.headerPanel.Controls.Add(this.lblHeaderTitle);
            this.headerPanel.Controls.Add(this.lblCaptionName);
            this.headerPanel.Controls.Add(this.lblCaptionPosition);
            this.headerPanel.Controls.Add(this.lblCaptionPeriod);
            this.headerPanel.Controls.Add(this.lblEmployeeName);
            this.headerPanel.Controls.Add(this.lblPosition);
            this.headerPanel.Controls.Add(this.lblPeriod);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1942, 140);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // panelHeaderUnderline
            // 
            this.panelHeaderUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.panelHeaderUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderUnderline.Location = new System.Drawing.Point(0, 130);
            this.panelHeaderUnderline.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeaderUnderline.Name = "panelHeaderUnderline";
            this.panelHeaderUnderline.Size = new System.Drawing.Size(1942, 10);
            this.panelHeaderUnderline.TabIndex = 8;
            // 
            // picEmployee
            // 
            this.picEmployee.ImageRotate = 0F;
            this.picEmployee.Location = new System.Drawing.Point(32, 24);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picEmployee.Size = new System.Drawing.Size(90, 90);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmployee.TabIndex = 7;
            this.picEmployee.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(140, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(349, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Payroll Details / Payslip";
            // 
            // lblCaptionName
            // 
            this.lblCaptionName.AutoSize = true;
            this.lblCaptionName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaptionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCaptionName.Location = new System.Drawing.Point(140, 58);
            this.lblCaptionName.Name = "lblCaptionName";
            this.lblCaptionName.Size = new System.Drawing.Size(93, 23);
            this.lblCaptionName.TabIndex = 1;
            this.lblCaptionName.Text = "Employee:";
            // 
            // lblCaptionPosition
            // 
            this.lblCaptionPosition.AutoSize = true;
            this.lblCaptionPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaptionPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCaptionPosition.Location = new System.Drawing.Point(140, 86);
            this.lblCaptionPosition.Name = "lblCaptionPosition";
            this.lblCaptionPosition.Size = new System.Drawing.Size(78, 23);
            this.lblCaptionPosition.TabIndex = 3;
            this.lblCaptionPosition.Text = "Position:";
            // 
            // lblCaptionPeriod
            // 
            this.lblCaptionPeriod.AutoSize = true;
            this.lblCaptionPeriod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaptionPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCaptionPeriod.Location = new System.Drawing.Point(470, 58);
            this.lblCaptionPeriod.Name = "lblCaptionPeriod";
            this.lblCaptionPeriod.Size = new System.Drawing.Size(66, 23);
            this.lblCaptionPeriod.TabIndex = 5;
            this.lblCaptionPeriod.Text = "Period:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(240, 58);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(140, 23);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "[EmployeeName]";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblPosition.Location = new System.Drawing.Point(240, 86);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(80, 23);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "[Position]";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblPeriod.Location = new System.Drawing.Point(544, 58);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 23);
            this.lblPeriod.TabIndex = 6;
            this.lblPeriod.Text = "[Period]";
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.mainLayout.Controls.Add(this.panelEarnings, 0, 0);
            this.mainLayout.Controls.Add(this.panelDeductions, 1, 0);
            this.mainLayout.Controls.Add(this.panelNetPay, 2, 0);
            this.mainLayout.Controls.Add(this.btnPrintPayslip, 2, 1);
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 140);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.Size = new System.Drawing.Size(1942, 947);
            this.mainLayout.TabIndex = 1;
            // 
            // panelEarnings
            // 
            this.panelEarnings.BackColor = System.Drawing.Color.Transparent;
            this.panelEarnings.BorderRadius = 20;
            this.panelEarnings.Controls.Add(this.lblGrossPayValue);
            this.panelEarnings.Controls.Add(this.lblBasicSalaryValue);
            this.panelEarnings.Controls.Add(this.lblOvertimeHoursValue);
            this.panelEarnings.Controls.Add(this.lblDaysWorkedValue);
            this.panelEarnings.Controls.Add(this.lblGrossPayCaption);
            this.panelEarnings.Controls.Add(this.lblBasicSalaryCaption);
            this.panelEarnings.Controls.Add(this.lblOvertimeHoursCaption);
            this.panelEarnings.Controls.Add(this.lblDaysWorkedCaption);
            this.panelEarnings.Controls.Add(this.lblEarningsTitle);
            this.panelEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEarnings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelEarnings.Location = new System.Drawing.Point(30, 30);
            this.panelEarnings.Margin = new System.Windows.Forms.Padding(30, 30, 15, 15);
            this.panelEarnings.Name = "panelEarnings";
            this.panelEarnings.ShadowDecoration.BorderRadius = 20;
            this.panelEarnings.ShadowDecoration.Depth = 15;
            this.panelEarnings.ShadowDecoration.Enabled = true;
            this.panelEarnings.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.panelEarnings.Size = new System.Drawing.Size(595, 665);
            this.panelEarnings.TabIndex = 0;
            // 
            // lblGrossPayValue
            // 
            this.lblGrossPayValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGrossPayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblGrossPayValue.Location = new System.Drawing.Point(220, 230);
            this.lblGrossPayValue.Name = "lblGrossPayValue";
            this.lblGrossPayValue.Size = new System.Drawing.Size(260, 23);
            this.lblGrossPayValue.TabIndex = 0;
            this.lblGrossPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBasicSalaryValue
            // 
            this.lblBasicSalaryValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBasicSalaryValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblBasicSalaryValue.Location = new System.Drawing.Point(220, 180);
            this.lblBasicSalaryValue.Name = "lblBasicSalaryValue";
            this.lblBasicSalaryValue.Size = new System.Drawing.Size(260, 23);
            this.lblBasicSalaryValue.TabIndex = 1;
            this.lblBasicSalaryValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOvertimeHoursValue
            // 
            this.lblOvertimeHoursValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOvertimeHoursValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblOvertimeHoursValue.Location = new System.Drawing.Point(220, 130);
            this.lblOvertimeHoursValue.Name = "lblOvertimeHoursValue";
            this.lblOvertimeHoursValue.Size = new System.Drawing.Size(260, 23);
            this.lblOvertimeHoursValue.TabIndex = 2;
            this.lblOvertimeHoursValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDaysWorkedValue
            // 
            this.lblDaysWorkedValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDaysWorkedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblDaysWorkedValue.Location = new System.Drawing.Point(220, 80);
            this.lblDaysWorkedValue.Name = "lblDaysWorkedValue";
            this.lblDaysWorkedValue.Size = new System.Drawing.Size(260, 23);
            this.lblDaysWorkedValue.TabIndex = 3;
            this.lblDaysWorkedValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrossPayCaption
            // 
            this.lblGrossPayCaption.AutoSize = true;
            this.lblGrossPayCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGrossPayCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblGrossPayCaption.Location = new System.Drawing.Point(40, 230);
            this.lblGrossPayCaption.Name = "lblGrossPayCaption";
            this.lblGrossPayCaption.Size = new System.Drawing.Size(88, 23);
            this.lblGrossPayCaption.TabIndex = 4;
            this.lblGrossPayCaption.Text = "Gross pay:";
            // 
            // lblBasicSalaryCaption
            // 
            this.lblBasicSalaryCaption.AutoSize = true;
            this.lblBasicSalaryCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBasicSalaryCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblBasicSalaryCaption.Location = new System.Drawing.Point(40, 180);
            this.lblBasicSalaryCaption.Name = "lblBasicSalaryCaption";
            this.lblBasicSalaryCaption.Size = new System.Drawing.Size(100, 23);
            this.lblBasicSalaryCaption.TabIndex = 5;
            this.lblBasicSalaryCaption.Text = "Basic salary:";
            // 
            // lblOvertimeHoursCaption
            // 
            this.lblOvertimeHoursCaption.AutoSize = true;
            this.lblOvertimeHoursCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOvertimeHoursCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblOvertimeHoursCaption.Location = new System.Drawing.Point(40, 130);
            this.lblOvertimeHoursCaption.Name = "lblOvertimeHoursCaption";
            this.lblOvertimeHoursCaption.Size = new System.Drawing.Size(132, 23);
            this.lblOvertimeHoursCaption.TabIndex = 6;
            this.lblOvertimeHoursCaption.Text = "Overtime hours:";
            // 
            // lblDaysWorkedCaption
            // 
            this.lblDaysWorkedCaption.AutoSize = true;
            this.lblDaysWorkedCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDaysWorkedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDaysWorkedCaption.Location = new System.Drawing.Point(40, 80);
            this.lblDaysWorkedCaption.Name = "lblDaysWorkedCaption";
            this.lblDaysWorkedCaption.Size = new System.Drawing.Size(110, 23);
            this.lblDaysWorkedCaption.TabIndex = 7;
            this.lblDaysWorkedCaption.Text = "Days worked:";
            // 
            // lblEarningsTitle
            // 
            this.lblEarningsTitle.AutoSize = true;
            this.lblEarningsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEarningsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblEarningsTitle.Location = new System.Drawing.Point(24, 24);
            this.lblEarningsTitle.Name = "lblEarningsTitle";
            this.lblEarningsTitle.Size = new System.Drawing.Size(89, 25);
            this.lblEarningsTitle.TabIndex = 8;
            this.lblEarningsTitle.Text = "Earnings";
            // 
            // panelDeductions
            // 
            this.panelDeductions.BackColor = System.Drawing.Color.Transparent;
            this.panelDeductions.BorderRadius = 20;
            this.panelDeductions.Controls.Add(this.lblTotalDeductionsValue);
            this.panelDeductions.Controls.Add(this.lblAbsenceDeductionValue);
            this.panelDeductions.Controls.Add(this.lblLateDeductionValue);
            this.panelDeductions.Controls.Add(this.lblPagIbigValue);
            this.panelDeductions.Controls.Add(this.lblPhilHealthValue);
            this.panelDeductions.Controls.Add(this.lblSSSValue);
            this.panelDeductions.Controls.Add(this.lblTotalDeductionsCaption);
            this.panelDeductions.Controls.Add(this.lblAbsenceDeductionCaption);
            this.panelDeductions.Controls.Add(this.lblLateDeductionCaption);
            this.panelDeductions.Controls.Add(this.lblPagIbigCaption);
            this.panelDeductions.Controls.Add(this.lblPhilHealthCaption);
            this.panelDeductions.Controls.Add(this.lblSSSCaption);
            this.panelDeductions.Controls.Add(this.lblDeductionsTitle);
            this.panelDeductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeductions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelDeductions.Location = new System.Drawing.Point(655, 30);
            this.panelDeductions.Margin = new System.Windows.Forms.Padding(15, 30, 15, 15);
            this.panelDeductions.Name = "panelDeductions";
            this.panelDeductions.ShadowDecoration.BorderRadius = 20;
            this.panelDeductions.ShadowDecoration.Depth = 15;
            this.panelDeductions.ShadowDecoration.Enabled = true;
            this.panelDeductions.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.panelDeductions.Size = new System.Drawing.Size(610, 665);
            this.panelDeductions.TabIndex = 1;
            // 
            // lblTotalDeductionsValue
            // 
            this.lblTotalDeductionsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalDeductionsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblTotalDeductionsValue.Location = new System.Drawing.Point(230, 285);
            this.lblTotalDeductionsValue.Name = "lblTotalDeductionsValue";
            this.lblTotalDeductionsValue.Size = new System.Drawing.Size(250, 23);
            this.lblTotalDeductionsValue.TabIndex = 0;
            this.lblTotalDeductionsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAbsenceDeductionValue
            // 
            this.lblAbsenceDeductionValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbsenceDeductionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblAbsenceDeductionValue.Location = new System.Drawing.Point(230, 240);
            this.lblAbsenceDeductionValue.Name = "lblAbsenceDeductionValue";
            this.lblAbsenceDeductionValue.Size = new System.Drawing.Size(250, 23);
            this.lblAbsenceDeductionValue.TabIndex = 1;
            this.lblAbsenceDeductionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLateDeductionValue
            // 
            this.lblLateDeductionValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLateDeductionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblLateDeductionValue.Location = new System.Drawing.Point(230, 200);
            this.lblLateDeductionValue.Name = "lblLateDeductionValue";
            this.lblLateDeductionValue.Size = new System.Drawing.Size(250, 23);
            this.lblLateDeductionValue.TabIndex = 2;
            this.lblLateDeductionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPagIbigValue
            // 
            this.lblPagIbigValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPagIbigValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblPagIbigValue.Location = new System.Drawing.Point(230, 160);
            this.lblPagIbigValue.Name = "lblPagIbigValue";
            this.lblPagIbigValue.Size = new System.Drawing.Size(250, 23);
            this.lblPagIbigValue.TabIndex = 3;
            this.lblPagIbigValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhilHealthValue
            // 
            this.lblPhilHealthValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhilHealthValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblPhilHealthValue.Location = new System.Drawing.Point(230, 120);
            this.lblPhilHealthValue.Name = "lblPhilHealthValue";
            this.lblPhilHealthValue.Size = new System.Drawing.Size(250, 23);
            this.lblPhilHealthValue.TabIndex = 4;
            this.lblPhilHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSSSValue
            // 
            this.lblSSSValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSSSValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblSSSValue.Location = new System.Drawing.Point(230, 80);
            this.lblSSSValue.Name = "lblSSSValue";
            this.lblSSSValue.Size = new System.Drawing.Size(250, 23);
            this.lblSSSValue.TabIndex = 5;
            this.lblSSSValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeductionsCaption
            // 
            this.lblTotalDeductionsCaption.AutoSize = true;
            this.lblTotalDeductionsCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalDeductionsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTotalDeductionsCaption.Location = new System.Drawing.Point(40, 285);
            this.lblTotalDeductionsCaption.Name = "lblTotalDeductionsCaption";
            this.lblTotalDeductionsCaption.Size = new System.Drawing.Size(139, 23);
            this.lblTotalDeductionsCaption.TabIndex = 6;
            this.lblTotalDeductionsCaption.Text = "Total deductions:";
            // 
            // lblAbsenceDeductionCaption
            // 
            this.lblAbsenceDeductionCaption.AutoSize = true;
            this.lblAbsenceDeductionCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAbsenceDeductionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblAbsenceDeductionCaption.Location = new System.Drawing.Point(40, 240);
            this.lblAbsenceDeductionCaption.Name = "lblAbsenceDeductionCaption";
            this.lblAbsenceDeductionCaption.Size = new System.Drawing.Size(160, 23);
            this.lblAbsenceDeductionCaption.TabIndex = 7;
            this.lblAbsenceDeductionCaption.Text = "Absence deduction:";
            // 
            // lblLateDeductionCaption
            // 
            this.lblLateDeductionCaption.AutoSize = true;
            this.lblLateDeductionCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLateDeductionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblLateDeductionCaption.Location = new System.Drawing.Point(40, 200);
            this.lblLateDeductionCaption.Name = "lblLateDeductionCaption";
            this.lblLateDeductionCaption.Size = new System.Drawing.Size(128, 23);
            this.lblLateDeductionCaption.TabIndex = 8;
            this.lblLateDeductionCaption.Text = "Late deduction:";
            // 
            // lblPagIbigCaption
            // 
            this.lblPagIbigCaption.AutoSize = true;
            this.lblPagIbigCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPagIbigCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPagIbigCaption.Location = new System.Drawing.Point(40, 160);
            this.lblPagIbigCaption.Name = "lblPagIbigCaption";
            this.lblPagIbigCaption.Size = new System.Drawing.Size(81, 23);
            this.lblPagIbigCaption.TabIndex = 9;
            this.lblPagIbigCaption.Text = "Pag-IBIG:";
            // 
            // lblPhilHealthCaption
            // 
            this.lblPhilHealthCaption.AutoSize = true;
            this.lblPhilHealthCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhilHealthCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPhilHealthCaption.Location = new System.Drawing.Point(40, 120);
            this.lblPhilHealthCaption.Name = "lblPhilHealthCaption";
            this.lblPhilHealthCaption.Size = new System.Drawing.Size(92, 23);
            this.lblPhilHealthCaption.TabIndex = 10;
            this.lblPhilHealthCaption.Text = "PhilHealth:";
            // 
            // lblSSSCaption
            // 
            this.lblSSSCaption.AutoSize = true;
            this.lblSSSCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSSSCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSSSCaption.Location = new System.Drawing.Point(40, 80);
            this.lblSSSCaption.Name = "lblSSSCaption";
            this.lblSSSCaption.Size = new System.Drawing.Size(41, 23);
            this.lblSSSCaption.TabIndex = 11;
            this.lblSSSCaption.Text = "SSS:";
            // 
            // lblDeductionsTitle
            // 
            this.lblDeductionsTitle.AutoSize = true;
            this.lblDeductionsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDeductionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblDeductionsTitle.Location = new System.Drawing.Point(24, 24);
            this.lblDeductionsTitle.Name = "lblDeductionsTitle";
            this.lblDeductionsTitle.Size = new System.Drawing.Size(113, 25);
            this.lblDeductionsTitle.TabIndex = 12;
            this.lblDeductionsTitle.Text = "Deductions";
            // 
            // panelNetPay
            // 
            this.panelNetPay.BackColor = System.Drawing.Color.Transparent;
            this.panelNetPay.BorderRadius = 20;
            this.panelNetPay.Controls.Add(this.lblNetPayValue);
            this.panelNetPay.Controls.Add(this.lblNetPayCaption);
            this.panelNetPay.Controls.Add(this.lblNetPayTitle);
            this.panelNetPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNetPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelNetPay.Location = new System.Drawing.Point(1295, 30);
            this.panelNetPay.Margin = new System.Windows.Forms.Padding(15, 30, 30, 15);
            this.panelNetPay.Name = "panelNetPay";
            this.panelNetPay.ShadowDecoration.BorderRadius = 20;
            this.panelNetPay.ShadowDecoration.Depth = 15;
            this.panelNetPay.ShadowDecoration.Enabled = true;
            this.panelNetPay.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.panelNetPay.Size = new System.Drawing.Size(617, 665);
            this.panelNetPay.TabIndex = 2;
            // 
            // lblNetPayValue
            // 
            this.lblNetPayValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNetPayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblNetPayValue.Location = new System.Drawing.Point(26, 100);
            this.lblNetPayValue.Name = "lblNetPayValue";
            this.lblNetPayValue.Size = new System.Drawing.Size(360, 48);
            this.lblNetPayValue.TabIndex = 0;
            this.lblNetPayValue.Text = "₱ 0.00";
            this.lblNetPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetPayCaption
            // 
            this.lblNetPayCaption.AutoSize = true;
            this.lblNetPayCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNetPayCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblNetPayCaption.Location = new System.Drawing.Point(26, 70);
            this.lblNetPayCaption.Name = "lblNetPayCaption";
            this.lblNetPayCaption.Size = new System.Drawing.Size(177, 20);
            this.lblNetPayCaption.TabIndex = 1;
            this.lblNetPayCaption.Text = "Take-home pay (PHP / ₱):";
            // 
            // lblNetPayTitle
            // 
            this.lblNetPayTitle.AutoSize = true;
            this.lblNetPayTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNetPayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblNetPayTitle.Location = new System.Drawing.Point(24, 24);
            this.lblNetPayTitle.Name = "lblNetPayTitle";
            this.lblNetPayTitle.Size = new System.Drawing.Size(81, 25);
            this.lblNetPayTitle.TabIndex = 2;
            this.lblNetPayTitle.Text = "Net Pay";
            // 
            // btnPrintPayslip
            // 
            this.btnPrintPayslip.BorderRadius = 18;
            this.btnPrintPayslip.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrintPayslip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnPrintPayslip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintPayslip.ForeColor = System.Drawing.Color.Black;
            this.btnPrintPayslip.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnPrintPayslip.Location = new System.Drawing.Point(1732, 720);
            this.btnPrintPayslip.Margin = new System.Windows.Forms.Padding(15, 10, 30, 10);
            this.btnPrintPayslip.Name = "btnPrintPayslip";
            this.btnPrintPayslip.Size = new System.Drawing.Size(180, 217);
            this.btnPrintPayslip.TabIndex = 3;
            this.btnPrintPayslip.Text = "Print Payslip";
            this.btnPrintPayslip.Click += new System.EventHandler(this.btnPrintPayslip_Click);
            // 
            // PayrollDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.headerPanel);
            this.Name = "PayrollDetailsControl";
            this.Size = new System.Drawing.Size(1942, 1087);
            this.Load += new System.EventHandler(this.PayrollDetailsControl_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.mainLayout.ResumeLayout(false);
            this.panelEarnings.ResumeLayout(false);
            this.panelEarnings.PerformLayout();
            this.panelDeductions.ResumeLayout(false);
            this.panelDeductions.PerformLayout();
            this.panelNetPay.ResumeLayout(false);
            this.panelNetPay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
