using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SansuPayrollSystemManagement.Forms
{
    partial class DashboardOverviewControl
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;

        private Panel headerPanel;

        private TableLayoutPanel tblSummaryRow;
        private Panel cardEmployees;
        private Panel cardPresent;
        private Panel cardPaidThisMonth;
        private Panel cardTotalPayroll;

        private Label lblEmpTitle;
        private Label lblEmpValue;
        private Label lblPresentTitle;
        private Label lblPresentValue;
        private Label lblPaidTitle;
        private Label lblPaidValue;
        private Label lblTotalCostTitle;
        private Label lblTotalCostValue;

        private TableLayoutPanel tblSubSummary;
        private Panel panelOutstanding;
        private Panel panelSales;
        private Panel panelAvg;
        private Label lblOutstandingTitle;
        private Label lblOutstandingValue;
        private Label lblSalesTitle;
        private Label lblSalesValue;
        private Label lblAvgAttendanceTitle;
        private Label lblAvgAttendanceValue;

        private TableLayoutPanel tblMiddle;
        private Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPayrollTrend;
        private Label lblChartTitle;

        private Panel panelRecent;
        private Label lblRecentTitle;
        private DataGridView dgvRecentPayroll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tblSummaryRow = new System.Windows.Forms.TableLayoutPanel();
            this.cardEmployees = new System.Windows.Forms.Panel();
            this.lblEmpValue = new System.Windows.Forms.Label();
            this.lblEmpTitle = new System.Windows.Forms.Label();
            this.cardPresent = new System.Windows.Forms.Panel();
            this.lblPresentValue = new System.Windows.Forms.Label();
            this.lblPresentTitle = new System.Windows.Forms.Label();
            this.cardPaidThisMonth = new System.Windows.Forms.Panel();
            this.lblPaidValue = new System.Windows.Forms.Label();
            this.lblPaidTitle = new System.Windows.Forms.Label();
            this.cardTotalPayroll = new System.Windows.Forms.Panel();
            this.lblTotalCostValue = new System.Windows.Forms.Label();
            this.lblTotalCostTitle = new System.Windows.Forms.Label();
            this.tblSubSummary = new System.Windows.Forms.TableLayoutPanel();
            this.panelOutstanding = new System.Windows.Forms.Panel();
            this.lblOutstandingValue = new System.Windows.Forms.Label();
            this.lblOutstandingTitle = new System.Windows.Forms.Label();
            this.panelSales = new System.Windows.Forms.Panel();
            this.lblSalesValue = new System.Windows.Forms.Label();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.panelAvg = new System.Windows.Forms.Panel();
            this.lblAvgAttendanceValue = new System.Windows.Forms.Label();
            this.lblAvgAttendanceTitle = new System.Windows.Forms.Label();
            this.tblMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartPayrollTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.panelRecent = new System.Windows.Forms.Panel();
            this.dgvRecentPayroll = new System.Windows.Forms.DataGridView();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.tblSummaryRow.SuspendLayout();
            this.cardEmployees.SuspendLayout();
            this.cardPresent.SuspendLayout();
            this.cardPaidThisMonth.SuspendLayout();
            this.cardTotalPayroll.SuspendLayout();
            this.tblSubSummary.SuspendLayout();
            this.panelOutstanding.SuspendLayout();
            this.panelSales.SuspendLayout();
            this.panelAvg.SuspendLayout();
            this.tblMiddle.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayrollTrend)).BeginInit();
            this.panelRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(20, 20);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1437, 80);
            this.headerPanel.TabIndex = 3;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(8, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(404, 23);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Welcome to Sansu Payroll & Performance Dashboard.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 44);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard Overview";
            // 
            // tblSummaryRow
            // 
            this.tblSummaryRow.ColumnCount = 4;
            this.tblSummaryRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummaryRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummaryRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummaryRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummaryRow.Controls.Add(this.cardEmployees, 0, 0);
            this.tblSummaryRow.Controls.Add(this.cardPresent, 1, 0);
            this.tblSummaryRow.Controls.Add(this.cardPaidThisMonth, 2, 0);
            this.tblSummaryRow.Controls.Add(this.cardTotalPayroll, 3, 0);
            this.tblSummaryRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblSummaryRow.Location = new System.Drawing.Point(20, 100);
            this.tblSummaryRow.Name = "tblSummaryRow";
            this.tblSummaryRow.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tblSummaryRow.RowCount = 1;
            this.tblSummaryRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblSummaryRow.Size = new System.Drawing.Size(1437, 130);
            this.tblSummaryRow.TabIndex = 2;
            // 
            // cardEmployees
            // 
            this.cardEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.cardEmployees.Controls.Add(this.lblEmpValue);
            this.cardEmployees.Controls.Add(this.lblEmpTitle);
            this.cardEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardEmployees.Location = new System.Drawing.Point(5, 15);
            this.cardEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.cardEmployees.Name = "cardEmployees";
            this.cardEmployees.Padding = new System.Windows.Forms.Padding(12);
            this.cardEmployees.Size = new System.Drawing.Size(349, 110);
            this.cardEmployees.TabIndex = 0;
            // 
            // lblEmpValue
            // 
            this.lblEmpValue.AutoSize = true;
            this.lblEmpValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblEmpValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(98)))), ((int)(((byte)(81)))));
            this.lblEmpValue.Location = new System.Drawing.Point(0, 30);
            this.lblEmpValue.Name = "lblEmpValue";
            this.lblEmpValue.Size = new System.Drawing.Size(34, 46);
            this.lblEmpValue.TabIndex = 0;
            this.lblEmpValue.Text = "-";
            // 
            // lblEmpTitle
            // 
            this.lblEmpTitle.AutoSize = true;
            this.lblEmpTitle.Location = new System.Drawing.Point(0, 0);
            this.lblEmpTitle.Name = "lblEmpTitle";
            this.lblEmpTitle.Size = new System.Drawing.Size(110, 16);
            this.lblEmpTitle.TabIndex = 1;
            this.lblEmpTitle.Text = "Total Employees";
            // 
            // cardPresent
            // 
            this.cardPresent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.cardPresent.Controls.Add(this.lblPresentValue);
            this.cardPresent.Controls.Add(this.lblPresentTitle);
            this.cardPresent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPresent.Location = new System.Drawing.Point(364, 15);
            this.cardPresent.Margin = new System.Windows.Forms.Padding(5);
            this.cardPresent.Name = "cardPresent";
            this.cardPresent.Padding = new System.Windows.Forms.Padding(12);
            this.cardPresent.Size = new System.Drawing.Size(349, 110);
            this.cardPresent.TabIndex = 1;
            // 
            // lblPresentValue
            // 
            this.lblPresentValue.AutoSize = true;
            this.lblPresentValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPresentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.lblPresentValue.Location = new System.Drawing.Point(0, 30);
            this.lblPresentValue.Name = "lblPresentValue";
            this.lblPresentValue.Size = new System.Drawing.Size(34, 46);
            this.lblPresentValue.TabIndex = 0;
            this.lblPresentValue.Text = "-";
            // 
            // lblPresentTitle
            // 
            this.lblPresentTitle.AutoSize = true;
            this.lblPresentTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPresentTitle.Name = "lblPresentTitle";
            this.lblPresentTitle.Size = new System.Drawing.Size(96, 16);
            this.lblPresentTitle.TabIndex = 1;
            this.lblPresentTitle.Text = "Present Today";
            // 
            // cardPaidThisMonth
            // 
            this.cardPaidThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.cardPaidThisMonth.Controls.Add(this.lblPaidValue);
            this.cardPaidThisMonth.Controls.Add(this.lblPaidTitle);
            this.cardPaidThisMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPaidThisMonth.Location = new System.Drawing.Point(723, 15);
            this.cardPaidThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.cardPaidThisMonth.Name = "cardPaidThisMonth";
            this.cardPaidThisMonth.Padding = new System.Windows.Forms.Padding(12);
            this.cardPaidThisMonth.Size = new System.Drawing.Size(349, 110);
            this.cardPaidThisMonth.TabIndex = 2;
            // 
            // lblPaidValue
            // 
            this.lblPaidValue.AutoSize = true;
            this.lblPaidValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPaidValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.lblPaidValue.Location = new System.Drawing.Point(0, 32);
            this.lblPaidValue.Name = "lblPaidValue";
            this.lblPaidValue.Size = new System.Drawing.Size(104, 41);
            this.lblPaidValue.TabIndex = 0;
            this.lblPaidValue.Text = "₱ 0.00";
            // 
            // lblPaidTitle
            // 
            this.lblPaidTitle.AutoSize = true;
            this.lblPaidTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPaidTitle.Name = "lblPaidTitle";
            this.lblPaidTitle.Size = new System.Drawing.Size(123, 16);
            this.lblPaidTitle.TabIndex = 1;
            this.lblPaidTitle.Text = "Paid This Month (₱)";
            // 
            // cardTotalPayroll
            // 
            this.cardTotalPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cardTotalPayroll.Controls.Add(this.lblTotalCostValue);
            this.cardTotalPayroll.Controls.Add(this.lblTotalCostTitle);
            this.cardTotalPayroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTotalPayroll.Location = new System.Drawing.Point(1082, 15);
            this.cardTotalPayroll.Margin = new System.Windows.Forms.Padding(5);
            this.cardTotalPayroll.Name = "cardTotalPayroll";
            this.cardTotalPayroll.Padding = new System.Windows.Forms.Padding(12);
            this.cardTotalPayroll.Size = new System.Drawing.Size(350, 110);
            this.cardTotalPayroll.TabIndex = 3;
            // 
            // lblTotalCostValue
            // 
            this.lblTotalCostValue.AutoSize = true;
            this.lblTotalCostValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalCostValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.lblTotalCostValue.Location = new System.Drawing.Point(0, 32);
            this.lblTotalCostValue.Name = "lblTotalCostValue";
            this.lblTotalCostValue.Size = new System.Drawing.Size(104, 41);
            this.lblTotalCostValue.TabIndex = 0;
            this.lblTotalCostValue.Text = "₱ 0.00";
            // 
            // lblTotalCostTitle
            // 
            this.lblTotalCostTitle.AutoSize = true;
            this.lblTotalCostTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalCostTitle.Name = "lblTotalCostTitle";
            this.lblTotalCostTitle.Size = new System.Drawing.Size(133, 16);
            this.lblTotalCostTitle.TabIndex = 1;
            this.lblTotalCostTitle.Text = "Total Payroll Cost (₱)";
            // 
            // tblSubSummary
            // 
            this.tblSubSummary.ColumnCount = 3;
            this.tblSubSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblSubSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblSubSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblSubSummary.Controls.Add(this.panelOutstanding, 0, 0);
            this.tblSubSummary.Controls.Add(this.panelSales, 1, 0);
            this.tblSubSummary.Controls.Add(this.panelAvg, 2, 0);
            this.tblSubSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblSubSummary.Location = new System.Drawing.Point(20, 230);
            this.tblSubSummary.Name = "tblSubSummary";
            this.tblSubSummary.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tblSubSummary.RowCount = 1;
            this.tblSubSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSubSummary.Size = new System.Drawing.Size(1437, 55);
            this.tblSubSummary.TabIndex = 1;
            // 
            // panelOutstanding
            // 
            this.panelOutstanding.Controls.Add(this.lblOutstandingValue);
            this.panelOutstanding.Controls.Add(this.lblOutstandingTitle);
            this.panelOutstanding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutstanding.Location = new System.Drawing.Point(5, 10);
            this.panelOutstanding.Margin = new System.Windows.Forms.Padding(5);
            this.panelOutstanding.Name = "panelOutstanding";
            this.panelOutstanding.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutstanding.Size = new System.Drawing.Size(468, 40);
            this.panelOutstanding.TabIndex = 0;
            // 
            // lblOutstandingValue
            // 
            this.lblOutstandingValue.AutoSize = true;
            this.lblOutstandingValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOutstandingValue.Location = new System.Drawing.Point(0, 22);
            this.lblOutstandingValue.Name = "lblOutstandingValue";
            this.lblOutstandingValue.Size = new System.Drawing.Size(54, 20);
            this.lblOutstandingValue.TabIndex = 0;
            this.lblOutstandingValue.Text = "₱ 0.00";
            // 
            // lblOutstandingTitle
            // 
            this.lblOutstandingTitle.AutoSize = true;
            this.lblOutstandingTitle.Location = new System.Drawing.Point(0, 0);
            this.lblOutstandingTitle.Name = "lblOutstandingTitle";
            this.lblOutstandingTitle.Size = new System.Drawing.Size(146, 16);
            this.lblOutstandingTitle.TabIndex = 1;
            this.lblOutstandingTitle.Text = "Outstanding Payroll (₱):";
            // 
            // panelSales
            // 
            this.panelSales.Controls.Add(this.lblSalesValue);
            this.panelSales.Controls.Add(this.lblSalesTitle);
            this.panelSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSales.Location = new System.Drawing.Point(483, 10);
            this.panelSales.Margin = new System.Windows.Forms.Padding(5);
            this.panelSales.Name = "panelSales";
            this.panelSales.Padding = new System.Windows.Forms.Padding(5);
            this.panelSales.Size = new System.Drawing.Size(468, 40);
            this.panelSales.TabIndex = 1;
            // 
            // lblSalesValue
            // 
            this.lblSalesValue.AutoSize = true;
            this.lblSalesValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalesValue.Location = new System.Drawing.Point(0, 22);
            this.lblSalesValue.Name = "lblSalesValue";
            this.lblSalesValue.Size = new System.Drawing.Size(54, 20);
            this.lblSalesValue.TabIndex = 0;
            this.lblSalesValue.Text = "₱ 0.00";
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(142, 16);
            this.lblSalesTitle.TabIndex = 1;
            this.lblSalesTitle.Text = "Total Sales Today (₱):";
            // 
            // panelAvg
            // 
            this.panelAvg.Controls.Add(this.lblAvgAttendanceValue);
            this.panelAvg.Controls.Add(this.lblAvgAttendanceTitle);
            this.panelAvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAvg.Location = new System.Drawing.Point(961, 10);
            this.panelAvg.Margin = new System.Windows.Forms.Padding(5);
            this.panelAvg.Name = "panelAvg";
            this.panelAvg.Padding = new System.Windows.Forms.Padding(5);
            this.panelAvg.Size = new System.Drawing.Size(471, 40);
            this.panelAvg.TabIndex = 2;
            // 
            // lblAvgAttendanceValue
            // 
            this.lblAvgAttendanceValue.AutoSize = true;
            this.lblAvgAttendanceValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvgAttendanceValue.Location = new System.Drawing.Point(0, 22);
            this.lblAvgAttendanceValue.Name = "lblAvgAttendanceValue";
            this.lblAvgAttendanceValue.Size = new System.Drawing.Size(40, 20);
            this.lblAvgAttendanceValue.TabIndex = 0;
            this.lblAvgAttendanceValue.Text = "0.00";
            // 
            // lblAvgAttendanceTitle
            // 
            this.lblAvgAttendanceTitle.AutoSize = true;
            this.lblAvgAttendanceTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAvgAttendanceTitle.Name = "lblAvgAttendanceTitle";
            this.lblAvgAttendanceTitle.Size = new System.Drawing.Size(172, 16);
            this.lblAvgAttendanceTitle.TabIndex = 1;
            this.lblAvgAttendanceTitle.Text = "Average Attendance Score:";
            // 
            // tblMiddle
            // 
            this.tblMiddle.ColumnCount = 2;
            this.tblMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblMiddle.Controls.Add(this.panelChart, 0, 0);
            this.tblMiddle.Controls.Add(this.panelRecent, 1, 0);
            this.tblMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMiddle.Location = new System.Drawing.Point(20, 285);
            this.tblMiddle.Name = "tblMiddle";
            this.tblMiddle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tblMiddle.RowCount = 1;
            this.tblMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMiddle.Size = new System.Drawing.Size(1437, 310);
            this.tblMiddle.TabIndex = 0;
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.White;
            this.panelChart.Controls.Add(this.chartPayrollTrend);
            this.panelChart.Controls.Add(this.lblChartTitle);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(5, 15);
            this.panelChart.Margin = new System.Windows.Forms.Padding(5);
            this.panelChart.Name = "panelChart";
            this.panelChart.Padding = new System.Windows.Forms.Padding(10);
            this.panelChart.Size = new System.Drawing.Size(780, 290);
            this.panelChart.TabIndex = 0;
            // 
            // chartPayrollTrend
            // 
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartPayrollTrend.ChartAreas.Add(chartArea1);
            this.chartPayrollTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPayrollTrend.Location = new System.Drawing.Point(10, 26);
            this.chartPayrollTrend.Name = "chartPayrollTrend";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "NetPay";
            this.chartPayrollTrend.Series.Add(series1);
            this.chartPayrollTrend.Size = new System.Drawing.Size(760, 254);
            this.chartPayrollTrend.TabIndex = 0;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartTitle.Location = new System.Drawing.Point(10, 10);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(196, 16);
            this.lblChartTitle.TabIndex = 1;
            this.lblChartTitle.Text = "Monthly Payroll Trend (Net Pay)";
            // 
            // panelRecent
            // 
            this.panelRecent.BackColor = System.Drawing.Color.White;
            this.panelRecent.Controls.Add(this.dgvRecentPayroll);
            this.panelRecent.Controls.Add(this.lblRecentTitle);
            this.panelRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecent.Location = new System.Drawing.Point(795, 15);
            this.panelRecent.Margin = new System.Windows.Forms.Padding(5);
            this.panelRecent.Name = "panelRecent";
            this.panelRecent.Padding = new System.Windows.Forms.Padding(10);
            this.panelRecent.Size = new System.Drawing.Size(637, 290);
            this.panelRecent.TabIndex = 1;
            // 
            // dgvRecentPayroll
            // 
            this.dgvRecentPayroll.AllowUserToAddRows = false;
            this.dgvRecentPayroll.AllowUserToDeleteRows = false;
            this.dgvRecentPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentPayroll.ColumnHeadersHeight = 29;
            this.dgvRecentPayroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentPayroll.Location = new System.Drawing.Point(10, 26);
            this.dgvRecentPayroll.Name = "dgvRecentPayroll";
            this.dgvRecentPayroll.ReadOnly = true;
            this.dgvRecentPayroll.RowHeadersVisible = false;
            this.dgvRecentPayroll.RowHeadersWidth = 51;
            this.dgvRecentPayroll.Size = new System.Drawing.Size(617, 254);
            this.dgvRecentPayroll.TabIndex = 0;
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.AutoSize = true;
            this.lblRecentTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentTitle.Location = new System.Drawing.Point(10, 10);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(176, 16);
            this.lblRecentTitle.TabIndex = 1;
            this.lblRecentTitle.Text = "Recent Payroll Transactions";
            // 
            // DashboardOverviewControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.tblMiddle);
            this.Controls.Add(this.tblSubSummary);
            this.Controls.Add(this.tblSummaryRow);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.headerPanel);
            this.Name = "DashboardOverviewControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1477, 615);
            this.tblSummaryRow.ResumeLayout(false);
            this.cardEmployees.ResumeLayout(false);
            this.cardEmployees.PerformLayout();
            this.cardPresent.ResumeLayout(false);
            this.cardPresent.PerformLayout();
            this.cardPaidThisMonth.ResumeLayout(false);
            this.cardPaidThisMonth.PerformLayout();
            this.cardTotalPayroll.ResumeLayout(false);
            this.cardTotalPayroll.PerformLayout();
            this.tblSubSummary.ResumeLayout(false);
            this.panelOutstanding.ResumeLayout(false);
            this.panelOutstanding.PerformLayout();
            this.panelSales.ResumeLayout(false);
            this.panelSales.PerformLayout();
            this.panelAvg.ResumeLayout(false);
            this.panelAvg.PerformLayout();
            this.tblMiddle.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayrollTrend)).EndInit();
            this.panelRecent.ResumeLayout(false);
            this.panelRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPayroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
