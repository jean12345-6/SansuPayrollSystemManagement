using System.Drawing;
using System.Windows.Forms;


namespace SansuPayrollSystemManagement.Forms
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;

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
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPosition = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateHired = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFullName.BorderRadius = 8;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtFullName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtFullName.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtFullName.Location = new System.Drawing.Point(261, 86);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(327, 44);
            this.txtFullName.TabIndex = 0;
            // 
            // txtPosition
            // 
            this.txtPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPosition.BorderRadius = 8;
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition.DefaultText = "";
            this.txtPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtPosition.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtPosition.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPosition.ForeColor = System.Drawing.Color.White;
            this.txtPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtPosition.Location = new System.Drawing.Point(261, 149);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.PlaceholderText = "";
            this.txtPosition.SelectedText = "";
            this.txtPosition.Size = new System.Drawing.Size(327, 44);
            this.txtPosition.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtContact.BorderRadius = 8;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtContact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtContact.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtContact.Location = new System.Drawing.Point(261, 228);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContact.Name = "txtContact";
            this.txtContact.PlaceholderText = "";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(327, 44);
            this.txtContact.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSalary.BorderRadius = 8;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtSalary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtSalary.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.ForeColor = System.Drawing.Color.White;
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.txtSalary.Location = new System.Drawing.Point(261, 304);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(327, 44);
            this.txtSalary.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 26;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(16, 457);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 55);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 26;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(348, 457);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 55);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(133, 28);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(600, 50);
            this.guna2HtmlLabel5.TabIndex = 19;
            this.guna2HtmlLabel5.Text = "ADD NEW EMPLOYEE";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(16, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(16, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(8, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contact Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(8, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(8, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date Hired";
            // 
            // dtpDateHired
            // 
            this.dtpDateHired.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpDateHired.BorderRadius = 8;
            this.dtpDateHired.Checked = true;
            this.dtpDateHired.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpDateHired.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateHired.ForeColor = System.Drawing.Color.White;
            this.dtpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateHired.Location = new System.Drawing.Point(261, 380);
            this.dtpDateHired.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateHired.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateHired.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateHired.Name = "dtpDateHired";
            this.dtpDateHired.Size = new System.Drawing.Size(327, 44);
            this.dtpDateHired.TabIndex = 18;
            this.dtpDateHired.Value = new System.DateTime(2025, 11, 7, 4, 37, 54, 762);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 29);
            this.btnClose.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelMain.Controls.Add(this.guna2HtmlLabel5);
            this.panelMain.Controls.Add(this.dtpDateHired);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.txtSalary);
            this.panelMain.Controls.Add(this.txtContact);
            this.panelMain.Controls.Add(this.txtPosition);
            this.panelMain.Controls.Add(this.txtFullName);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(20, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(860, 560);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

    }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtPosition;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateHired;
    }
}