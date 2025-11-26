using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using SansuPayrollSystemManagement;
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
        private string userRole = "employee";

        private const int RequiredHoursPerDay = 10;
        private const decimal SSS_RATE = 540m;
        private const decimal PH_RATE = 298m;
        private const decimal PAGIBIG_RATE = 200m;
        private const decimal LatePenalty = 50m;

        private DataTable _payrollData;
        private int _currentPage = 0;
        private const int PageSize = 10;

        public PayrollControl()
        {
            InitializeComponent();
        }

        public PayrollControl(string role) : this()
        {
            userRole = role?.ToLower() ?? "employee";
        }

        private void PayrollControl_Load(object sender, EventArgs e)
        {
            dtpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEnd.Value = DateTime.Today;

            LoadEmployeeFilter();
            LoadStatusFilter();
            LoadPayrollList();
            ApplyRoleRestrictions();
        }

        // ===================== ROLE RESTRICTIONS ======================
        private bool IsPowerUser()
        {
            return userRole == "admin" || userRole == "hr" || userRole == "administrator";
        }

        private void ApplyRoleRestrictions()
        {
            if (!IsPowerUser())
            {
                btnComputePayroll.Visible = false;
                btnSave.Visible = false;
                btnExportExcel.Visible = false;
                btnExportPdf.Visible = false;
            }
        }

        // ===================== FILTERS ======================
        private void LoadEmployeeFilter()
        {
            DataTable dt = db.GetData("SELECT EmployeeID, FullName FROM Employees ORDER BY FullName");

            DataRow all = dt.NewRow();
            all["EmployeeID"] = 0;
            all["FullName"] = "All Employees";
            dt.Rows.InsertAt(all, 0);

            cboEmployee.DataSource = dt;
            cboEmployee.DisplayMember = "FullName";
            cboEmployee.ValueMember = "EmployeeID";
        }

        private void LoadStatusFilter()
        {
            cboStatusFilter.Items.Clear();
            cboStatusFilter.Items.Add("All");
            cboStatusFilter.Items.Add("Processed");
            cboStatusFilter.Items.Add("Pending");
            cboStatusFilter.SelectedIndex = 0;
        }

        // ===================== LOAD LATEST PAYROLL ONLY ======================
        private void LoadPayrollList()
        {
            string sql = @"
        SELECT 
            p.PayrollID,
            e.FullName AS Employee,
            p.PayPeriodStart,
            p.PayPeriodEnd,
            p.TotalPay,
            p.NetPay,
            CASE WHEN p.NetPay > 0 THEN 'Processed' ELSE 'Pending' END AS Status
        FROM Payroll p
        JOIN Employees e ON p.EmployeeID = e.EmployeeID
        WHERE 1 = 1
    ";

            List<MySqlParameter> prms = new List<MySqlParameter>();

            // Filter employee
            if (cboEmployee.SelectedValue != null &&
                int.TryParse(cboEmployee.SelectedValue.ToString(), out int empId) &&
                empId > 0)
            {
                sql += " AND p.EmployeeID=@empId";
                prms.Add(new MySqlParameter("@empId", empId));
            }

            // Search by name
            if (!string.IsNullOrWhiteSpace(txtSearchEmployee.Text))
            {
                sql += " AND e.FullName LIKE @search";
                prms.Add(new MySqlParameter("@search", "%" + txtSearchEmployee.Text.Trim() + "%"));
            }

            // Status filter
            if (cboStatusFilter.SelectedIndex > 0)
            {
                sql += " AND (CASE WHEN p.NetPay > 0 THEN 'Processed' ELSE 'Pending' END) = @stat";
                prms.Add(new MySqlParameter("@stat", cboStatusFilter.SelectedItem.ToString()));
            }

            // Date range
            sql += " AND p.PayPeriodStart >= @s AND p.PayPeriodEnd <= @e";
            prms.Add(new MySqlParameter("@s", dtpStart.Value.Date));
            prms.Add(new MySqlParameter("@e", dtpEnd.Value.Date));

            sql += " ORDER BY p.PayrollID DESC";

            // Load table
            _payrollData = db.GetData(sql, prms.ToArray());
            _currentPage = 0;
            BindPage();
        }

        // ===================== PAGING ======================
        private void BindPage()
        {
            try
            {
                dgvPayroll.AutoGenerateColumns = false;
                dgvPayroll.Columns.Clear();

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
            dgvPayroll.AutoGenerateColumns = false;

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PayrollID",
                HeaderText = "Payroll No.",
                DataPropertyName = "PayrollID",
                ReadOnly = true,
                Width = 120
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Employee",
                HeaderText = "Employee",
                DataPropertyName = "Employee",
                ReadOnly = true,
                Width = 220
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PayPeriodStart",
                HeaderText = "Period Start",
                DataPropertyName = "PayPeriodStart",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                Width = 150
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PayPeriodEnd",
                HeaderText = "Period End",
                DataPropertyName = "PayPeriodEnd",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                Width = 150
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPay",
                HeaderText = "Total Salary Amount",
                DataPropertyName = "TotalPay",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                Width = 170
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NetPay",
                HeaderText = "Net Pay",
                DataPropertyName = "NetPay",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                Width = 150
            });

            dgvPayroll.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                ReadOnly = true,
                Width = 120
            });

            var viewBtn = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Text = "View",
                Name = "btnView",
                UseColumnTextForButtonValue = true,
                Width = 120
            };
            dgvPayroll.Columns.Add(viewBtn);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _currentPage++;
            BindPage();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            _currentPage--;
            BindPage();
        }

        // ===================== COMPUTE PAYROLL ======================
        private void btnComputePayroll_Click(object sender, EventArgs e)
        {
            DateTime s = dtpStart.Value.Date;
            DateTime eDate = dtpEnd.Value.Date;

            // Load employees
            DataTable employees = db.GetData("SELECT EmployeeID, FullName, DailyRate FROM Employees");

            foreach (DataRow emp in employees.Rows)
            {
                int employeeId = Convert.ToInt32(emp["EmployeeID"]);
                decimal dailyRate = Convert.ToDecimal(emp["DailyRate"]);
                decimal hourlyRate = dailyRate / RequiredHoursPerDay;

                // Get attendance summary
                string sql = @"
            SELECT 
                COUNT(*) AS DaysWorked,
                SUM(
                    CASE WHEN TimeIn IS NOT NULL AND TimeOut IS NOT NULL
                    THEN TIMESTAMPDIFF(MINUTE, TimeIn, TimeOut) / 60.0
                    ELSE 0 END
                ) AS TotalHours,
                SUM(CASE WHEN Status='Late' THEN 1 ELSE 0 END) AS LateCount
            FROM Attendance
            WHERE EmployeeID=@eid AND Date BETWEEN @s AND @e";

                DataTable att = db.GetData(sql, new MySqlParameter[]
                {
            new MySqlParameter("@eid", employeeId),
            new MySqlParameter("@s", s),
            new MySqlParameter("@e", eDate)
                });

                int daysWorked = Convert.ToInt32(att.Rows[0]["DaysWorked"]);
                decimal totalHours = att.Rows[0]["TotalHours"] == DBNull.Value ? 0m : Convert.ToDecimal(att.Rows[0]["TotalHours"]);
                int lateTimes = att.Rows[0]["LateCount"] == DBNull.Value ? 0 : Convert.ToInt32(att.Rows[0]["LateCount"]);

                // Compute pay
                decimal basicSalary = daysWorked * dailyRate;

                decimal expectedHours = daysWorked * RequiredHoursPerDay;
                decimal overtimeHours = totalHours > expectedHours ? totalHours - expectedHours : 0m;

                decimal overtimePay = overtimeHours * hourlyRate * 1.25m;
                decimal grossPay = basicSalary + overtimePay;

                decimal lateDeduction = lateTimes * LatePenalty;

                // Government deductions
                decimal sss = SSS_RATE;
                decimal phil = PH_RATE;
                decimal pagibig = PAGIBIG_RATE;

                decimal totalDeductions = sss + phil + pagibig + lateDeduction;

                decimal netPay = grossPay - totalDeductions;
                if (netPay < 0) netPay = 0m;

                // UPDATE payroll row
                string update = @"
            UPDATE Payroll SET 
                TotalPay=@total,
                NetPay=@net,
                DaysWorked=@dw,
                GrossPay=@gross,
                OvertimeHours=@ot,
                BasicSalary=@basic,
                LateDeduction=@late,
                SSS=@sss,
                PhilHealth=@ph,
                PagIbig=@pi,
                Status = CASE WHEN @net > 0 THEN 'Processed' ELSE 'Pending' END
            WHERE EmployeeID=@eid AND PayPeriodStart=@ps AND PayPeriodEnd=@pe";

                db.ExecuteNonQuery(update, new MySqlParameter[]
                {
            new MySqlParameter("@total", grossPay),
            new MySqlParameter("@net", netPay),
            new MySqlParameter("@dw", daysWorked),
            new MySqlParameter("@gross", grossPay),
            new MySqlParameter("@ot", overtimeHours),
            new MySqlParameter("@basic", basicSalary),
            new MySqlParameter("@late", lateDeduction),
            new MySqlParameter("@sss", sss),
            new MySqlParameter("@ph", phil),
            new MySqlParameter("@pi", pagibig),
            new MySqlParameter("@eid", employeeId),
            new MySqlParameter("@ps", s),
            new MySqlParameter("@pe", eDate),
                });
            }

            MessageBox.Show("Payroll computed successfully!");
            LoadPayrollList();
        }


        // ===================== EVENT HANDLER STUBS (FIX DESIGNER ERRORS) ======================
        private void guna2Button1_Click(object sender, EventArgs e) { }
        private void dgvPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void btnSave_Click(object sender, EventArgs e) { }
        private void btnExportPdf_Click(object sender, EventArgs e) { }
        private void btnExportExcel_Click(object sender, EventArgs e) { }

        // ===================== FIXED LoadPage Navigation ======================
        private void btnIconEmployees_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm dash)
                dash.LoadPage(new EmployeeControl(userRole));
        }

        private void btnIconAttendance_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm dash)
                dash.LoadPage(new AttendanceControl(userRole));
        }

        private void btnIconPayroll_Click(object sender, EventArgs e) { }

        private void btnIconPerformance_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm dash)
                dash.LoadPage(new PerformanceControl(userRole));
        }

        private void btnIconSettings_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm dash)
                dash.LoadPage(new SettingsControl(userRole));
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadPayrollList();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
                dtpEnd.Value = dtpStart.Value;

            LoadPayrollList();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value < dtpStart.Value)
                dtpStart.Value = dtpEnd.Value;

            LoadPayrollList();
        }

        private void dgvPayroll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPayroll.Columns[e.ColumnIndex].Name != "Status") return;

            string status = e.Value?.ToString() ?? "";

            if (status == "Processed")
                e.CellStyle.ForeColor = Color.Green;
            else if (status == "Pending")
                e.CellStyle.ForeColor = Color.DarkOrange;
            else if (status == "Error")
                e.CellStyle.ForeColor = Color.Red;
        }

        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayrollList();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm dash)
            {
                dash.Close();
            }
        }
    }
}
