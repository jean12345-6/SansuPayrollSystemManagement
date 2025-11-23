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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new Guna2Panel();
            this.picEmployee = new Guna2CirclePictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblCaptionName = new System.Windows.Forms.Label();
            this.lblCaptionPosition = new System.Windows.Forms.Label();
            this.lblCaptionPeriod = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelEarnings = new Guna2Panel();
            this.lblGrossPayValue = new System.Windows.Forms.Label();
            this.lblBasicSalaryValue = new System.Windows.Forms.Label();
            this.lblOvertimeHoursValue = new System.Windows.Forms.Label();
            this.lblDaysWorkedValue = new System.Windows.Forms.Label();
            this.lblGrossPayCaption = new System.Windows.Forms.Label();
            this.lblBasicSalaryCaption = new System.Windows.Forms.Label();
            this.lblOvertimeHoursCaption = new System.Windows.Forms.Label();
            this.lblDaysWorkedCaption = new System.Windows.Forms.Label();
            this.lblEarningsTitle = new System.Windows.Forms.Label();
            this.panelDeductions = new Guna2Panel();
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
            this.panelNetPay = new Guna2Panel();
            this.lblNetPayValue = new System.Windows.Forms.Label();
            this.lblNetPayCaption = new System.Windows.Forms.Label();
            this.lblNetPayTitle = new System.Windows.Forms.Label();
            this.btnPrintPayslip = new Guna2Button();
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
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1942, 140);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.Controls.Add(this.picEmployee);
            this.headerPanel.Controls.Add(this.lblHeaderTitle);
            this.headerPanel.Controls.Add(this.lblCaptionName);
            this.headerPanel.Controls.Add(this.lblCaptionPosition);
            this.headerPanel.Controls.Add(this.lblCaptionPeriod);
            this.headerPanel.Controls.Add(this.lblEmployeeName);
            this.headerPanel.Controls.Add(this.lblPosition);
            this.headerPanel.Controls.Add(this.lblPeriod);
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
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 140);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new System.Drawing.Size(1942, 947);
            this.mainLayout.TabIndex = 1;
            // add children after init
            // 
            // panelEarnings
            // 
            this.panelEarnings.BorderRadius = 20;
            this.panelEarnings.ShadowDecoration.Enabled = true;
            this.panelEarnings.ShadowDecoration.Depth = 15;
            this.panelEarnings.ShadowDecoration.BorderRadius = 20;
            this.panelEarnings.Margin = new System.Windows.Forms.Padding(30, 30, 15, 15);
            this.panelEarnings.Name = "panelEarnings";
            this.panelEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEarnings.Controls.Add(this.lblGrossPayValue);
            this.panelEarnings.Controls.Add(this.lblBasicSalaryValue);
            this.panelEarnings.Controls.Add(this.lblOvertimeHoursValue);
            this.panelEarnings.Controls.Add(this.lblDaysWorkedValue);
            this.panelEarnings.Controls.Add(this.lblGrossPayCaption);
            this.panelEarnings.Controls.Add(this.lblBasicSalaryCaption);
            this.panelEarnings.Controls.Add(this.lblOvertimeHoursCaption);
            this.panelEarnings.Controls.Add(this.lblDaysWorkedCaption);
            this.panelEarnings.Controls.Add(this.lblEarningsTitle);
            // 
            // Earnings colors / fonts
            // 
            this.panelEarnings.FillColor = System.Drawing.Color.FromArgb(0, 153, 255);
            this.lblEarningsTitle.AutoSize = true;
            this.lblEarningsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEarningsTitle.ForeColor = System.Drawing.Color.White;
            this.lblEarningsTitle.Location = new System.Drawing.Point(24, 24);
            this.lblEarningsTitle.Name = "lblEarningsTitle";
            this.lblEarningsTitle.Size = new System.Drawing.Size(89, 25);
            this.lblEarningsTitle.Text = "Earnings";
            // 
            // Earnings captions
            // 
            this.lblDaysWorkedCaption.AutoSize = true;
            this.lblDaysWorkedCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDaysWorkedCaption.ForeColor = System.Drawing.Color.White;
            this.lblDaysWorkedCaption.Location = new System.Drawing.Point(40, 80);
            this.lblDaysWorkedCaption.Name = "lblDaysWorkedCaption";
            this.lblDaysWorkedCaption.Size = new System.Drawing.Size(113, 23);
            this.lblDaysWorkedCaption.Text = "Days worked:";
            this.lblOvertimeHoursCaption.AutoSize = true;
            this.lblOvertimeHoursCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOvertimeHoursCaption.ForeColor = System.Drawing.Color.White;
            this.lblOvertimeHoursCaption.Location = new System.Drawing.Point(40, 130);
            this.lblOvertimeHoursCaption.Name = "lblOvertimeHoursCaption";
            this.lblOvertimeHoursCaption.Size = new System.Drawing.Size(132, 23);
            this.lblOvertimeHoursCaption.Text = "Overtime hours:";
            this.lblBasicSalaryCaption.AutoSize = true;
            this.lblBasicSalaryCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBasicSalaryCaption.ForeColor = System.Drawing.Color.White;
            this.lblBasicSalaryCaption.Location = new System.Drawing.Point(40, 180);
            this.lblBasicSalaryCaption.Name = "lblBasicSalaryCaption";
            this.lblBasicSalaryCaption.Size = new System.Drawing.Size(100, 23);
            this.lblBasicSalaryCaption.Text = "Basic salary:";
            this.lblGrossPayCaption.AutoSize = true;
            this.lblGrossPayCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGrossPayCaption.ForeColor = System.Drawing.Color.White;
            this.lblGrossPayCaption.Location = new System.Drawing.Point(40, 230);
            this.lblGrossPayCaption.Name = "lblGrossPayCaption";
            this.lblGrossPayCaption.Size = new System.Drawing.Size(88, 23);
            this.lblGrossPayCaption.Text = "Gross pay:";
            // 
            // Earnings values
            // 
            System.Drawing.Size valueSize = new System.Drawing.Size(260, 23);
            this.lblDaysWorkedValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDaysWorkedValue.ForeColor = System.Drawing.Color.White;
            this.lblDaysWorkedValue.Location = new System.Drawing.Point(220, 80);
            this.lblDaysWorkedValue.Name = "lblDaysWorkedValue";
            this.lblDaysWorkedValue.Size = valueSize;
            this.lblDaysWorkedValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblOvertimeHoursValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOvertimeHoursValue.ForeColor = System.Drawing.Color.White;
            this.lblOvertimeHoursValue.Location = new System.Drawing.Point(220, 130);
            this.lblOvertimeHoursValue.Name = "lblOvertimeHoursValue";
            this.lblOvertimeHoursValue.Size = valueSize;
            this.lblOvertimeHoursValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblBasicSalaryValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBasicSalaryValue.ForeColor = System.Drawing.Color.White;
            this.lblBasicSalaryValue.Location = new System.Drawing.Point(220, 180);
            this.lblBasicSalaryValue.Name = "lblBasicSalaryValue";
            this.lblBasicSalaryValue.Size = valueSize;
            this.lblBasicSalaryValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblGrossPayValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGrossPayValue.ForeColor = System.Drawing.Color.White;
            this.lblGrossPayValue.Location = new System.Drawing.Point(220, 230);
            this.lblGrossPayValue.Name = "lblGrossPayValue";
            this.lblGrossPayValue.Size = valueSize;
            this.lblGrossPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelDeductions
            // 
            this.panelDeductions.BorderRadius = 20;
            this.panelDeductions.ShadowDecoration.Enabled = true;
            this.panelDeductions.ShadowDecoration.Depth = 15;
            this.panelDeductions.ShadowDecoration.BorderRadius = 20;
            this.panelDeductions.Margin = new System.Windows.Forms.Padding(15, 30, 15, 15);
            this.panelDeductions.Name = "panelDeductions";
            this.panelDeductions.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.panelDeductions.FillColor = System.Drawing.Color.FromArgb(228, 87, 46);
            // 
            // Deductions title
            // 
            this.lblDeductionsTitle.AutoSize = true;
            this.lblDeductionsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDeductionsTitle.ForeColor = System.Drawing.Color.White;
            this.lblDeductionsTitle.Location = new System.Drawing.Point(24, 24);
            this.lblDeductionsTitle.Name = "lblDeductionsTitle";
            this.lblDeductionsTitle.Size = new System.Drawing.Size(113, 25);
            this.lblDeductionsTitle.Text = "Deductions";
            // 
            // Deductions captions
            // 
            this.lblSSSCaption.AutoSize = true;
            this.lblSSSCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSSSCaption.ForeColor = System.Drawing.Color.White;
            this.lblSSSCaption.Location = new System.Drawing.Point(40, 80);
            this.lblSSSCaption.Name = "lblSSSCaption";
            this.lblSSSCaption.Size = new System.Drawing.Size(41, 23);
            this.lblSSSCaption.Text = "SSS:";

            this.lblPhilHealthCaption.AutoSize = true;
            this.lblPhilHealthCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhilHealthCaption.ForeColor = System.Drawing.Color.White;
            this.lblPhilHealthCaption.Location = new System.Drawing.Point(40, 120);
            this.lblPhilHealthCaption.Name = "lblPhilHealthCaption";
            this.lblPhilHealthCaption.Size = new System.Drawing.Size(92, 23);
            this.lblPhilHealthCaption.Text = "PhilHealth:";

            this.lblPagIbigCaption.AutoSize = true;
            this.lblPagIbigCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPagIbigCaption.ForeColor = System.Drawing.Color.White;
            this.lblPagIbigCaption.Location = new System.Drawing.Point(40, 160);
            this.lblPagIbigCaption.Name = "lblPagIbigCaption";
            this.lblPagIbigCaption.Size = new System.Drawing.Size(81, 23);
            this.lblPagIbigCaption.Text = "Pag-IBIG:";

            this.lblLateDeductionCaption.AutoSize = true;
            this.lblLateDeductionCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLateDeductionCaption.ForeColor = System.Drawing.Color.White;
            this.lblLateDeductionCaption.Location = new System.Drawing.Point(40, 200);
            this.lblLateDeductionCaption.Name = "lblLateDeductionCaption";
            this.lblLateDeductionCaption.Size = new System.Drawing.Size(128, 23);
            this.lblLateDeductionCaption.Text = "Late deduction:";

            this.lblAbsenceDeductionCaption.AutoSize = true;
            this.lblAbsenceDeductionCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAbsenceDeductionCaption.ForeColor = System.Drawing.Color.White;
            this.lblAbsenceDeductionCaption.Location = new System.Drawing.Point(40, 240);
            this.lblAbsenceDeductionCaption.Name = "lblAbsenceDeductionCaption";
            this.lblAbsenceDeductionCaption.Size = new System.Drawing.Size(160, 23);
            this.lblAbsenceDeductionCaption.Text = "Absence deduction:";

            this.lblTotalDeductionsCaption.AutoSize = true;
            this.lblTotalDeductionsCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalDeductionsCaption.ForeColor = System.Drawing.Color.White;
            this.lblTotalDeductionsCaption.Location = new System.Drawing.Point(40, 285);
            this.lblTotalDeductionsCaption.Name = "lblTotalDeductionsCaption";
            this.lblTotalDeductionsCaption.Size = new System.Drawing.Size(139, 23);
            this.lblTotalDeductionsCaption.Text = "Total deductions:";
            // 
            // Deductions values
            // 
            System.Drawing.Size dedSize = new System.Drawing.Size(250, 23);
            this.lblSSSValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSSSValue.ForeColor = System.Drawing.Color.White;
            this.lblSSSValue.Location = new System.Drawing.Point(230, 80);
            this.lblSSSValue.Name = "lblSSSValue";
            this.lblSSSValue.Size = dedSize;
            this.lblSSSValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblPhilHealthValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhilHealthValue.ForeColor = System.Drawing.Color.White;
            this.lblPhilHealthValue.Location = new System.Drawing.Point(230, 120);
            this.lblPhilHealthValue.Name = "lblPhilHealthValue";
            this.lblPhilHealthValue.Size = dedSize;
            this.lblPhilHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblPagIbigValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPagIbigValue.ForeColor = System.Drawing.Color.White;
            this.lblPagIbigValue.Location = new System.Drawing.Point(230, 160);
            this.lblPagIbigValue.Name = "lblPagIbigValue";
            this.lblPagIbigValue.Size = dedSize;
            this.lblPagIbigValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblLateDeductionValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLateDeductionValue.ForeColor = System.Drawing.Color.White;
            this.lblLateDeductionValue.Location = new System.Drawing.Point(230, 200);
            this.lblLateDeductionValue.Name = "lblLateDeductionValue";
            this.lblLateDeductionValue.Size = dedSize;
            this.lblLateDeductionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblAbsenceDeductionValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbsenceDeductionValue.ForeColor = System.Drawing.Color.White;
            this.lblAbsenceDeductionValue.Location = new System.Drawing.Point(230, 240);
            this.lblAbsenceDeductionValue.Name = "lblAbsenceDeductionValue";
            this.lblAbsenceDeductionValue.Size = dedSize;
            this.lblAbsenceDeductionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblTotalDeductionsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalDeductionsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalDeductionsValue.Location = new System.Drawing.Point(230, 285);
            this.lblTotalDeductionsValue.Name = "lblTotalDeductionsValue";
            this.lblTotalDeductionsValue.Size = dedSize;
            this.lblTotalDeductionsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelNetPay
            // 
            this.panelNetPay.BorderRadius = 20;
            this.panelNetPay.ShadowDecoration.Enabled = true;
            this.panelNetPay.ShadowDecoration.Depth = 15;
            this.panelNetPay.ShadowDecoration.BorderRadius = 20;
            this.panelNetPay.Margin = new System.Windows.Forms.Padding(15, 30, 30, 15);
            this.panelNetPay.Name = "panelNetPay";
            this.panelNetPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNetPay.FillColor = System.Drawing.Color.FromArgb(46, 58, 72);
            this.panelNetPay.Controls.Add(this.lblNetPayValue);
            this.panelNetPay.Controls.Add(this.lblNetPayCaption);
            this.panelNetPay.Controls.Add(this.lblNetPayTitle);
            // 
            // lblNetPayTitle
            // 
            this.lblNetPayTitle.AutoSize = true;
            this.lblNetPayTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNetPayTitle.ForeColor = System.Drawing.Color.White;
            this.lblNetPayTitle.Location = new System.Drawing.Point(24, 24);
            this.lblNetPayTitle.Name = "lblNetPayTitle";
            this.lblNetPayTitle.Size = new System.Drawing.Size(81, 25);
            this.lblNetPayTitle.Text = "Net Pay";
            // 
            // lblNetPayCaption
            // 
            this.lblNetPayCaption.AutoSize = true;
            this.lblNetPayCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNetPayCaption.ForeColor = System.Drawing.Color.White;
            this.lblNetPayCaption.Location = new System.Drawing.Point(26, 70);
            this.lblNetPayCaption.Name = "lblNetPayCaption";
            this.lblNetPayCaption.Size = new System.Drawing.Size(177, 20);
            this.lblNetPayCaption.Text = "Take-home pay (PHP / ₱):";
            // 
            // lblNetPayValue
            // 
            this.lblNetPayValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNetPayValue.ForeColor = System.Drawing.Color.White;
            this.lblNetPayValue.Location = new System.Drawing.Point(26, 100);
            this.lblNetPayValue.Name = "lblNetPayValue";
            this.lblNetPayValue.Size = new System.Drawing.Size(360, 48);
            this.lblNetPayValue.Text = "₱ 0.00";
            this.lblNetPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrintPayslip
            // 
            this.btnPrintPayslip.Name = "btnPrintPayslip";
            this.btnPrintPayslip.Text = "Print Payslip";
            this.btnPrintPayslip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintPayslip.ForeColor = System.Drawing.Color.White;
            this.btnPrintPayslip.FillColor = System.Drawing.Color.FromArgb(0, 153, 255);
            this.btnPrintPayslip.BorderRadius = 18;
            this.btnPrintPayslip.Margin = new System.Windows.Forms.Padding(15, 10, 30, 10);
            this.btnPrintPayslip.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrintPayslip.Click += new System.EventHandler(this.btnPrintPayslip_Click);
            // 
            // add controls to mainLayout
            // 
            this.mainLayout.Controls.Add(this.panelEarnings, 0, 0);
            this.mainLayout.Controls.Add(this.panelDeductions, 1, 0);
            this.mainLayout.Controls.Add(this.panelNetPay, 2, 0);
            this.mainLayout.Controls.Add(this.btnPrintPayslip, 2, 1);
            // 
            // PayrollDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
