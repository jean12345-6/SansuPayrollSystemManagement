using System;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement.Forms
{
    partial class PerformanceDetailsControl
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
  this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblDateCaption = new System.Windows.Forms.Label();
    this.lblPositionValue = new System.Windows.Forms.Label();
   this.lblPositionCaption = new System.Windows.Forms.Label();
this.lblEmployeeValue = new System.Windows.Forms.Label();
            this.lblEmployeeCaption = new System.Windows.Forms.Label();
   this.lblHeaderTitle = new System.Windows.Forms.Label();
    this.panelScores = new Guna.UI2.WinForms.Guna2Panel();
      this.lblTotalScoreValue = new System.Windows.Forms.Label();
            this.lblAttendanceScoreValue = new System.Windows.Forms.Label();
    this.lblFeedbackScoreValue = new System.Windows.Forms.Label();
      this.lblSalesValue = new System.Windows.Forms.Label();
            this.lblTotalScoreCaption = new System.Windows.Forms.Label();
            this.lblAttendanceScoreCaption = new System.Windows.Forms.Label();
 this.lblFeedbackScoreCaption = new System.Windows.Forms.Label();
  this.lblSalesCaption = new System.Windows.Forms.Label();
            this.lblScoresTitle = new System.Windows.Forms.Label();
  this.panelStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatusValue = new System.Windows.Forms.Label();
   this.lblStatusTitle = new System.Windows.Forms.Label();
   this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.headerPanel.SuspendLayout();
      this.panelScores.SuspendLayout();
      this.panelStatus.SuspendLayout();
 this.SuspendLayout();

            // ========== BACKGROUND - Dark theme ==========
   this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));

            // ========== headerPanel - Dark theme ==========
            this.headerPanel.Controls.Add(this.lblDateValue);
this.headerPanel.Controls.Add(this.lblDateCaption);
       this.headerPanel.Controls.Add(this.lblPositionValue);
            this.headerPanel.Controls.Add(this.lblPositionCaption);
            this.headerPanel.Controls.Add(this.lblEmployeeValue);
            this.headerPanel.Controls.Add(this.lblEmployeeCaption);
       this.headerPanel.Controls.Add(this.lblHeaderTitle);
   this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
     this.headerPanel.Location = new System.Drawing.Point(0, 0);
          this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1920, 120);
      this.headerPanel.TabIndex = 0;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);

         // ========== lblHeaderTitle - Gold accent ==========
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
    this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
     this.lblHeaderTitle.Location = new System.Drawing.Point(40, 15);
     this.lblHeaderTitle.Name = "lblHeaderTitle";
this.lblHeaderTitle.Size = new System.Drawing.Size(385, 55);
      this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "?? Performance Details";

     // ========== Employee Caption & Value ==========
     this.lblEmployeeCaption.AutoSize = true;
            this.lblEmployeeCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
 this.lblEmployeeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblEmployeeCaption.Location = new System.Drawing.Point(40, 75);
      this.lblEmployeeCaption.Name = "lblEmployeeCaption";
            this.lblEmployeeCaption.Size = new System.Drawing.Size(90, 25);
      this.lblEmployeeCaption.TabIndex = 1;
      this.lblEmployeeCaption.Text = "Employee:";

            this.lblEmployeeValue.AutoSize = true;
        this.lblEmployeeValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
     this.lblEmployeeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
        this.lblEmployeeValue.Location = new System.Drawing.Point(140, 75);
       this.lblEmployeeValue.Name = "lblEmployeeValue";
   this.lblEmployeeValue.Size = new System.Drawing.Size(180, 25);
    this.lblEmployeeValue.TabIndex = 2;
    this.lblEmployeeValue.Text = "[EmployeeName]";

 // ========== Position Caption & Value ==========
            this.lblPositionCaption.AutoSize = true;
 this.lblPositionCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPositionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
   this.lblPositionCaption.Location = new System.Drawing.Point(640, 75);
            this.lblPositionCaption.Name = "lblPositionCaption";
   this.lblPositionCaption.Size = new System.Drawing.Size(75, 25);
   this.lblPositionCaption.TabIndex = 3;
        this.lblPositionCaption.Text = "Position:";

       this.lblPositionValue.AutoSize = true;
        this.lblPositionValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblPositionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
     this.lblPositionValue.Location = new System.Drawing.Point(720, 75);
            this.lblPositionValue.Name = "lblPositionValue";
         this.lblPositionValue.Size = new System.Drawing.Size(100, 25);
this.lblPositionValue.TabIndex = 4;
            this.lblPositionValue.Text = "[Position]";

            // ========== Date Caption & Value ==========
  this.lblDateCaption.AutoSize = true;
 this.lblDateCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
      this.lblDateCaption.Location = new System.Drawing.Point(1280, 75);
