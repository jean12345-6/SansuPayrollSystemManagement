using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SansuPayrollSystemManagement
{
    partial class TimecardControl
    {
        private System.ComponentModel.IContainer components = null;

     protected override void Dispose(bool disposing)
  {
        if (disposing && components != null)
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
        this.lblSubTitle = new System.Windows.Forms.Label();
            this.picEmployeePhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
    this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnPrevPeriod = new Guna.UI2.WinForms.Guna2Button();
        this.btnNextPeriod = new Guna.UI2.WinForms.Guna2Button();
     this.lblDateRange = new System.Windows.Forms.Label();
    this.btnExportPdf = new Guna.UI2.WinForms.Guna2Button();
      this.btnClose = new Guna.UI2.WinForms.Guna2Button();
        this.dgvTimecard = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTotalRegularCaption = new System.Windows.Forms.Label();
         this.lblTotalRegularHours = new System.Windows.Forms.Label();
  this.lblTotalOTCaption = new System.Windows.Forms.Label();
  this.lblTotalOvertimeHours = new System.Windows.Forms.Label();
       this.lblTotalHoursCaption = new System.Windows.Forms.Label();
    this.lblTotalHoursReported = new System.Windows.Forms.Label();
      this.lblTotalPayCaption = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
      this.lblEmployeeSigLine = new System.Windows.Forms.Label();
        this.lblSupervisorSigLine = new System.Windows.Forms.Label();
 ((System.ComponentModel.ISupportInitialize)(this.picEmployeePhoto)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.dgvTimecard)).BeginInit();
      this.SuspendLayout();
    
            // lblTitle - Gold accent
  this.lblTitle.AutoSize = true;
   this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
   this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
          this.lblTitle.Location = new System.Drawing.Point(40, 25);
       this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(631, 51);
        this.lblTitle.TabIndex = 0;
     this.lblTitle.Text = "?? Weekly Employee Timesheet";
        
        // lblSubTitle - Light gray
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
     this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSubTitle.Location = new System.Drawing.Point(44, 76);
            this.lblSubTitle.Name = "lblSubTitle";
        this.lblSubTitle.Size = new System.Drawing.Size(438, 23);
         this.lblSubTitle.TabIndex = 1;
        this.lblSubTitle.Text = "View detailed daily attendance and hours per employee.";
            
      // picEmployeePhoto
  this.picEmployeePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
  this.picEmployeePhoto.ImageRotate = 0F;
            this.picEmployeePhoto.Location = new System.Drawing.Point(40, 120);
            this.picEmployeePhoto.Name = "picEmployeePhoto";
      this.picEmployeePhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picEmployeePhoto.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.picEmployeePhoto.Size = new System.Drawing.Size(70, 70);
  this.picEmployeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
 this.picEmployeePhoto.TabIndex = 3;
this.picEmployeePhoto.TabStop = false;
            
            // lblEmployeeName - Gold accent
            this.lblEmployeeName.AutoSize = true;
this.lblEmployeeName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(130, 139);
            this.lblEmployeeName.Name = "lblEmployeeName";
         this.lblEmployeeName.Size = new System.Drawing.Size(318, 32);
        this.lblEmployeeName.TabIndex = 4;
      this.lblEmployeeName.Text = "Employee Name – Role";
     
  // btnPrevPeriod - Gold theme
   this.btnPrevPeriod.BorderRadius = 18;
     this.btnPrevPeriod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnPrevPeriod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
       this.btnPrevPeriod.ForeColor = System.Drawing.Color.Black;
      this.btnPrevPeriod.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnPrevPeriod.Location = new System.Drawing.Point(520, 132);
            this.btnPrevPeriod.Name = "btnPrevPeriod";
            this.btnPrevPeriod.Size = new System.Drawing.Size(45, 45);
        this.btnPrevPeriod.TabIndex = 5;
            this.btnPrevPeriod.Text = "<";
            
        // btnNextPeriod - Gold theme
        this.btnNextPeriod.BorderRadius = 18;
       this.btnNextPeriod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
    this.btnNextPeriod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnNextPeriod.ForeColor = System.Drawing.Color.Black;
            this.btnNextPeriod.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnNextPeriod.Location = new System.Drawing.Point(880, 132);
    this.btnNextPeriod.Name = "btnNextPeriod";
            this.btnNextPeriod.Size = new System.Drawing.Size(45, 45);
    this.btnNextPeriod.TabIndex = 6;
            this.btnNextPeriod.Text = ">";
          
  // lblDateRange - Light gray
          this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Century Gothic", 13F);
  this.lblDateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDateRange.Location = new System.Drawing.Point(575, 142);
    this.lblDateRange.Name = "lblDateRange";
 this.lblDateRange.Size = new System.Drawing.Size(301, 25);
            this.lblDateRange.TabIndex = 7;
   this.lblDateRange.Text = "Nov 01, 2025 – Nov 12, 2025";
   
            // btnExportPdf - Gold theme
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
       this.btnExportPdf.BorderRadius = 22;
            this.btnExportPdf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
     this.btnExportPdf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
      this.btnExportPdf.ForeColor = System.Drawing.Color.Black;
    this.btnExportPdf.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
    this.btnExportPdf.Location = new System.Drawing.Point(1290, 132);
            this.btnExportPdf.Name = "btnExportPdf";
 this.btnExportPdf.Size = new System.Drawing.Size(175, 50);
            this.btnExportPdf.TabIndex = 8;
            this.btnExportPdf.Text = "?? Export PDF";
         
            // btnClose - Dark theme
         this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
       this.btnClose.BorderRadius = 14;
         this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
     this.btnClose.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1440, 25);
     this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            
            // dgvTimecard - Dark theme with gold headers
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
 this.dgvTimecard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimecard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
      | System.Windows.Forms.AnchorStyles.Right)));
    dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
       dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
    dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
     dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
    dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
       dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimecard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
       this.dgvTimecard.ColumnHeadersHeight = 45;
   this.dgvTimecard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
       dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
  dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvTimecard.DefaultCellStyle = dataGridViewCellStyle3;
       this.dgvTimecard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.dgvTimecard.Location = new System.Drawing.Point(48, 205);
        this.dgvTimecard.Name = "dgvTimecard";
            this.dgvTimecard.RowHeadersVisible = false;
     this.dgvTimecard.RowHeadersWidth = 51;
       this.dgvTimecard.RowTemplate.Height = 40;
            this.dgvTimecard.Size = new System.Drawing.Size(1417, 421);
       this.dgvTimecard.TabIndex = 0;
