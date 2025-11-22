using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class PerformanceControl : UserControl
    {
        private readonly DBHelper db = new DBHelper();

        private DataTable _performanceData;
        private int _currentPage = 0;
        private const int PageSize = 10;

        public PerformanceControl()
        {
            InitializeComponent();
        }

        private void PerformanceControl_Load(object sender, EventArgs e)
        {
            try
            {
                // Default: current month
                dtpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtpEnd.Value = DateTime.Today;

                LoadEmployeeFilter();
                LoadStatusFilter();
                LoadPerformanceList();
                LoadSummaryCards();

                cboEmployee.SelectedIndexChanged += cboEmployee_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Performance page: " + ex.Message);
            }
        }

        // ====================================================
        // Filters
        // ====================================================
        private void LoadEmployeeFilter()
        {
            try
            {
                string sql = "SELECT EmployeeID, FullName FROM Employees ORDER BY FullName";
                DataTable dt = db.GetData(sql);

                DataRow allRow = dt.NewRow();
                allRow["EmployeeID"] = 0;
                allRow["FullName"] = "All Employees";
                dt.Rows.InsertAt(allRow, 0);

                cboEmployee.DataSource = dt;
                cboEmployee.DisplayMember = "FullName";
                cboEmployee.ValueMember = "EmployeeID";
                cboEmployee.SelectedIndex = 0;
            }
            catch
            {
                // non-critical
            }
        }

        private void LoadStatusFilter()
        {
            cboStatusFilter.Items.Clear();
            cboStatusFilter.Items.Add("All");
            cboStatusFilter.Items.Add("Excellent");
            cboStatusFilter.Items.Add("Good");
            cboStatusFilter.Items.Add("Average");
            cboStatusFilter.Items.Add("Needs Improvement");
            cboStatusFilter.SelectedIndex = 0;
        }

        // ====================================================
        // Load Performance list
        // ====================================================
        private void LoadPerformanceList()
        {
            try
            {
                string sql = @"
                    SELECT
                        p.PerformanceID,
                        e.FullName AS EmployeeName,
                        p.Date,
                        p.Sales,
                        p.FeedbackScore,
                        p.AttendanceScore,
                        ROUND((IFNULL(p.FeedbackScore,0) + IFNULL(p.AttendanceScore,0)) / 2, 2) AS TotalScore,
                        CASE
                            WHEN (IFNULL(p.FeedbackScore,0) + IFNULL(p.AttendanceScore,0)) / 2 >= 4.5 THEN 'Excellent'
                            WHEN (IFNULL(p.FeedbackScore,0) + IFNULL(p.AttendanceScore,0)) / 2 >= 3.5 THEN 'Good'
                            WHEN (IFNULL(p.FeedbackScore,0) + IFNULL(p.AttendanceScore,0)) / 2 >= 2.5 THEN 'Average'
                            ELSE 'Needs Improvement'
                        END AS Status
                    FROM Performance p
                    JOIN Employees e ON p.EmployeeID = e.EmployeeID
                    WHERE 1 = 1";

                var parameters = new List<MySqlParameter>();

                // Employee filter (0 = All)
                if (cboEmployee.SelectedValue != null &&
                    int.TryParse(cboEmployee.SelectedValue.ToString(), out int empId) &&
                    empId > 0)
                {
                    sql += " AND p.EmployeeID = @empId";
                    parameters.Add(new MySqlParameter("@empId", empId));
                }

                // Search name
                if (!string.IsNullOrWhiteSpace(txtSearchEmployee.Text))
                {
                    sql += " AND e.FullName LIKE @search";
                    parameters.Add(new MySqlParameter("@search", "%" + txtSearchEmployee.Text.Trim() + "%"));
                }

                // Status filter
                if (cboStatusFilter.SelectedIndex > 0)
                {
                    sql += @" HAVING Status = @status";
                    parameters.Add(new MySqlParameter("@status", cboStatusFilter.SelectedItem.ToString()));
                }

                // Date range
                DateTime s = dtpStart.Value.Date;
                DateTime e = dtpEnd.Value.Date;
                if (s <= e)
                {
                    sql += " AND p.Date BETWEEN @s AND @e";
                    parameters.Add(new MySqlParameter("@s", s));
                    parameters.Add(new MySqlParameter("@e", e));
                }

                sql += " ORDER BY p.Date DESC, e.FullName ASC";

                _performanceData = db.GetData(sql, parameters.ToArray());
                _currentPage = 0;
                BindPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading performance list: " + ex.Message);
            }
        }

        // ====================================================
        // Paging
        // ====================================================
        private void BindPage()
        {
            try
            {
                dgvPerformance.AutoGenerateColumns = false;

                if (dgvPerformance.Columns.Count == 0)
                    DefineGridColumns();

                if (_performanceData == null || _performanceData.Rows.Count == 0)
                {
                    dgvPerformance.DataSource = null;
                    lblPageInfo.Text = "No records";
                    return;
                }

                int totalRows = _performanceData.Rows.Count;
                int totalPages = (int)Math.Ceiling(totalRows / (double)PageSize);

                if (_currentPage >= totalPages) _currentPage = totalPages - 1;
                if (_currentPage < 0) _currentPage = 0;

                var pageRows = _performanceData.AsEnumerable()
                    .Skip(_currentPage * PageSize)
                    .Take(PageSize);

                dgvPerformance.DataSource = pageRows.Any()
                    ? pageRows.CopyToDataTable()
                    : null;

                lblPageInfo.Text = $"Page {_currentPage + 1} of {totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Page error: " + ex.Message);
            }
        }

        private void DefineGridColumns()
        {
            dgvPerformance.Columns.Clear();

            // Hidden ID (used when viewing details)
            var colId = new DataGridViewTextBoxColumn
            {
                Name = "PerformanceID",
                HeaderText = "ID",
                DataPropertyName = "PerformanceID",
                Visible = false
            };
            dgvPerformance.Columns.Add(colId);

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeName",
                HeaderText = "Employee Name",
                DataPropertyName = "EmployeeName",
                ReadOnly = true
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Date",
                HeaderText = "Date",
                DataPropertyName = "Date",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sales",
                HeaderText = "Sales",
                DataPropertyName = "Sales",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FeedbackScore",
                HeaderText = "Feedback Score",
                DataPropertyName = "FeedbackScore",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N1" }
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AttendanceScore",
                HeaderText = "Attendance Score",
                DataPropertyName = "AttendanceScore",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N1" }
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalScore",
                HeaderText = "Total Score",
                DataPropertyName = "TotalScore",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                ReadOnly = true
            });

            var viewBtn = new DataGridViewButtonColumn
            {
                Name = "btnView",
                HeaderText = "Action",
                Text = "View",
                UseColumnTextForButtonValue = true
            };
            dgvPerformance.Columns.Add(viewBtn);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_performanceData == null) return;

            int totalRows = _performanceData.Rows.Count;
            int totalPages = (int)Math.Ceiling(totalRows / (double)PageSize);

            if (_currentPage < totalPages - 1)
            {
                _currentPage++;
                BindPage();
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (_performanceData == null) return;

            if (_currentPage > 0)
            {
                _currentPage--;
                BindPage();
            }
        }

        // ====================================================
        // Grid events
        // ====================================================
        private void dgvPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPerformance.Columns[e.ColumnIndex].Name == "btnView")
            {
                int id = Convert.ToInt32(
                    dgvPerformance.Rows[e.RowIndex].Cells["PerformanceID"].Value);

                string employee = dgvPerformance.Rows[e.RowIndex].Cells["EmployeeName"].Value?.ToString();
                string date = Convert.ToDateTime(
                    dgvPerformance.Rows[e.RowIndex].Cells["Date"].Value).ToString("dd MMM yyyy");
                string sales = dgvPerformance.Rows[e.RowIndex].Cells["Sales"].Value?.ToString();
                string fb = dgvPerformance.Rows[e.RowIndex].Cells["FeedbackScore"].Value?.ToString();
                string att = dgvPerformance.Rows[e.RowIndex].Cells["AttendanceScore"].Value?.ToString();
                string total = dgvPerformance.Rows[e.RowIndex].Cells["TotalScore"].Value?.ToString();
                string status = dgvPerformance.Rows[e.RowIndex].Cells["Status"].Value?.ToString();

                MessageBox.Show(
                    $"Employee: {employee}\n" +
                    $"Date: {date}\n" +
                    $"Sales: {sales}\n" +
                    $"Feedback: {fb}\n" +
                    $"Attendance: {att}\n" +
                    $"Total Score: {total}\n" +
                    $"Status: {status}",
                    "Performance Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void dgvPerformance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPerformance.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Excellent")
                    e.CellStyle.ForeColor = Color.Green;
                else if (status == "Good")
                    e.CellStyle.ForeColor = Color.DarkBlue;
                else if (status == "Average")
                    e.CellStyle.ForeColor = Color.DarkOrange;
                else
                    e.CellStyle.ForeColor = Color.Red;
            }
        }

        // ====================================================
        // Summary cards
        // ====================================================
        private void LoadSummaryCards()
        {
            try
            {
                decimal totalSales = Convert.ToDecimal(
                    db.ExecuteScalar("SELECT IFNULL(SUM(Sales),0) FROM Performance"));

                decimal avgFeedback = Convert.ToDecimal(
                    db.ExecuteScalar("SELECT IFNULL(AVG(FeedbackScore),0) FROM Performance"));

                decimal avgAttendance = Convert.ToDecimal(
                    db.ExecuteScalar("SELECT IFNULL(AVG(AttendanceScore),0) FROM Performance"));

                lblTotalSales.Text = totalSales.ToString("N2");
                lblAvgFeedback.Text = avgFeedback.ToString("N2");
                lblAvgAttendance.Text = avgAttendance.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading performance summary: " + ex.Message);
            }
        }

        // ====================================================
        // Filter events
        // ====================================================
        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadPerformanceList();
        }

        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPerformanceList();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value.Date > dtpEnd.Value.Date)
                dtpEnd.Value = dtpStart.Value.Date;

            LoadPerformanceList();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value.Date < dtpStart.Value.Date)
                dtpStart.Value = dtpEnd.Value.Date;

            LoadPerformanceList();
        }

        private void cboEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboEmployee.Focused) return;
            LoadPerformanceList();
        }

        // ====================================================
        // Export stub
        // ====================================================
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            int rows = _performanceData?.Rows.Count ?? 0;
            MessageBox.Show($"[Stub] Export performance to PDF for {rows} record(s).",
                "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