this.lblDateCaption.Name = "lblDateCaption";
      this.lblDateCaption.Size = new System.Drawing.Size(55, 25);
            this.lblDateCaption.TabIndex = 5;
      this.lblDateCaption.Text = "Date:";

   this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
      this.lblDateValue.Location = new System.Drawing.Point(1340, 75);
          this.lblDateValue.Name = "lblDateValue";
     this.lblDateValue.Size = new System.Drawing.Size(70, 25);
     this.lblDateValue.TabIndex = 6;
            this.lblDateValue.Text = "[Date]";

            // ========== panelScores - Dark theme with gold shadow ==========
      this.panelScores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
 this.panelScores.Controls.Add(this.lblTotalScoreValue);
     this.panelScores.Controls.Add(this.lblAttendanceScoreValue);
  this.panelScores.Controls.Add(this.lblFeedbackScoreValue);
    this.panelScores.Controls.Add(this.lblSalesValue);
      this.panelScores.Controls.Add(this.lblTotalScoreCaption);
          this.panelScores.Controls.Add(this.lblAttendanceScoreCaption);
            this.panelScores.Controls.Add(this.lblFeedbackScoreCaption);
  this.panelScores.Controls.Add(this.lblSalesCaption);
this.panelScores.Controls.Add(this.lblScoresTitle);
  this.panelScores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
    this.panelScores.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
      this.panelScores.ShadowDecoration.Depth = 15;
 this.panelScores.BorderRadius = 15;
        this.panelScores.Location = new System.Drawing.Point(40, 150);
       this.panelScores.Name = "panelScores";
            this.panelScores.Size = new System.Drawing.Size(920, 320);
            this.panelScores.TabIndex = 1;

            // ========== lblScoresTitle - Gold accent ==========
            this.lblScoresTitle.AutoSize = true;
       this.lblScoresTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
 this.lblScoresTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblScoresTitle.Location = new System.Drawing.Point(30, 20);
     this.lblScoresTitle.Name = "lblScoresTitle";
            this.lblScoresTitle.Size = new System.Drawing.Size(100, 32);
       this.lblScoresTitle.TabIndex = 0;
            this.lblScoresTitle.Text = "Scores";

      // ========== Sales Caption & Value ==========
          this.lblSalesCaption.AutoSize = true;
   this.lblSalesCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
   this.lblSalesCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSalesCaption.Location = new System.Drawing.Point(30, 80);
            this.lblSalesCaption.Name = "lblSalesCaption";
            this.lblSalesCaption.Size = new System.Drawing.Size(70, 25);
    this.lblSalesCaption.TabIndex = 1;
  this.lblSalesCaption.Text = "Sales:";

          this.lblSalesValue.AutoSize = true;
            this.lblSalesValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
    this.lblSalesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.lblSalesValue.Location = new System.Drawing.Point(110, 80);
            this.lblSalesValue.Name = "lblSalesValue";
     this.lblSalesValue.Size = new System.Drawing.Size(80, 28);
            this.lblSalesValue.TabIndex = 5;
            this.lblSalesValue.Text = "[Sales]";

            // ========== Feedback Score Caption & Value ==========
     this.lblFeedbackScoreCaption.AutoSize = true;
     this.lblFeedbackScoreCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
    this.lblFeedbackScoreCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        this.lblFeedbackScoreCaption.Location = new System.Drawing.Point(30, 140);
        this.lblFeedbackScoreCaption.Name = "lblFeedbackScoreCaption";
   this.lblFeedbackScoreCaption.Size = new System.Drawing.Size(145, 25);
            this.lblFeedbackScoreCaption.TabIndex = 2;
       this.lblFeedbackScoreCaption.Text = "Feedback Score:";

            this.lblFeedbackScoreValue.AutoSize = true;
            this.lblFeedbackScoreValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
   this.lblFeedbackScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
  this.lblFeedbackScoreValue.Location = new System.Drawing.Point(180, 140);
        this.lblFeedbackScoreValue.Name = "lblFeedbackScoreValue";
            this.lblFeedbackScoreValue.Size = new System.Drawing.Size(140, 28);
    this.lblFeedbackScoreValue.TabIndex = 6;
            this.lblFeedbackScoreValue.Text = "[FeedbackScore]";

      // ========== Attendance Score Caption & Value ==========
            this.lblAttendanceScoreCaption.AutoSize = true;
            this.lblAttendanceScoreCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
   this.lblAttendanceScoreCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        this.lblAttendanceScoreCaption.Location = new System.Drawing.Point(30, 200);
    this.lblAttendanceScoreCaption.Name = "lblAttendanceScoreCaption";
      this.lblAttendanceScoreCaption.Size = new System.Drawing.Size(155, 25);
       this.lblAttendanceScoreCaption.TabIndex = 3;
  this.lblAttendanceScoreCaption.Text = "Attendance Score:";

            this.lblAttendanceScoreValue.AutoSize = true;
            this.lblAttendanceScoreValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
  this.lblAttendanceScoreValue.Location = new System.Drawing.Point(190, 200);
    this.lblAttendanceScoreValue.Name = "lblAttendanceScoreValue";
            this.lblAttendanceScoreValue.Size = new System.Drawing.Size(160, 28);
            this.lblAttendanceScoreValue.TabIndex = 7;
            this.lblAttendanceScoreValue.Text = "[AttendanceScore]";

            // ========== Total Score Caption & Value ==========
  this.lblTotalScoreCaption.AutoSize = true;
            this.lblTotalScoreCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalScoreCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
          this.lblTotalScoreCaption.Location = new System.Drawing.Point(30, 270);
 this.lblTotalScoreCaption.Name = "lblTotalScoreCaption";
         this.lblTotalScoreCaption.Size = new System.Drawing.Size(120, 28);
     this.lblTotalScoreCaption.TabIndex = 4;
            this.lblTotalScoreCaption.Text = "Total Score:";

 this.lblTotalScoreValue.AutoSize = true;
    this.lblTotalScoreValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
  this.lblTotalScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
      this.lblTotalScoreValue.Location = new System.Drawing.Point(155, 270);
 this.lblTotalScoreValue.Name = "lblTotalScoreValue";
          this.lblTotalScoreValue.Size = new System.Drawing.Size(120, 32);
            this.lblTotalScoreValue.TabIndex = 8;
      this.lblTotalScoreValue.Text = "[TotalScore]";

      // ========== panelStatus - Dark theme with gold shadow ==========
            this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))));
     this.panelStatus.Controls.Add(this.lblStatusValue);
            this.panelStatus.Controls.Add(this.lblStatusTitle);
            this.panelStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
    this.panelStatus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.panelStatus.ShadowDecoration.Depth = 15;
      this.panelStatus.BorderRadius = 15;
            this.panelStatus.Location = new System.Drawing.Point(980, 150);
      this.panelStatus.Name = "panelStatus";
       this.panelStatus.Size = new System.Drawing.Size(900, 320);
   this.panelStatus.TabIndex = 2;

            // ========== lblStatusTitle - Gold accent ==========
 this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
   this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
      this.lblStatusTitle.Location = new System.Drawing.Point(30, 20);
      this.lblStatusTitle.Name = "lblStatusTitle";
    this.lblStatusTitle.Size = new System.Drawing.Size(100, 32);
   this.lblStatusTitle.TabIndex = 0;
         this.lblStatusTitle.Text = "Status";

          // ========== lblStatusValue - Large gold text ==========
      this.lblStatusValue.AutoSize = true;
  this.lblStatusValue.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
    this.lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
  this.lblStatusValue.Location = new System.Drawing.Point(30, 120);
 this.lblStatusValue.Name = "lblStatusValue";
  this.lblStatusValue.Size = new System.Drawing.Size(200, 48);
   this.lblStatusValue.TabIndex = 1;
            this.lblStatusValue.Text = "[Status]";

      // ========== btnClose - Gold theme ==========
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 10;
    this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
      this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
     this.btnClose.ForeColor = System.Drawing.Color.Black;
  this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
  this.btnClose.Location = new System.Drawing.Point(1750, 550);
    this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