this.dgvTimecard.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvTimecard.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTimecard.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
     this.dgvTimecard.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
      this.dgvTimecard.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTimecard.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
  this.dgvTimecard.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
 this.dgvTimecard.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvTimecard.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
 this.dgvTimecard.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTimecard.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
          this.dgvTimecard.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        this.dgvTimecard.ThemeStyle.HeaderStyle.Height = 45;
this.dgvTimecard.ThemeStyle.ReadOnly = false;
  this.dgvTimecard.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvTimecard.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
   this.dgvTimecard.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTimecard.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvTimecard.ThemeStyle.RowsStyle.Height = 40;
            this.dgvTimecard.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
    this.dgvTimecard.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            
          // lblTotalRegularCaption - Light gray
     this.lblTotalRegularCaption.AutoSize = true;
          this.lblTotalRegularCaption.Font = new System.Drawing.Font("Century Gothic", 11F);
  this.lblTotalRegularCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
   this.lblTotalRegularCaption.Location = new System.Drawing.Point(30, 724);
   this.lblTotalRegularCaption.Name = "lblTotalRegularCaption";
            this.lblTotalRegularCaption.Size = new System.Drawing.Size(134, 22);
            this.lblTotalRegularCaption.TabIndex = 9;
            this.lblTotalRegularCaption.Text = "Total Regular:";
      
  // lblTotalRegularHours - Gold
