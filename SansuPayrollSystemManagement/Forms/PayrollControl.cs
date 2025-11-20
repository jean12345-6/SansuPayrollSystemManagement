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

        private void PayrollControl_Load(object sender, EventArgs e)
        {
            try
            {
                LoadEmployeeFilter();
                LoadStatusFilter();
                LoadPayrollList();
                LoadSummaryCards();
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
                cboEmployee.DataSource = dt;
                cboEmployee.DisplayMember = "FullName";
                cboEmployee.ValueMember = "EmployeeID";
                cboEmployee.SelectedIndex = -1;
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

                // OPTIONAL search
                if (!string.IsNullOrWhiteSpace(txtSearchEmployee.Text))
                {
                    sql += " AND e.FullName LIKE @search";
                    parameters.Add(new MySqlParameter("@search", "%" + txtSearchEmployee.Text.Trim() + "%"));
                }

                // OPTIONAL status filter
                if (cboStatusFilter.SelectedIndex > 0)
                {
                    sql += " AND (CASE WHEN p.NetPay > 0 THEN 'Processed' WHEN p.NetPay = 0 THEN 'Pending' ELSE 'Error' END) = @status";
                    parameters.Add(new MySqlParameter("@status", cboStatusFilter.SelectedItem.ToString()));
                }

                // OPTIONAL date range filter
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
                MessageBox.Show("Error: " + ex.Message);
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
                if (dgvPayroll.Columns.Count <= 1)
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

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "PayrollID", HeaderText = "Payroll No." });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "Employee", HeaderText = "Employee" });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "PayPeriodStart", HeaderText = "Period Start" });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "PayPeriodEnd", HeaderText = "Period End" });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalPay", HeaderText = "Total Salary Amount" });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "NetPay", HeaderText = "Net Pay" });
            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status" });

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


        private void EnsureViewButton()
        {
            if (!dgvPayroll.Columns.Contains("btnView"))
            {
                DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn
                {
                    HeaderText = "Action",
                    Text = "View",
                    Name = "btnView",
                    UseColumnTextForButtonValue = true
                };
                dgvPayroll.Columns.Add(viewBtn);
            }
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
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(1100, 700),
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false
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
                decimal totalCost = Convert.ToDecimal(db.ExecuteScalar(
                    "SELECT IFNULL(SUM(TotalPay),0) FROM Payroll"));

                decimal totalSalary = Convert.ToDecimal(db.ExecuteScalar(
                    "SELECT IFNULL(SUM(NetPay),0) FROM Payroll"));

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
        //  FILTER EVENTS (SEARCH / STATUS / DATES)
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

        // ============================================================
        //  TOP BUTTONS
        // ============================================================
        private void btnComputePayroll_Click(object sender, EventArgs e)
        {
            // For now just re-loading list shows how things work.
            // Later you can add full computation logic here.
            LoadPayrollList();
            LoadSummaryCards();
            MessageBox.Show("Compute logic not implemented yet – this is a test hook.",
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
            // If this control is hosted inside Dashboard, the Dashboard
            // will usually handle navigation. Here we can just notify.
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
            int rows = _payrollData?.Rows.Count ?? 0;
            MessageBox.Show($"[Stub] Export to PDF for {rows} record(s).",
                            "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
