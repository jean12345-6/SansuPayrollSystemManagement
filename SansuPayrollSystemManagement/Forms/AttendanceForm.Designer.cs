namespace SansuPayrollSystemManagement
{
    partial class AttendanceForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblAttendanceTitle = new System.Windows.Forms.Label();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridViewAttendance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnMarkAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnImportAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.FillColor = System.Drawing.Color.LightCyan;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(734, 58);
            this.guna2Panel1.TabIndex = 0;
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
            // lblAttendanceTitle
            // 
            this.lblAttendanceTitle.AutoSize = true;
            this.lblAttendanceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceTitle.Location = new System.Drawing.Point(7, 91);
            this.lblAttendanceTitle.Name = "lblAttendanceTitle";
            this.lblAttendanceTitle.Size = new System.Drawing.Size(279, 29);
            this.lblAttendanceTitle.TabIndex = 1;
            this.lblAttendanceTitle.Text = "Attendance Management";
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.Location = new System.Drawing.Point(403, 91);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(151, 29);
            this.lblDateToday.TabIndex = 2;
            this.lblDateToday.Text = "[Date Today]";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 160);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(204, 29);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search Employee";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(467, 152);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 37);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // guna2DataGridViewAttendance
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.guna2DataGridViewAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewAttendance.ColumnHeadersHeight = 18;
            this.guna2DataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2DataGridViewAttendance.Location = new System.Drawing.Point(12, 196);
            this.guna2DataGridViewAttendance.Name = "guna2DataGridViewAttendance";
            this.guna2DataGridViewAttendance.ReadOnly = true;
            this.guna2DataGridViewAttendance.RowHeadersVisible = false;
            this.guna2DataGridViewAttendance.RowHeadersWidth = 51;
            this.guna2DataGridViewAttendance.RowTemplate.Height = 24;
            this.guna2DataGridViewAttendance.Size = new System.Drawing.Size(734, 210);
            this.guna2DataGridViewAttendance.TabIndex = 11;
            this.guna2DataGridViewAttendance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.guna2DataGridViewAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.guna2DataGridViewAttendance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewAttendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewAttendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewAttendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewAttendance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewAttendance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2DataGridViewAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.guna2DataGridViewAttendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewAttendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewAttendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewAttendance.ThemeStyle.HeaderStyle.Height = 18;
            this.guna2DataGridViewAttendance.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.guna2DataGridViewAttendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewAttendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewAttendance.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridViewAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.guna2DataGridViewAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewAttendance_CellContentClick);
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMarkAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMarkAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarkAttendance.ForeColor = System.Drawing.Color.White;
            this.btnMarkAttendance.Location = new System.Drawing.Point(589, 152);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(157, 37);
            this.btnMarkAttendance.TabIndex = 13;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // btnBackDashboard
            // 
            this.btnBackDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackDashboard.ForeColor = System.Drawing.Color.White;
            this.btnBackDashboard.Location = new System.Drawing.Point(566, 91);
            this.btnBackDashboard.Name = "btnBackDashboard";
            this.btnBackDashboard.Size = new System.Drawing.Size(180, 45);
            this.btnBackDashboard.TabIndex = 15;
            this.btnBackDashboard.Text = "Back To Dashboard";
            this.btnBackDashboard.Click += new System.EventHandler(this.btnBackDashboard_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(222, 152);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(229, 37);
            this.txtSearch.TabIndex = 16;
            // 
            // btnImportAttendance
            // 
            this.btnImportAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImportAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImportAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImportAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImportAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImportAttendance.ForeColor = System.Drawing.Color.White;
            this.btnImportAttendance.Location = new System.Drawing.Point(12, 424);
            this.btnImportAttendance.Name = "btnImportAttendance";
            this.btnImportAttendance.Size = new System.Drawing.Size(734, 45);
            this.btnImportAttendance.TabIndex = 18;
            this.btnImportAttendance.Text = "Import Attendance";
            this.btnImportAttendance.Click += new System.EventHandler(this.btnImportAttendance_Click);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 485);
            this.Controls.Add(this.btnImportAttendance);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBackDashboard);
            this.Controls.Add(this.btnMarkAttendance);
            this.Controls.Add(this.guna2DataGridViewAttendance);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDateToday);
            this.Controls.Add(this.lblAttendanceTitle);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblAttendanceTitle;
        private System.Windows.Forms.Label lblDateToday;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewAttendance;
        private Guna.UI2.WinForms.Guna2Button btnMarkAttendance;
        private Guna.UI2.WinForms.Guna2Button btnBackDashboard;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnImportAttendance;
    }
}