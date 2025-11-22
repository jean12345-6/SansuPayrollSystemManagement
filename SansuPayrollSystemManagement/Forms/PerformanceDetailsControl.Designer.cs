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
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.lblDateValue);
            this.headerPanel.Controls.Add(this.lblDateCaption);
            this.headerPanel.Controls.Add(this.lblPositionValue);
            this.headerPanel.Controls.Add(this.lblPositionCaption);
            this.headerPanel.Controls.Add(this.lblEmployeeValue);
            this.headerPanel.Controls.Add(this.lblEmployeeCaption);
            this.headerPanel.Controls.Add(this.lblHeaderTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1100, 90);
            this.headerPanel.TabIndex = 0;
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Location = new System.Drawing.Point(630, 55);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(47, 16);
            this.lblDateValue.TabIndex = 6;
            this.lblDateValue.Text = "[Date]";
            // 
            // lblDateCaption
            // 
            this.lblDateCaption.AutoSize = true;
            this.lblDateCaption.Location = new System.Drawing.Point(580, 55);
            this.lblDateCaption.Name = "lblDateCaption";
            this.lblDateCaption.Size = new System.Drawing.Size(42, 16);
            this.lblDateCaption.TabIndex = 5;
            this.lblDateCaption.Text = "Date:";
            // 
            // lblPositionValue
            // 
            this.lblPositionValue.AutoSize = true;
            this.lblPositionValue.Location = new System.Drawing.Point(120, 55);
            this.lblPositionValue.Name = "lblPositionValue";
            this.lblPositionValue.Size = new System.Drawing.Size(64, 16);
            this.lblPositionValue.TabIndex = 4;
            this.lblPositionValue.Text = "[Position]";
            // 
            // lblPositionCaption
            // 
            this.lblPositionCaption.AutoSize = true;
            this.lblPositionCaption.Location = new System.Drawing.Point(20, 55);
            this.lblPositionCaption.Name = "lblPositionCaption";
            this.lblPositionCaption.Size = new System.Drawing.Size(60, 16);
            this.lblPositionCaption.TabIndex = 3;
            this.lblPositionCaption.Text = "Position:";
            // 
            // lblEmployeeValue
            // 
            this.lblEmployeeValue.AutoSize = true;
            this.lblEmployeeValue.Location = new System.Drawing.Point(120, 35);
            this.lblEmployeeValue.Name = "lblEmployeeValue";
            this.lblEmployeeValue.Size = new System.Drawing.Size(105, 16);
            this.lblEmployeeValue.TabIndex = 2;
            this.lblEmployeeValue.Text = "[EmployeeName]";
            // 
            // lblEmployeeCaption
            // 
            this.lblEmployeeCaption.AutoSize = true;
            this.lblEmployeeCaption.Location = new System.Drawing.Point(20, 35);
            this.lblEmployeeCaption.Name = "lblEmployeeCaption";
            this.lblEmployeeCaption.Size = new System.Drawing.Size(71, 16);
            this.lblEmployeeCaption.TabIndex = 1;
            this.lblEmployeeCaption.Text = "Employee:";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Location = new System.Drawing.Point(18, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(154, 16);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Performance Details";
            // 
            // panelScores
            // 
            this.panelScores.Controls.Add(this.lblTotalScoreValue);
            this.panelScores.Controls.Add(this.lblAttendanceScoreValue);
            this.panelScores.Controls.Add(this.lblFeedbackScoreValue);
            this.panelScores.Controls.Add(this.lblSalesValue);
            this.panelScores.Controls.Add(this.lblTotalScoreCaption);
            this.panelScores.Controls.Add(this.lblAttendanceScoreCaption);
            this.panelScores.Controls.Add(this.lblFeedbackScoreCaption);
            this.panelScores.Controls.Add(this.lblSalesCaption);
            this.panelScores.Controls.Add(this.lblScoresTitle);
            this.panelScores.Location = new System.Drawing.Point(30, 110);
            this.panelScores.Name = "panelScores";
            this.panelScores.Size = new System.Drawing.Size(600, 230);
            this.panelScores.TabIndex = 1;
            // 
            // lblTotalScoreValue
            // 
            this.lblTotalScoreValue.AutoSize = true;
            this.lblTotalScoreValue.Location = new System.Drawing.Point(170, 160);
            this.lblTotalScoreValue.Name = "lblTotalScoreValue";
            this.lblTotalScoreValue.Size = new System.Drawing.Size(83, 16);
            this.lblTotalScoreValue.TabIndex = 8;
            this.lblTotalScoreValue.Text = "[TotalScore]";
            // 
            // lblAttendanceScoreValue
            // 
            this.lblAttendanceScoreValue.AutoSize = true;
            this.lblAttendanceScoreValue.Location = new System.Drawing.Point(170, 130);
            this.lblAttendanceScoreValue.Name = "lblAttendanceScoreValue";
            this.lblAttendanceScoreValue.Size = new System.Drawing.Size(115, 16);
            this.lblAttendanceScoreValue.TabIndex = 7;
            this.lblAttendanceScoreValue.Text = "[AttendanceScore]";
            // 
            // lblFeedbackScoreValue
            // 
            this.lblFeedbackScoreValue.AutoSize = true;
            this.lblFeedbackScoreValue.Location = new System.Drawing.Point(170, 100);
            this.lblFeedbackScoreValue.Name = "lblFeedbackScoreValue";
            this.lblFeedbackScoreValue.Size = new System.Drawing.Size(107, 16);
            this.lblFeedbackScoreValue.TabIndex = 6;
            this.lblFeedbackScoreValue.Text = "[FeedbackScore]";
            // 
            // lblSalesValue
            // 
            this.lblSalesValue.AutoSize = true;
            this.lblSalesValue.Location = new System.Drawing.Point(170, 70);
            this.lblSalesValue.Name = "lblSalesValue";
            this.lblSalesValue.Size = new System.Drawing.Size(46, 16);
            this.lblSalesValue.TabIndex = 5;
            this.lblSalesValue.Text = "[Sales]";
            // 
            // lblTotalScoreCaption
            // 
            this.lblTotalScoreCaption.AutoSize = true;
            this.lblTotalScoreCaption.Location = new System.Drawing.Point(20, 160);
            this.lblTotalScoreCaption.Name = "lblTotalScoreCaption";
            this.lblTotalScoreCaption.Size = new System.Drawing.Size(79, 16);
            this.lblTotalScoreCaption.TabIndex = 4;
            this.lblTotalScoreCaption.Text = "Total score:";
            // 
            // lblAttendanceScoreCaption
            // 
            this.lblAttendanceScoreCaption.AutoSize = true;
            this.lblAttendanceScoreCaption.Location = new System.Drawing.Point(20, 130);
            this.lblAttendanceScoreCaption.Name = "lblAttendanceScoreCaption";
            this.lblAttendanceScoreCaption.Size = new System.Drawing.Size(116, 16);
            this.lblAttendanceScoreCaption.TabIndex = 3;
            this.lblAttendanceScoreCaption.Text = "Attendance score:";
            // 
            // lblFeedbackScoreCaption
            // 
            this.lblFeedbackScoreCaption.AutoSize = true;
            this.lblFeedbackScoreCaption.Location = new System.Drawing.Point(20, 100);
            this.lblFeedbackScoreCaption.Name = "lblFeedbackScoreCaption";
            this.lblFeedbackScoreCaption.Size = new System.Drawing.Size(108, 16);
            this.lblFeedbackScoreCaption.TabIndex = 2;
            this.lblFeedbackScoreCaption.Text = "Feedback score:";
            // 
            // lblSalesCaption
            // 
            this.lblSalesCaption.AutoSize = true;
            this.lblSalesCaption.Location = new System.Drawing.Point(20, 70);
            this.lblSalesCaption.Name = "lblSalesCaption";
            this.lblSalesCaption.Size = new System.Drawing.Size(45, 16);
            this.lblSalesCaption.TabIndex = 1;
            this.lblSalesCaption.Text = "Sales:";
            // 
            // lblScoresTitle
            // 
            this.lblScoresTitle.AutoSize = true;
            this.lblScoresTitle.Location = new System.Drawing.Point(18, 20);
            this.lblScoresTitle.Name = "lblScoresTitle";
            this.lblScoresTitle.Size = new System.Drawing.Size(52, 16);
            this.lblScoresTitle.TabIndex = 0;
            this.lblScoresTitle.Text = "Scores";
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.lblStatusValue);
            this.panelStatus.Controls.Add(this.lblStatusTitle);
            this.panelStatus.Location = new System.Drawing.Point(660, 110);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(380, 140);
            this.panelStatus.TabIndex = 2;
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(20, 70);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(54, 16);
            this.lblStatusValue.TabIndex = 1;
            this.lblStatusValue.Text = "[Status]";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(18, 20);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(48, 16);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "Status";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(940, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PerformanceDetailsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelScores);
            this.Controls.Add(this.headerPanel);
            this.Name = "PerformanceDetailsControl";
            this.Size = new System.Drawing.Size(1100, 420);
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
