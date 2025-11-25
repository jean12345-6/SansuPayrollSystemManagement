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
        private string userRole = "employee";

        // ================== PAYROLL CONSTANTS ==================
        private const int RequiredHoursPerDay = 10;         // required hours/day
        private const int WorkingDaysPerMonth = 26;         // ONLY used if DailyRate is 0
        private const decimal OvertimeMultiplier = 1.25m;   // OT = 1.25 × hourly
        private const decimal LatePenaltyPerOccur = 50m;    // fixed penalty per late

        // Paging
        private DataTable _payrollData;
        private int _currentPage = 0;
        private const int PageSize = 10;

        public PayrollControl()
        {
            InitializeComponent();
        }

        public PayrollControl(string role)
        {
            InitializeComponent();
            userRole = role?.ToLower() ?? "employee";
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
                ApplyRoleRestrictions();

                cboEmployee.SelectedIndexChanged += cboEmployee_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Payroll page: " + ex.Message);
            }
        }

        // ============================================================
        //  ROLE-BASED UI
        // ============================================================
        private void ApplyRoleRestrictions()
        {
            bool isPowerUser =
                userRole == "admin" ||
                userRole == "administrator" ||
                userRole == "hr" ||
                userRole == "hr manager";

            if (!isPowerUser)
            {
                btnComputePayroll.Visible = false;
                btnSave.Visible = false;
                btnGeneratePayslip.Visible = false;
                btnExportExcel.Visible = false;
                btnExportPdf.Visible = false;
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
                // Non-critical
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

                // Employee filter
                if (cboEmployee.SelectedValue != null &&
                    int.TryParse(cboEmployee.SelectedValue.ToString(), out int empId) &&
                    empId > 0)
                {
                    sql += " AND p.EmployeeID = @empId";
                    parameters.Add(new MySqlParameter("@empId", empId));
                }

                // Search by name
                if (!string.IsNullOrWhiteSpace(txtSearchEmployee.Text))
                {
                    sql += " AND e.FullName LIKE @search";
                    parameters.Add(new MySqlParameter("@search", "%" + txtSearchEmployee.Text.Trim() + "%"));
                }

                // Status filter
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

            var viewBtn = new DataGridViewButtonColumn
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
        //  GRID EVENTS
        // ============================================================
        private void dgvPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPayroll.Columns[e.ColumnIndex].Name == "btnView")
            {
                int payrollId = Convert.ToInt32(
                    dgvPayroll.Rows[e.RowIndex].Cells["PayrollID"].Value);

                var details = new PayrollDetailsControl(payrollId);

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
            if (e.RowIndex < 0) return;
            if (dgvPayroll.Columns[e.ColumnIndex].Name != "Status" || e.Value == null) return;

            string status = e.Value.ToString();
            if (status == "Processed")
                e.CellStyle.ForeColor = Color.Green;
            else if (status == "Pending")
                e.CellStyle.ForeColor = Color.DarkOrange;
            else if (status == "Error")
                e.CellStyle.ForeColor = Color.Red;
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

                lblTotalCost.Text = FormatPeso(totalCost);
                lblSalaryPaid.Text = FormatPeso(totalSalary);
                lblBalance.Text = FormatPeso(balance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading summary: " + ex.Message);
            }
        }

        private string FormatPeso(decimal value)
        {
            return "₱ " + value.ToString("N2");
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
            if (!cboEmployee.Focused) return;
            LoadPayrollList();
        }

        // ============================================================
        //  COMPUTE PAYROLL  (USING AttendanceSummary)
        // ============================================================
        private void btnComputePayroll_Click(object sender, EventArgs e)
        {
            bool isPowerUser =
                userRole == "admin" ||
                userRole == "administrator" ||
                userRole == "hr" ||
                userRole == "hr manager";

            if (!isPowerUser)
            {
                MessageBox.Show("You do not have permission to compute payroll.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime periodStart = dtpStart.Value.Date;
            DateTime periodEnd = dtpEnd.Value.Date;

            if (periodStart > periodEnd)
            {
                MessageBox.Show("Start date cannot be after end date.",
                    "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"
                    SELECT 
                        e.EmployeeID,
                        e.FullName,
                        e.Salary,
                        e.DailyRate,
                        s.WorktimeActual,
                        s.LateTimes,
                        s.AbsenceDays,
                        s.OvertimeNormal,
                        s.OvertimeHoliday,
                        s.WorkdayNormalActual
                    FROM Employees e
                    LEFT JOIN AttendanceSummary s
                        ON e.EmployeeID = s.EmployeeID
                       AND s.PeriodStart = @ps
                       AND s.PeriodEnd   = @pe
                    WHERE 1 = 1";

                var parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@ps", periodStart),
                    new MySqlParameter("@pe", periodEnd)
                };

                if (cboEmployee.SelectedValue != null &&
                    int.TryParse(cboEmployee.SelectedValue.ToString(), out int filterEmpId) &&
                    filterEmpId > 0)
                {
                    sql += " AND e.EmployeeID = @empId";
                    parameters.Add(new MySqlParameter("@empId", filterEmpId));
                }

                DataTable summary = db.GetData(sql, parameters.ToArray());

                if (summary.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No AttendanceSummary records found for this period.\n" +
                        "Please import the biometric Excel (sheet 2,3,413) first.",
                        "Compute Payroll",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                int affected = 0;

                foreach (DataRow row in summary.Rows)
                {
                    int employeeId = Convert.ToInt32(row["EmployeeID"]);

                    // -------- Rates --------
                    decimal salary = row["Salary"] != DBNull.Value ? Convert.ToDecimal(row["Salary"]) : 0m;
                    decimal dbDailyRate = row["DailyRate"] != DBNull.Value ? Convert.ToDecimal(row["DailyRate"]) : 0m;

                    decimal dailyRate;
                    if (dbDailyRate > 0)
                        dailyRate = dbDailyRate;
                    else if (salary > 0 && WorkingDaysPerMonth > 0)
                        dailyRate = salary / WorkingDaysPerMonth;
                    else
                        dailyRate = 0m;

                    decimal hourlyRate = (RequiredHoursPerDay > 0)
                        ? dailyRate / RequiredHoursPerDay
                        : 0m;

                    // -------- AttendanceSummary metrics --------
                    decimal worktimeActual = row["WorktimeActual"] != DBNull.Value
                        ? Convert.ToDecimal(row["WorktimeActual"])
                        : 0m;

                    int lateTimes = row["LateTimes"] != DBNull.Value
                        ? Convert.ToInt32(row["LateTimes"])
                        : 0;

                    int absenceDays = row["AbsenceDays"] != DBNull.Value
                        ? Convert.ToInt32(row["AbsenceDays"])
                        : 0;

                    decimal overtimeNormal = row["OvertimeNormal"] != DBNull.Value
                        ? Convert.ToDecimal(row["OvertimeNormal"])
                        : 0m;

                    decimal overtimeHoliday = row["OvertimeHoliday"] != DBNull.Value
                        ? Convert.ToDecimal(row["OvertimeHoliday"])
                        : 0m;

                    string workdayStr = row["WorkdayNormalActual"] != DBNull.Value
                        ? row["WorkdayNormalActual"].ToString()
                        : string.Empty;

                    // -------- Days Worked --------
                    int daysWorked = 0;

                    if (!string.IsNullOrWhiteSpace(workdayStr))
                    {
                        string digitsOnly = new string(workdayStr.Where(char.IsDigit).ToArray());
                        if (int.TryParse(digitsOnly, out int parsed))
                            daysWorked = parsed;
                    }

                    if (daysWorked == 0 && RequiredHoursPerDay > 0)
                    {
                        daysWorked = (int)Math.Round(
                            worktimeActual / RequiredHoursPerDay,
                            MidpointRounding.AwayFromZero);
                    }

                    if (daysWorked < 0) daysWorked = 0;

                    // -------- Hours --------
                    decimal regularHours = daysWorked * RequiredHoursPerDay;
                    decimal overtimeHours = overtimeNormal + overtimeHoliday;

                    // -------- Pay --------
                    decimal basicSalary = dailyRate * daysWorked;
                    decimal overtimePay = overtimeHours * hourlyRate * OvertimeMultiplier;
                    decimal grossPay = basicSalary + overtimePay;

                    // -------- Deductions --------
                    decimal lateDeduction = lateTimes * LatePenaltyPerOccur;
                    decimal absenceDeduction = absenceDays * dailyRate;

                    // Government deductions – you can plug real formulas later
                    decimal sss = 0m;
                    decimal philHealth = 0m;
                    decimal pagIbig = 0m;

                    decimal totalDeductions =
                        sss + philHealth + pagIbig +
                        lateDeduction + absenceDeduction;

                    decimal netPay = grossPay - totalDeductions;
                    if (netPay < 0) netPay = 0m;

                    // -------- UPSERT into Payroll --------
                    object existingIdObj = db.ExecuteScalar(
                        @"SELECT PayrollID 
                          FROM Payroll
                          WHERE EmployeeID = @eid
                            AND PayPeriodStart = @ps
                            AND PayPeriodEnd   = @pe
                          LIMIT 1",
                        new MySqlParameter[]
                        {
                            new MySqlParameter("@eid", employeeId),
                            new MySqlParameter("@ps", periodStart),
                            new MySqlParameter("@pe", periodEnd)
                        });

                    if (existingIdObj != null && existingIdObj != DBNull.Value)
                    {
                        int payrollId = Convert.ToInt32(existingIdObj);

                        string updateSql = @"
                            UPDATE Payroll
                            SET RegularHours      = @rh,
                                OvertimeHours     = @oh,
                                DaysWorked        = @dw,
                                BasicSalary       = @bs,
                                OvertimePay       = @op,
                                GrossPay          = @gp,
                                SSS               = @sss,
                                PhilHealth        = @ph,
                                PagIbig           = @pi,
                                LateDeduction     = @late,
                                AbsenceDeduction  = @abs,
                                TotalDeductions   = @td,
                                TotalPay          = @tp,
                                Deductions        = @td,
                                NetPay            = @np
                            WHERE PayrollID = @pid";

                        affected += db.ExecuteNonQuery(updateSql,
                            new MySqlParameter[]
                            {
                                new MySqlParameter("@rh",   regularHours),
                                new MySqlParameter("@oh",   overtimeHours),
                                new MySqlParameter("@dw",   daysWorked),
                                new MySqlParameter("@bs",   basicSalary),
                                new MySqlParameter("@op",   overtimePay),
                                new MySqlParameter("@gp",   grossPay),
                                new MySqlParameter("@sss",  sss),
                                new MySqlParameter("@ph",   philHealth),
                                new MySqlParameter("@pi",   pagIbig),
                                new MySqlParameter("@late", lateDeduction),
                                new MySqlParameter("@abs",  absenceDeduction),
                                new MySqlParameter("@td",   totalDeductions),
                                new MySqlParameter("@tp",   grossPay),
                                new MySqlParameter("@np",   netPay),
                                new MySqlParameter("@pid",  payrollId)
                            });
                    }
                    else
                    {
                        string insertSql = @"
                            INSERT INTO Payroll
                            (
                                EmployeeID, PayPeriodStart, PayPeriodEnd,
                                RegularHours, OvertimeHours,
                                DaysWorked, BasicSalary, OvertimePay, GrossPay,
                                SSS, PhilHealth, PagIbig,
                                LateDeduction, AbsenceDeduction, TotalDeductions,
                                TotalPay, Deductions, NetPay
                            )
                            VALUES
                            (
                                @eid, @ps, @pe,
                                @rh, @oh,
                                @dw, @bs, @op, @gp,
                                @sss, @ph, @pi,
                                @late, @abs, @td,
                                @tp, @td, @np
                            )";

                        affected += db.ExecuteNonQuery(insertSql,
                            new MySqlParameter[]
                            {
                                new MySqlParameter("@eid",  employeeId),
                                new MySqlParameter("@ps",   periodStart),
                                new MySqlParameter("@pe",   periodEnd),
                                new MySqlParameter("@rh",   regularHours),
                                new MySqlParameter("@oh",   overtimeHours),
                                new MySqlParameter("@dw",   daysWorked),
                                new MySqlParameter("@bs",   basicSalary),
                                new MySqlParameter("@op",   overtimePay),
                                new MySqlParameter("@gp",   grossPay),
                                new MySqlParameter("@sss",  sss),
                                new MySqlParameter("@ph",   philHealth),
                                new MySqlParameter("@pi",   pagIbig),
                                new MySqlParameter("@late", lateDeduction),
                                new MySqlParameter("@abs",  absenceDeduction),
                                new MySqlParameter("@td",   totalDeductions),
                                new MySqlParameter("@tp",   grossPay),
                                new MySqlParameter("@np",   netPay)
                            });
                    }
                }

                LoadPayrollList();
                LoadSummaryCards();

                MessageBox.Show(
                    "Payroll computed from AttendanceSummary.\n" +
                    $"Employees processed: {summary.Rows.Count}\n" +
                    $"Database rows affected: {affected}.",
                    "Compute Payroll",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error computing payroll: " + ex.Message,
                    "Compute Payroll", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        //  OTHER BUTTONS
        // ============================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payroll data is already saved when you click COMPUTE.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGeneratePayslip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open a payroll row and click 'Print Payslip' in the details screen.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back to dashboard is handled by DashboardForm.",
                            "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============================================================
        //  EXPORT BUTTONS
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

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                Title = "Export Payroll List to PDF",
                FileName = $"Payroll_List_{DateTime.Now:yyyyMMdd}.pdf"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            PrintDocument pdfDoc = new PrintDocument
            {
                DocumentName = "Payroll List"
            };
            pdfDoc.DefaultPageSettings.Landscape = true;

            int left = 40;
            int top = 40;
            int rowHeight = 25;

            pdfDoc.PrinterSettings = new PrinterSettings
            {
                PrinterName = "Microsoft Print to PDF",
                PrintToFile = true,
                PrintFileName = saveDialog.FileName
            };

            pdfDoc.PrintPage += (s, ev) =>
            {
                Font headerFont = new Font("Arial", 18, FontStyle.Bold);
                Font colFont = new Font("Arial", 10, FontStyle.Bold);
                Font rowFont = new Font("Arial", 10);

                top = 40;

                ev.Graphics.DrawString("SANZU RESTAURANT — PAYROLL LIST",
                    headerFont, Brushes.Black, left, top);
                top += 40;

                int colLeft = left;
                foreach (DataColumn col in _payrollData.Columns)
                {
                    ev.Graphics.DrawString(col.ColumnName, colFont, Brushes.Black, colLeft, top);
                    colLeft += 140;
                }

                top += rowHeight + 5;

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