this.btnClose.TabIndex = 3;
     this.btnClose.Text = "? Back";
          this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

   // ========== PerformanceDetailsControl - Fullscreen ==========
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.btnClose);
       this.Controls.Add(this.panelStatus);
 this.Controls.Add(this.panelScores);
       this.Controls.Add(this.headerPanel);
      this.Name = "PerformanceDetailsControl";
            this.Size = new System.Drawing.Size(1920, 1080);
  this.Load += new System.EventHandler(this.PerformanceDetailsControl_Load);
  this.headerPanel.ResumeLayout(false);
  this.headerPanel.PerformLayout();
this.panelScores.ResumeLayout(false);
       this.panelScores.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

  private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblEmployeeCaption;
        private System.Windows.Forms.Label lblEmployeeValue;
        private System.Windows.Forms.Label lblPositionCaption;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label lblDateCaption;
private System.Windows.Forms.Label lblDateValue;
        private Guna.UI2.WinForms.Guna2Panel panelScores;
   private System.Windows.Forms.Label lblScoresTitle;
        private System.Windows.Forms.Label lblSalesCaption;
        private System.Windows.Forms.Label lblSalesValue;
  private System.Windows.Forms.Label lblFeedbackScoreCaption;
        private System.Windows.Forms.Label lblFeedbackScoreValue;
      private System.Windows.Forms.Label lblAttendanceScoreCaption;
        private System.Windows.Forms.Label lblAttendanceScoreValue;
  private System.Windows.Forms.Label lblTotalScoreCaption;
        private System.Windows.Forms.Label lblTotalScoreValue;
   private Guna.UI2.WinForms.Guna2Panel panelStatus;
      private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatusValue;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
