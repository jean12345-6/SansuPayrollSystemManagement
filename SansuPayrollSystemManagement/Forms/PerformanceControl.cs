using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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

        // Paging
        private DataTable _data;
        private int _currentPage = 0;
        private const int PageSize = 10;

        public PerformanceControl()
        {
            InitializeComponent();
        }

        private void PerformanceControl_Load(object sender, EventArgs e)
        {
            LoadEmployeeFilter();
            LoadPerformanceList();
            UpdateTotalSales();
        }

        // =============================================================
        // LOAD EMPLOYEE FILTER
        // =============================================================
        private void LoadEmployeeFilter()
        {
            try
            {
                string sql = "SELECT EmployeeID, FullName FROM Employees ORDER BY FullName";
                DataTable dt = db.GetData(sql);

                DataRow row = dt.NewRow();
                row["EmployeeID"] = 0;
                row["FullName"] = "All Employees";
                dt.Rows.InsertAt(row, 0);

                cboEmployee.DataSource = dt;
                cboEmployee.DisplayMember = "FullName";
                cboEmployee.ValueMember = "EmployeeID";
            }
            catch { }
        }

        // =============================================================
        // LOAD PERFORMANCE LIST (with filters)
        // =============================================================
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
                        (p.FeedbackScore + p.AttendanceScore + (p.Sales / 100)) AS TotalScore
                    FROM Performance p
                    JOIN Employees e ON p.EmployeeID = e.EmployeeID
                    WHERE 1 = 1
                ";

                List<MySqlParameter> prms = new List<MySqlParameter>();

                // Employee filter
                if (cboEmployee.SelectedValue != null &&
                    int.TryParse(cboEmployee.SelectedValue.ToString(), out int empId) &&
                    empId != 0)
                {
                    sql += " AND p.EmployeeID = @emp";
                    prms.Add(new MySqlParameter("@emp", empId));
                }

                // Date filter
                sql += " AND DATE(p.Date) = @date";
                prms.Add(new MySqlParameter("@date", dtpDate.Value.Date));

                sql += " ORDER BY p.Date DESC";

                _data = db.GetData(sql, prms.ToArray());

                _currentPage = 0;
                BindGridPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading performance: {ex.Message}");
            }
        }

        // =============================================================
        // BIND PAGED RESULTS
        // =============================================================
        private void BindGridPage()
        {
            dgvPerformance.Columns.Clear();
            DefineGridColumns();

            if (_data == null || _data.Rows.Count == 0)
            {
                dgvPerformance.DataSource = null;
                lblPageInfo.Text = "No records";
                lblTotalSales.Text = "Total Sales: ₱0.00";
                return;
            }

            int totalRows = _data.Rows.Count;
            int totalPages = (int)Math.Ceiling(totalRows / (double)PageSize);

            _currentPage = Math.Max(0, Math.Min(_currentPage, totalPages - 1));

            var pageRows = _data.AsEnumerable()
                                .Skip(_currentPage * PageSize)
                                .Take(PageSize);

            dgvPerformance.DataSource = pageRows.CopyToDataTable();

            lblPageInfo.Text = $"Page {_currentPage + 1} of {totalPages}";
        }

        // =============================================================
        // DEFINE COLUMNS
        // =============================================================
        private void DefineGridColumns()
        {
            dgvPerformance.AutoGenerateColumns = false;

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EmployeeName",
                HeaderText = "Employee Name",
                Width = 200
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "Date",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sales",
                HeaderText = "Sales",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FeedbackScore",
                HeaderText = "Feedback",
                Width = 120
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AttendanceScore",
                HeaderText = "Attendance",
                Width = 120
            });

            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalScore",
                HeaderText = "Total Score",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            // Status column (computed)
            dgvPerformance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                Width = 120
            });

            // View button
            DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Name = "btnView",
                Text = "View",
                UseColumnTextForButtonValue = true
            };
            dgvPerformance.Columns.Add(viewBtn);

            dgvPerformance.CellFormatting += DgvPerformance_CellFormatting;
        }

        // =============================================================
        // STATUS COLOR + COMPUTATION
        // =============================================================
        private void DgvPerformance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPerformance.Columns[e.ColumnIndex].Name == "Status")
            {
                double score = Convert.ToDouble(dgvPerformance.Rows[e.RowIndex].Cells["TotalScore"].Value);

                string status =
                    score >= 85 ? "Excellent" :
                    score >= 70 ? "Good" :
                    score >= 50 ? "Average" :
                    "Poor";

                e.Value = status;
                e.CellStyle.ForeColor =
                    status == "Excellent" ? Color.Green :
                    status == "Good" ? Color.SeaGreen :
                    status == "Average" ? Color.DarkOrange :
                    Color.Red;
            }
        }

        // =============================================================
        // PAGING
        // =============================================================
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 0)
            {
                _currentPage--;
                BindGridPage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling(_data.Rows.Count / (double)PageSize);
            if (_currentPage < totalPages - 1)
            {
                _currentPage++;
                BindGridPage();
            }
        }

        // =============================================================
        // VIEW BUTTON
        // =============================================================
        private void dgvPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPerformance.Columns[e.ColumnIndex].Name != "btnView") return;

            int performanceId = Convert.ToInt32(_data.Rows[e.RowIndex]["PerformanceID"]);

            MessageBox.Show($"Open PERFORMANCE DETAILS for ID: {performanceId}",
                "View", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Later:
            // PerformanceDetailsControl details = new PerformanceDetailsControl(performanceId);
            // Show popup
        }

        // =============================================================
        // EXPORT
        // =============================================================
        private void btnExport_Click(object sender, EventArgs e)
        {
            int rows = _data?.Rows.Count ?? 0;
            MessageBox.Show($"[Stub] Export performance list ({rows} rows).",
                "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =============================================================
        // TOTAL SALES DISPLAY
        // =============================================================
        private void UpdateTotalSales()
        {
            try
            {
                string sql = "SELECT IFNULL(SUM(Sales),0) FROM Performance";
                decimal total = Convert.ToDecimal(db.ExecuteScalar(sql));
                lblTotalSales.Text = $"Total Sales: ₱{total:N2}";
            }
            catch { }
        }
    }
}
