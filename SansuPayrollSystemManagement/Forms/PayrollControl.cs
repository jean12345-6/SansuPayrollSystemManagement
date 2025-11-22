using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class PayrollControl : UserControl
    {
        private readonly DBHelper db = new DBHelper();

        // Paging
        private DataTable _payrollData;
        private int _currentPage = 0;
        private const int PageSize = 10;

        public PayrollControl()
        {
            InitializeComponent();
        }

        // ============================================================
        //  LOAD
        // ============================================================
        private void PayrollControl_Load(object sender, EventArgs e)
        {
            try
            {
                // Default date range: current month
                dtpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtpEnd.Value = DateTime.Today;

                LoadEmployeeFilter();
                LoadStatusFilter();
                LoadPayrollList();
                LoadSummaryCards();

                // React to employee change
                cboEmployee.SelectedIndexChanged += cboEmployee_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Payroll page: " + ex.Message);
            }
        }

        // ============================================================
        //  FILTER DROPDOWNS
        // ============================================================
        private void LoadEmployeeFilter()
        {
            try
            {
                string sql = "SELECT EmployeeID, FullName FROM Employees ORDER BY FullName";
                DataTable dt = db.GetData(sql);

                // Insert "All Employees" at top
                DataRow allRow = dt.NewRow();
                allRow["EmployeeID"] = 0;
                allRow["FullName"] = "All Employees";
                dt.Rows.InsertAt(allRow, 0);

                cboEmployee.DataSource = dt;
                cboEmployee.DisplayMember = "FullName";
                cboEmployee.ValueMember = "EmployeeID";
                cboEmployee.SelectedIndex = 0;  // default: All Employees
            }
            catch
            {
                // non-critical: ignore if fails, page still works
            }
        }

        private void LoadStatusFilter()
        {
            cboStatusFilter.Items.Clear();
            cboStatusFilter.Items.Add("All");
            cboStatusFilter.Items.Add("Processed");
            cboStatusFilter.Items.Add("Pending");
            cboStatusFilter.Items.Add("Error");
            cboStatusFilter.SelectedIndex = 0;
        }

        // ============================================================
        //  LOAD PAYROLL LIST (WITH FILTERS)
        // ============================================================
        private void LoadPayrollList()
        {
            try
            {
                string sql = @"
                    SELECT 
                        p.PayrollID,
                        e.FullName AS Employee,
                        p.PayPeriodStart,
                        p.PayPeriodEnd,
                        p.TotalPay,
                        p.NetPay,
                        CASE 
                            WHEN p.NetPay > 0 THEN 'Processed'
                            WHEN p.NetPay = 0 THEN 'Pending'
                            ELSE 'Error'
                        END AS Status
                    FROM Payroll p
                    JOIN Employees e ON p.EmployeeID = e.EmployeeID
                    WHERE 1 = 1";

                var parameters = new List<MySqlParameter>();

                // Employee filter (0 = All Employees)
                if (cboEmployee.SelectedValue != null &&
                    int.TryParse(cboEmployee.SelectedValue.ToString(), out int empId) &&
                    empId > 0)
                {
                    sql += " AND p.EmployeeID = @empId";
                    parameters.Add(new MySqlParameter("@empId", empId));
                }

                // OPTIONAL search by employee name
                if (!string.IsNullOrWhiteSpace(txtSearchEmployee.Text))
                {
                    sql += " AND e.FullName LIKE @search";
                    parameters.Add(new MySqlParameter("@search", "%" + txtSearchEmployee.Text.Trim() + "%"));
                }

                // OPTIONAL status filter
                if (cboStatusFilter.SelectedIndex > 0)
                {
                    sql += @" AND (CASE 
                                      WHEN p.NetPay > 0 THEN 'Processed'
                                      WHEN p.NetPay = 0 THEN 'Pending'
                                      ELSE 'Error'
                                   END) = @status";
                    parameters.Add(new MySqlParameter("@status", cboStatusFilter.SelectedItem.ToString()));
                }

                // Date range filter
                DateTime s = dtpStart.Value.Date;
                DateTime e = dtpEnd.Value.Date;

                if (s <= e)
                {
                    sql += " AND p.PayPeriodStart >= @s AND p.PayPeriodEnd <= @e";
                    parameters.Add(new MySqlParameter("@s", s));
                    parameters.Add(new MySqlParameter("@e", e));
                }

                sql += " ORDER BY p.PayrollID DESC";

                _payrollData = db.GetData(sql, parameters.ToArray());

                _currentPage = 0;
                BindPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payroll list: " + ex.Message);
            }
        }

        // ============================================================
        //  PAGING
        // ============================================================
        private void BindPage()
        {
            try
            {
                dgvPayroll.AutoGenerateColumns = false;

                // If grid has no columns, define them once
                if (dgvPayroll.Columns.Count == 0)
                    DefineGridColumns();

                if (_payrollData == null || _payrollData.Rows.Count == 0)
                {
                    dgvPayroll.DataSource = null;
                    lblPageInfo.Text = "No records";
                    return;
                }

                int totalRows = _payrollData.Rows.Count;
                int totalPages = (int)Math.Ceiling(totalRows / (double)PageSize);

                if (_currentPage >= totalPages) _currentPage = totalPages - 1;
                if (_currentPage < 0) _currentPage = 0;

                var pageRows = _payrollData.AsEnumerable()
                                           .Skip(_currentPage * PageSize)
                                           .Take(PageSize);

                dgvPayroll.DataSource = pageRows.Any() ? pageRows.CopyToDataTable() : null;

                lblPageInfo.Text = $"Page {_currentPage + 1} of {totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Page error: " + ex.Message);
            }
        }

        private void DefineGridColumns()
        {
            dgvPayroll.Columns.Clear();

            // Text columns with DataPropertyName matching SQL SELECT aliases
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PayrollID",
                HeaderText = "Payroll No.",
                DataPropertyName = "PayrollID",
                ReadOnly = true
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Employee",
                HeaderText = "Employee",
                DataPropertyName = "Employee",
                ReadOnly = true
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PayPeriodStart",
                HeaderText = "Period Start",
                DataPropertyName = "PayPeriodStart",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PayPeriodEnd",
                HeaderText = "Period End",
                DataPropertyName = "PayPeriodEnd",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPay",
                HeaderText = "Total Salary Amount",
                DataPropertyName = "TotalPay",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NetPay",
                HeaderText = "Net Pay",
                DataPropertyName = "NetPay",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                ReadOnly = true
            });

            // View button
            DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Text = "View",
                Name = "btnView",
                UseColumnTextForButtonValue = true
            };
            dgvPayroll.Columns.Add(viewBtn);
        }


        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_payrollData == null) return;

            int totalRows = _payrollData.Rows.Count;
            int totalPages = (int)Math.Ceiling(totalRows / (double)PageSize);

            if (_currentPage < totalPages - 1)
            {
                _currentPage++;
                BindPage();
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (_payrollData == null) return;

            if (_currentPage > 0)
            {
                _currentPage--;
                BindPage();
            }
        }

        // ============================================================
        //  GRID EVENTS (VIEW BUTTON + STATUS COLOR)
        // ============================================================
        private void dgvPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPayroll.Columns[e.ColumnIndex].Name == "btnView")
            {
                int payrollId = Convert.ToInt32(dgvPayroll.Rows[e.RowIndex].Cells["PayrollID"].Value);

                PayrollDetailsControl details = new PayrollDetailsControl(payrollId);

                Form popup = new Form
                {
                    Text = "Payroll Details",
                    StartPosition = FormStartPosition.CenterScreen,
                    WindowState = FormWindowState.Maximized,
                    BackColor = Color.White
                };

                details.Dock = DockStyle.Fill;
                popup.Controls.Add(details);
                popup.ShowDialog();
            }
        }
       

        private void dgvPayroll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPayroll.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Processed")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (status == "Pending")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                }
                else if (status == "Error")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        // ============================================================
        //  SUMMARY CARDS
        // ============================================================
        private void LoadSummaryCards()
        {
            try
            {
                decimal totalCost = Convert.ToDecimal(
                    db.ExecuteScalar("SELECT IFNULL(SUM(TotalPay),0) FROM Payroll"));

                decimal totalSalary = Convert.ToDecimal(
                    db.ExecuteScalar("SELECT IFNULL(SUM(NetPay),0) FROM Payroll"));

                decimal balance = totalCost - totalSalary;

                lblTotalCost.Text = totalCost.ToString("C");
                lblSalaryPaid.Text = totalSalary.ToString("C");
                lblBalance.Text = balance.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading summary: " + ex.Message);
            }
        }

        // ============================================================
        //  FILTER EVENTS
        // ============================================================
        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadPayrollList();
        }

        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayrollList();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value.Date > dtpEnd.Value.Date)
                dtpEnd.Value = dtpStart.Value.Date;

            LoadPayrollList();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value.Date < dtpStart.Value.Date)
                dtpStart.Value = dtpEnd.Value.Date;

            LoadPayrollList();
        }

        private void cboEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avoid reloading while control is still binding during Load()
            if (!cboEmployee.Focused) return;
            LoadPayrollList();
        }

        // ============================================================
        //  TOP BUTTONS
        // ============================================================
        private void btnComputePayroll_Click(object sender, EventArgs e)
        {
            // Placeholder – later this will compute + save payroll rows.
            LoadPayrollList();
            LoadSummaryCards();

            MessageBox.Show("Compute logic not implemented yet – using test data.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save payroll logic will go here.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGeneratePayslip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generate payslip logic will go here.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigation is usually handled by the parent Dashboard.
            MessageBox.Show("Return to dashboard (handled by parent form).",
                            "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============================================================
        //  EXPORT STUBS
        // ============================================================
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            int rows = _payrollData?.Rows.Count ?? 0;
            MessageBox.Show($"[Stub] Export to Excel for {rows} record(s).",
                            "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (_payrollData == null || _payrollData.Rows.Count == 0)
            {
                MessageBox.Show("There is no payroll data to export.",
                    "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Setup Save Dialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF File|*.pdf";
            saveDialog.Title = "Export Payroll List to PDF";
            saveDialog.FileName = $"Payroll_List_{DateTime.Now:yyyyMMdd}.pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            PrintDocument pdfDoc = new PrintDocument();
            pdfDoc.DocumentName = "Payroll List";
            pdfDoc.DefaultPageSettings.Landscape = true;

            int left = 40;
            int top = 40;
            int rowHeight = 25;

            // Use Microsoft Print to PDF
            pdfDoc.PrinterSettings = new PrinterSettings()
            {
                PrinterName = "Microsoft Print to PDF",
                PrintToFile = true,
                PrintFileName = saveDialog.FileName
            };

            // PRINT PAGE EVENT
            pdfDoc.PrintPage += (s, ev) =>
            {
                Font headerFont = new Font("Arial", 18, FontStyle.Bold);
                Font colFont = new Font("Arial", 10, FontStyle.Bold);
                Font rowFont = new Font("Arial", 10);

                // Header
                ev.Graphics.DrawString("SANZU RESTAURANT — PAYROLL LIST",
                    headerFont, Brushes.Black, left, top);
                top += 40;

                // Column headers
                int colLeft = left;
                foreach (DataColumn col in _payrollData.Columns)
                {
                    ev.Graphics.DrawString(col.ColumnName, colFont, Brushes.Black, colLeft, top);
                    colLeft += 140;
                }

                top += rowHeight + 5;

                // Rows
                foreach (DataRow row in _payrollData.Rows)
                {
                    colLeft = left;

                    foreach (DataColumn col in _payrollData.Columns)
                    {
                        string text = row[col].ToString();
                        ev.Graphics.DrawString(text, rowFont, Brushes.Black, colLeft, top);
                        colLeft += 140;
                    }

                    top += rowHeight;

                    // Page overflow handling
                    if (top > ev.MarginBounds.Bottom - 50)
                    {
                        ev.HasMorePages = true;
                        top = 40;
                        return;
                    }
                }

                ev.HasMorePages = false;
            };

            pdfDoc.Print();

            MessageBox.Show("PDF exported successfully!",
                "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
