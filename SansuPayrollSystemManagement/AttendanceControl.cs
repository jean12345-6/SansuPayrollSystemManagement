using ExcelDataReader;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Forms;
using SansuPayrollSystemManagement.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class AttendanceControl : UserControl
    {
        private readonly DBHelper db = new DBHelper();
        private string userRole = "employee";
        private const string ConnectionString = "server=localhost;database=sansu_payroll_db;uid=root;pwd=;";

        // ==========================================
        // CONSTRUCTORS
        // ==========================================
        public AttendanceControl()
        {
            InitializeComponent();
            InitializeControl();
        }

        public AttendanceControl(string role)
        {
            userRole = role?.ToLower() ?? "employee";
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            CustomizeGridAppearance();
            LoadAttendanceData();
            ApplyRoleRestrictions();
        }

        private bool IsPowerUser()
        {
            return userRole == "admin" ||
                   userRole == "administrator" ||
                   userRole == "hr" ||
                   userRole == "hr manager";
        }

        // ==========================================
        // HELPERS
        // ==========================================
        private string GetString(object value)
        {
            if (value == null || value == DBNull.Value) return string.Empty;
            return value.ToString().Trim();
        }

        // ==========================================
        // LOAD ATTENDANCE FROM DB
        // ==========================================
        private void LoadAttendanceData(string search = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            a.AttendanceID       AS 'ID',
                            a.EmployeeID         AS 'EmployeeID',
                            e.FullName           AS 'Employee Name',
                            a.Date               AS 'Date',
                            a.TimeIn             AS 'Time In',
                            a.TimeOut            AS 'Time Out',
                            CASE 
                                WHEN a.TimeIn IS NOT NULL AND a.TimeOut IS NOT NULL
                                    THEN ROUND(TIMESTAMPDIFF(MINUTE, a.TimeIn, a.TimeOut) / 60.0, 2)
                                ELSE 0
                            END                  AS 'Hours Worked',
                            a.Status             AS 'Status'
                        FROM Attendance a
                        JOIN Employees e ON a.EmployeeID = e.EmployeeID
                    ";

                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        sql += @"
                            WHERE e.FullName LIKE @search
                               OR DATE_FORMAT(a.Date, '%Y-%m-%d') LIKE @search
                        ";
                    }

                    sql += " ORDER BY a.Date DESC, e.FullName ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(search))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvAttendance.DataSource = dt;

                            // Hide internal columns from the user
                            if (dgvAttendance.Columns["EmployeeID"] != null)
                                dgvAttendance.Columns["EmployeeID"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message,
                    "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // GRID BEHAVIOR
        // ==========================================
        private void CustomizeGridAppearance()
        {
            // Behaviour settings only (no colors/sizes)
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.MultiSelect = false;
            dgvAttendance.ReadOnly = true;
            dgvAttendance.AutoGenerateColumns = true;
        }

        // ==========================================
        // ROLE RESTRICTIONS
        // ==========================================
        private void ApplyRoleRestrictions()
        {
            // Only Admin / HR can import attendance
            if (!IsPowerUser())
            {
                if (btnImportAttendance != null)
                    btnImportAttendance.Visible = false;

                if (btnUnimportAttendance != null)
                    btnUnimportAttendance.Visible = false;
            }
        }

        // ==========================================
        // SEARCH
        // ==========================================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAttendanceData(txtSearch.Text.Trim());
        }

        // ==========================================
        // IMPORT FROM EXCEL (BIOMETRIC)
        // ==========================================
        private void btnImportAttendance_Click(object sender, EventArgs e)
        {
            if (!IsPowerUser())
            {
                MessageBox.Show("You do not have permission to import attendance.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Excel Files|*.xls;*.xlsx"
                };

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet();

                    // 1) Attendance Statistic Table
                    DataTable statSheet = result.Tables
                        .Cast<DataTable>()
                        .FirstOrDefault(t => t.TableName.Contains("Attendance Statistic"));

                    if (statSheet == null)
                    {
                        MessageBox.Show("Could not find 'Attendance Statistic Table' sheet.",
                            "Import Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 2) Time Card sheet (skip Shift Setting sheet)
                    DataTable timeSheet = null;
                    foreach (DataTable t in result.Tables)
                    {
                        if (t == statSheet) continue;
                        if (t.TableName.Contains("Shift")) continue;
                        timeSheet = t;
                    }
                    if (timeSheet == null)
                        timeSheet = result.Tables[result.Tables.Count - 1];

                    // 3) Period from statistic sheet: "Date:2025-11-01~2025-11-12"
                    DateTime periodStart = DateTime.Today;
                    DateTime periodEnd = DateTime.Today;

                    string dateText = GetString(statSheet.Rows[1][0]);
                    if (dateText.StartsWith("Date:", StringComparison.OrdinalIgnoreCase))
                    {
                        string range = dateText.Substring(5);
                        string[] parts = range.Split('~');
                        if (parts.Length == 2)
                        {
                            DateTime.TryParse(parts[0], out periodStart);
                            DateTime.TryParse(parts[1], out periodEnd);
                        }
                    }

                    // 4) Find row where first cell is "User ID"
                    List<int> userIds = new List<int>();
                    int userHeaderRow = -1;

                    for (int r = 0; r < statSheet.Rows.Count; r++)
                    {
                        string v = GetString(statSheet.Rows[r][0]);
                        if (v == "User ID")
                        {
                            userHeaderRow = r;
                            break;
                        }
                    }

                    if (userHeaderRow == -1)
                    {
                        MessageBox.Show("Could not find 'User ID' header in Attendance Statistic Table.",
                            "Import Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 5) Collect User IDs
                    int dataStartRowStat = userHeaderRow + 2;
                    for (int r = dataStartRowStat; r < statSheet.Rows.Count; r++)
                    {
                        object idCell = statSheet.Rows[r][0];
                        if (idCell == null || idCell == DBNull.Value) break;

                        if (int.TryParse(idCell.ToString(), out int uid))
                        {
                            userIds.Add(uid);
                        }
                    }

                    if (userIds.Count == 0)
                    {
                        MessageBox.Show("No User IDs found in Attendance Statistic Table.",
                            "Import Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int imported = 0;

                    // Each employee block = 15 columns wide
                    for (int u = 0; u < userIds.Count; u++)
                    {
                        int userId = userIds[u];
                        int blockStart = u * 15;

                        // Map UserID to EmployeeID (here we assume they match)
                        object empObj = db.ExecuteScalar(
                            "SELECT EmployeeID FROM Employees WHERE EmployeeID = @id",
                            new MySqlParameter[]
                            {
                                new MySqlParameter("@id", userId)
                            });

                        if (empObj == null || empObj == DBNull.Value)
                        {
                            // user not in Employees table
                            continue;
                        }

                        int employeeId = Convert.ToInt32(empObj);

                        // In sample, time rows start around row index 12
                        int dataStartRowTime = 12;

                        for (int r = dataStartRowTime; r < timeSheet.Rows.Count; r++)
                        {
                            DataRow row = timeSheet.Rows[r];

                            if (blockStart >= timeSheet.Columns.Count)
                                continue;

                            object dateCell = row[blockStart];
                            if (dateCell == null || dateCell == DBNull.Value)
                                continue;

                            string dayText = GetString(dateCell); // "14 Fr", etc.
                            if (string.IsNullOrEmpty(dayText))
                                continue;

                            string numericDay = new string(dayText.TakeWhile(char.IsDigit).ToArray());
                            if (!int.TryParse(numericDay, out int dayNumber))
                                continue;

                            DateTime workDate;
                            try
                            {
                                workDate = new DateTime(periodStart.Year, periodStart.Month, dayNumber);
                            }
                            catch
                            {
                                continue;
                            }

                            // Time cells
                            DateTime? in1 = GetTimeFromCell(row, blockStart + 1, workDate);
                            DateTime? out1 = GetTimeFromCell(row, blockStart + 3, workDate);
                            DateTime? in2 = GetTimeFromCell(row, blockStart + 6, workDate);
                            DateTime? out2 = GetTimeFromCell(row, blockStart + 8, workDate);
                            DateTime? inOt = GetTimeFromCell(row, blockStart + 11, workDate);
                            DateTime? outOt = GetTimeFromCell(row, blockStart + 13, workDate);

                            var ins = new List<DateTime>();
                            if (in1.HasValue) ins.Add(in1.Value);
                            if (in2.HasValue) ins.Add(in2.Value);
                            if (inOt.HasValue) ins.Add(inOt.Value);

                            var outs = new List<DateTime>();
                            if (out1.HasValue) outs.Add(out1.Value);
                            if (out2.HasValue) outs.Add(out2.Value);
                            if (outOt.HasValue) outs.Add(outOt.Value);

                            if (ins.Count == 0 && outs.Count == 0)
                                continue;

                            DateTime? timeIn = ins.Count > 0 ? (DateTime?)ins.Min() : null;
                            DateTime? timeOut = outs.Count > 0 ? (DateTime?)outs.Max() : null;

                            // Status (Present / Late)
                            string status = "Present";
                            if (timeIn.HasValue)
                            {
                                DateTime scheduled = workDate.Date.AddHours(8); // 8:00 AM
                                if ((timeIn.Value - scheduled).TotalMinutes > 0.5)
                                {
                                    status = "Late";
                                }
                            }

                            // Avoid duplicate records for same Employee + Date
                            object existing = db.ExecuteScalar(
                                "SELECT AttendanceID FROM Attendance WHERE EmployeeID = @eid AND Date = @d",
                                new MySqlParameter[]
                                {
                                    new MySqlParameter("@eid", employeeId),
                                    new MySqlParameter("@d", workDate)
                                });

                            if (existing != null && existing != DBNull.Value)
                                continue;

                            string insertSql = @"
                                INSERT INTO Attendance (EmployeeID, Date, TimeIn, TimeOut, Status)
                                VALUES (@eid, @date, @in, @out, @status)";


                            db.ExecuteNonQuery(insertSql,
                                new MySqlParameter[]
                                {
                                    new MySqlParameter("@eid", employeeId),
                                    new MySqlParameter("@date", workDate),
                                    new MySqlParameter("@in", (object)timeIn ?? DBNull.Value),
                                    new MySqlParameter("@out", (object)timeOut ?? DBNull.Value),
                                    new MySqlParameter("@status", status)
                                });

                            imported++;
                        }
                    }

                    MessageBox.Show(
                        $"Imported {imported} daily attendance record(s).",
                        "Import Attendance",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Reload grid after import
                    LoadAttendanceData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing attendance: " + ex.Message,
                    "Import Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // PARSE TIME CELL
        // ==========================================
        private DateTime? GetTimeFromCell(DataRow row, int colIndex, DateTime baseDate)
        {
            if (colIndex >= row.Table.Columns.Count)
                return null;

            object v = row[colIndex];
            if (v == null || v == DBNull.Value)
                return null;

            try
            {
                if (v is DateTime dt)
                {
                    return baseDate.Date + dt.TimeOfDay;
                }

                if (double.TryParse(v.ToString(), out double d))
                {
                    DateTime dt2 = DateTime.FromOADate(d);
                    return baseDate.Date + dt2.TimeOfDay;
                }

                if (DateTime.TryParse(v.ToString(), out DateTime parsed))
                {
                    return baseDate.Date + parsed.TimeOfDay;
                }
            }
            catch
            {
                // ignore parsing errors
            }

            return null;
        }

        // ==========================================
        // NAVIGATION BUTTONS (BOTTOM MENU)
        // ==========================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?",
                    "Confirm Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.FindForm() is DashboardForm form)
                {
                    form.Close();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm form)
            {
                form.OpenDashboard();
            }
        }

        private void btnIconEmployees_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm form)
            {
                form.LoadPage(new EmployeeControl(userRole));
            }
        }

        private void btnIconPayroll_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm form)
            {
                form.LoadPage(new PayrollControl(userRole));
            }
        }

        private void btnIconPerformance_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm form)
            {
                form.LoadPage(new PerformanceControl(userRole));
            }
        }

        private void btnIconSettings_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm form)
            {
                form.LoadPage(new SettingsControl(userRole));
            }
        }

        private void btnIconAttendance_Click(object sender, EventArgs e)
        {
            // Already on Attendance page – keep as no-op or refresh if you want
        }

        // ==========================================
        // LOAD EVENT
        // ==========================================
        private void AttendanceControl_Load(object sender, EventArgs e)
        {
            // Constructor already calls InitializeControl() which loads data
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            // Optional custom drawing
        }

        // ==========================================
        // GRID CELL CLICK HANDLER
        // ==========================================
        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Timecard feature removed – intentionally left empty
            // This handler is kept for compatibility with designer wiring
        }

        // ==========================================
        // UNIMPORT ATTENDANCE
        // ==========================================
        private void btnUnimportAttendance_Click(object sender, EventArgs e)
        {
            if (!IsPowerUser())
            {
                MessageBox.Show("You do not have permission to delete attendance records.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                "This will delete ALL attendance logs.\n\nAre you sure you want to continue?",
                "Unimport Attendance",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                db.ExecuteNonQuery("DELETE FROM Attendance");

                LoadAttendanceData(); // refresh grid

                MessageBox.Show(
                    "Attendance has been cleared successfully.",
                    "Unimport Attendance",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error clearing attendance: " + ex.Message,
                    "Unimport Attendance",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