this.lblTotalRegularHours.AutoSize = true;
       this.lblTotalRegularHours.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
         this.lblTotalRegularHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
          this.lblTotalRegularHours.Location = new System.Drawing.Point(170, 724);
       this.lblTotalRegularHours.Name = "lblTotalRegularHours";
            this.lblTotalRegularHours.Size = new System.Drawing.Size(21, 23);
            this.lblTotalRegularHours.TabIndex = 10;
  this.lblTotalRegularHours.Text = "0";
            
            // lblTotalOTCaption - Light gray
            this.lblTotalOTCaption.AutoSize = true;
 this.lblTotalOTCaption.Font = new System.Drawing.Font("Century Gothic", 11F);
       this.lblTotalOTCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        this.lblTotalOTCaption.Location = new System.Drawing.Point(266, 724);
  this.lblTotalOTCaption.Name = "lblTotalOTCaption";
            this.lblTotalOTCaption.Size = new System.Drawing.Size(102, 22);
            this.lblTotalOTCaption.TabIndex = 11;
            this.lblTotalOTCaption.Text = "Overtime:";
    
            // lblTotalOvertimeHours - Gold
    this.lblTotalOvertimeHours.AutoSize = true;
            this.lblTotalOvertimeHours.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalOvertimeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
    this.lblTotalOvertimeHours.Location = new System.Drawing.Point(374, 724);
       this.lblTotalOvertimeHours.Name = "lblTotalOvertimeHours";
     this.lblTotalOvertimeHours.Size = new System.Drawing.Size(21, 23);
        this.lblTotalOvertimeHours.TabIndex = 12;
       this.lblTotalOvertimeHours.Text = "0";
 
          // lblTotalHoursCaption - Light gray
         this.lblTotalHoursCaption.AutoSize = true;
  this.lblTotalHoursCaption.Font = new System.Drawing.Font("Century Gothic", 11F);
 this.lblTotalHoursCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
         this.lblTotalHoursCaption.Location = new System.Drawing.Point(486, 724);
        this.lblTotalHoursCaption.Name = "lblTotalHoursCaption";
            this.lblTotalHoursCaption.Size = new System.Drawing.Size(65, 22);
            this.lblTotalHoursCaption.TabIndex = 13;
            this.lblTotalHoursCaption.Text = "Hours:";
            
         // lblTotalHoursReported - Gold
            this.lblTotalHoursReported.AutoSize = true;
      this.lblTotalHoursReported.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
     this.lblTotalHoursReported.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblTotalHoursReported.Location = new System.Drawing.Point(557, 724);
            this.lblTotalHoursReported.Name = "lblTotalHoursReported";
  this.lblTotalHoursReported.Size = new System.Drawing.Size(21, 23);
            this.lblTotalHoursReported.TabIndex = 14;
      this.lblTotalHoursReported.Text = "0";
     
 // lblTotalPayCaption - Light gray
            this.lblTotalPayCaption.AutoSize = true;
         this.lblTotalPayCaption.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblTotalPayCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
  this.lblTotalPayCaption.Location = new System.Drawing.Point(686, 724);
            this.lblTotalPayCaption.Name = "lblTotalPayCaption";
            this.lblTotalPayCaption.Size = new System.Drawing.Size(50, 22);
 this.lblTotalPayCaption.TabIndex = 15;
            this.lblTotalPayCaption.Text = "Pay:";
            
 // lblTotalPay - Gold
            this.lblTotalPay.AutoSize = true;
     this.lblTotalPay.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
       this.lblTotalPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
    this.lblTotalPay.Location = new System.Drawing.Point(742, 724);
    this.lblTotalPay.Name = "lblTotalPay";
          this.lblTotalPay.Size = new System.Drawing.Size(60, 23);
    this.lblTotalPay.TabIndex = 16;
         this.lblTotalPay.Text = "?0.00";
        
     // lblEmployeeSigLine - Light gray
        this.lblEmployeeSigLine.AutoSize = true;
       this.lblEmployeeSigLine.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEmployeeSigLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
          this.lblEmployeeSigLine.Location = new System.Drawing.Point(30, 759);
       this.lblEmployeeSigLine.Name = "lblEmployeeSigLine";
            this.lblEmployeeSigLine.Size = new System.Drawing.Size(579, 21);
    this.lblEmployeeSigLine.TabIndex = 17;
     this.lblEmployeeSigLine.Text = "Employee Signature: __________________________    Date: __________";
    
     // lblSupervisorSigLine - Light gray
            this.lblSupervisorSigLine.AutoSize = true;
            this.lblSupervisorSigLine.Font = new System.Drawing.Font("Century Gothic", 10F);
         this.lblSupervisorSigLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        this.lblSupervisorSigLine.Location = new System.Drawing.Point(30, 789);
        this.lblSupervisorSigLine.Name = "lblSupervisorSigLine";
         this.lblSupervisorSigLine.Size = new System.Drawing.Size(564, 21);
            this.lblSupervisorSigLine.TabIndex = 18;
            this.lblSupervisorSigLine.Text = "Supervisor Signature: ________________________    Date: __________";
    
            // TimecardControl - Dark background
 this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
  this.Controls.Add(this.lblTotalRegularCaption);
 this.Controls.Add(this.lblTotalRegularHours);
  this.Controls.Add(this.lblTotalOTCaption);
            this.Controls.Add(this.lblTotalOvertimeHours);
      this.Controls.Add(this.lblTotalHoursCaption);
    this.Controls.Add(this.lblTotalHoursReported);
  this.Controls.Add(this.lblTotalPayCaption);
    this.Controls.Add(this.lblTotalPay);
        this.Controls.Add(this.lblEmployeeSigLine);
            this.Controls.Add(this.lblSupervisorSigLine);
     this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubTitle);
     this.Controls.Add(this.btnClose);
    this.Controls.Add(this.picEmployeePhoto);
        this.Controls.Add(this.lblEmployeeName);
  this.Controls.Add(this.btnPrevPeriod);
     this.Controls.Add(this.btnNextPeriod);
         this.Controls.Add(this.lblDateRange);
     this.Controls.Add(this.btnExportPdf);
    this.Controls.Add(this.dgvTimecard);
            this.Name = "TimecardControl";
            this.Size = new System.Drawing.Size(1540, 900);
      this.Load += new System.EventHandler(this.TimecardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeePhoto)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.dgvTimecard)).EndInit();
  this.ResumeLayout(false);
            this.PerformLayout();

        }

     #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

  private Guna.UI2.WinForms.Guna2CirclePictureBox picEmployeePhoto;
     private System.Windows.Forms.Label lblEmployeeName;
        private Guna.UI2.WinForms.Guna2Button btnPrevPeriod;
        private Guna.UI2.WinForms.Guna2Button btnNextPeriod;
  private System.Windows.Forms.Label lblDateRange;
  private Guna.UI2.WinForms.Guna2Button btnExportPdf;
        private Guna.UI2.WinForms.Guna2Button btnClose;

        private Guna.UI2.WinForms.Guna2DataGridView dgvTimecard;

  private System.Windows.Forms.Label lblTotalRegularCaption;
        private System.Windows.Forms.Label lblTotalRegularHours;
        private System.Windows.Forms.Label lblTotalOTCaption;
 private System.Windows.Forms.Label lblTotalOvertimeHours;
        private System.Windows.Forms.Label lblTotalHoursCaption;
        private System.Windows.Forms.Label lblTotalHoursReported;
      private System.Windows.Forms.Label lblTotalPayCaption;
     private System.Windows.Forms.Label lblTotalPay;

        private System.Windows.Forms.Label lblEmployeeSigLine;
        private System.Windows.Forms.Label lblSupervisorSigLine;
    }
}
