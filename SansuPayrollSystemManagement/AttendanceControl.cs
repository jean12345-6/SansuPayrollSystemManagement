using ExcelDataReader;
using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class AttendanceControl : UserControl
    {
        private DBHelper db = new DBHelper();

        public AttendanceControl()
        {
            InitializeComponent();
            CustomizeGridAppearance();
            LoadAttendanceData();
        }

        // ==========================================
        // SAFE CONVERTERS
        // ==========================================
        private decimal GetDecimal(object value)
        {
            if (value == null || value == DBNull.Value) return 0;
            decimal result;
            return decimal.TryParse(value.ToString(), out result) ? result : 0;
        }

        private int GetInt(object value)
        {
            if (value == null || value == DBNull.Value) return 0;
            int result;
            return int.TryParse(value.ToString(), out result) ? result : 0;
        }

        private string GetString(object value)
        {
            if (value == null || value == DBNull.Value) return "";
            return value.ToString().Trim();
        }

        // ==========================================
        // LOAD ATTENDANCE (SUMMARY)
        // ==========================================
        private void LoadAttendanceData(string search = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(
                    "server=localhost;database=sansu_payroll_db;uid=root;pwd=;"))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            s.SummaryID AS 'ID',
                            e.FullName AS 'Employee Name',
                            CONCAT(s.PeriodStart, ' to ', s.PeriodEnd) AS 'Period',
                            s.WorktimeNormal AS 'Normal Hours',
                            s.WorktimeActual AS 'Actual Hours',
                            s.LateMinutes AS 'Late (min)',
                            s.AbsenceDays AS 'Absences',
                            s.OvertimeNormal AS 'OT Normal',
                            s.OvertimeHoliday AS 'OT Holiday'
                        FROM AttendanceSummary s
                        JOIN Employees e ON s.EmployeeID = e.EmployeeID";

                    if (!string.IsNullOrEmpty(search))
                    {
                        sql += " WHERE e.FullName LIKE @search";
                    }

                    sql += " ORDER BY s.PeriodStart DESC, e.FullName ASC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (!string.IsNullOrEmpty(search))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvAttendance.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
            }
        }

        // ==========================================
        // GRID DESIGN
        // ==========================================
        private void CustomizeGridAppearance()
        {
            dgvAttendance.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F);
            dgvAttendance.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 13F, FontStyle.Bold);

            dgvAttendance.RowTemplate.Height = 40;
            dgvAttendance.ColumnHeadersHeight = 40;
        }

        // ==========================================
        // SEARCH BOX
        // ==========================================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAttendanceData(txtSearch.Text.Trim());
        }

        // ==========================================
        // REFRESH BUTTON
        // ==========================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadAttendanceData();
        }

        // ==========================================
        // IMPORT ATTENDANCE SUMMARY FROM EXCEL
        // ==========================================
        private void btnImportAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Files|*.xls;*.xlsx";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet();

                    // Find the "Attendance Statistic Table" sheet
                    DataTable sheet = result.Tables
                        .Cast<DataTable>()
                        .FirstOrDefault(t => t.TableName.Contains("Attendance Statistic"));

                    if (sheet == null)
                    {
                        // Fallback: use second sheet if exists, otherwise first
                        sheet = result.Tables.Count > 1 ? result.Tables[1] : result.Tables[0];
                    }

                    if (sheet.Rows.Count < 5)
                    {
                        MessageBox.Show("The selected file does not contain attendance data.",
                            "Import Attendance",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    // ======================================
                    // READ PERIOD FROM ROW 1, COL 0
                    // "Date:2025-11-01~2025-11-12"
                    // ======================================
                    DateTime periodStart = DateTime.MinValue;
                    DateTime periodEnd = DateTime.MinValue;
                    string dateText = GetString(sheet.Rows[1][0]); // row index 1, column 0

                    if (dateText.StartsWith("Date:", StringComparison.OrdinalIgnoreCase))
                    {
                        string range = dateText.Substring(5); // remove "Date:"
                        string[] parts = range.Split('~');

                        if (parts.Length == 2)
                        {
                            DateTime.TryParse(parts[0], out periodStart);
                            DateTime.TryParse(parts[1], out periodEnd);
                        }
                    }

                    if (periodStart == DateTime.MinValue || periodEnd == DateTime.MinValue)
                    {
                        // fallback: use today
                        periodStart = DateTime.Today;
                        periodEnd = DateTime.Today;
                    }

                    // Remove existing records for this period (avoid duplicates)
                    db.ExecuteNonQuery(
                        "DELETE FROM AttendanceSummary WHERE PeriodStart=@ps AND PeriodEnd=@pe",
                        new MySqlParameter[]
                        {
                            new MySqlParameter("@ps", periodStart),
                            new MySqlParameter("@pe", periodEnd)
                        });

                    int imported = 0;
                    int skipped = 0;

                    // Data starts at row index 4 (after headers & subheaders)
                    for (int i = 4; i < sheet.Rows.Count; i++)
                    {
                        DataRow row = sheet.Rows[i];

                        // Skip completely empty rows
                        if (row[0] == null || row[0] == DBNull.Value)
                            continue;

                        // USER ID (maps to EmployeeID)
                        int excelUserId;
                        if (!int.TryParse(row[0].ToString(), out excelUserId))
                        {
                            skipped++;
                            continue;
                        }

                        object empIdObj = db.ExecuteScalar(
                            "SELECT EmployeeID FROM Employees WHERE EmployeeID=@id",
                            new MySqlParameter[]
                            {
                                new MySqlParameter("@id", excelUserId)
                            });

                        if (empIdObj == null || empIdObj == DBNull.Value)
                        {
                            // User ID not found in Employees table
                            skipped++;
                            continue;
                        }

                        int employeeId = Convert.ToInt32(empIdObj);

                        // ==== CORRECT COLUMN MAPPING (SEE TABLE ABOVE) ====
                        decimal workNormal = GetDecimal(row[3]);  // Worktime Normal
                        decimal workActual = GetDecimal(row[4]);  // Worktime Actual

                        int lateTimes = GetInt(row[5]);      // not shown in grid
                        int lateMinutes = GetInt(row[6]);      // Late (min)

                        int earlyTimes = GetInt(row[7]);      // not shown
                        int earlyMinutes = GetInt(row[8]);      // not shown

                        decimal otNormal = GetDecimal(row[9]);  // OT Normal
                        decimal otHoliday = GetDecimal(row[10]); // OT Holiday

                        string workDay = GetString(row[11]);  // "8/1", etc.
                        int tripDays = GetInt(row[12]);     // Trip (Day)

                        int absenceDays = GetInt(row[13]);     // Absence (Day)
                        int leaveDays = GetInt(row[14]);     // Leave (Day)

                        string insertSql = @"
                            INSERT INTO AttendanceSummary 
                            (EmployeeID, PeriodStart, PeriodEnd,
                             WorktimeNormal, WorktimeActual,
                             LateTimes, LateMinutes,
                             EarlyTimes, EarlyMinutes,
                             OvertimeNormal, OvertimeHoliday,
                             WorkdayNormalActual, TripDays, AbsenceDays, LeaveDays)
                            VALUES
                            (@eid, @ps, @pe,
                             @wn, @wa,
                             @lt, @lm,
                             @et, @em,
                             @otn, @oth,
                             @wd, @trip, @abs, @leave)";

                        db.ExecuteNonQuery(insertSql, new MySqlParameter[]
                        {
                            new MySqlParameter("@eid", employeeId),
                            new MySqlParameter("@ps", periodStart),
                            new MySqlParameter("@pe", periodEnd),

                            new MySqlParameter("@wn", workNormal),
                            new MySqlParameter("@wa", workActual),

                            new MySqlParameter("@lt", lateTimes),
                            new MySqlParameter("@lm", lateMinutes),

                            new MySqlParameter("@et", earlyTimes),
                            new MySqlParameter("@em", earlyMinutes),

                            new MySqlParameter("@otn", otNormal),
                            new MySqlParameter("@oth", otHoliday),

                            new MySqlParameter("@wd", workDay),
                            new MySqlParameter("@trip", tripDays),
                            new MySqlParameter("@abs", absenceDays),
                            new MySqlParameter("@leave", leaveDays)
                        });

                        imported++;
                    }

                    MessageBox.Show(
                        $"Imported {imported} record(s).\nSkipped {skipped}.",
                        "Import Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                // Refresh grid after import
                LoadAttendanceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing attendance: " + ex.Message);
            }
        }

        // ==========================================
        // BACK TO DASHBOARD BUTTON
        // ==========================================
        private void GoBackToDashboard()
        {
            Form parent = this.FindForm();

            if (parent is DashboardForm dashboard)
            {
                dashboard.OpenDashboard(); // same behavior as EmployeeControl
            }
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            GoBackToDashboard();
        }

        private void AttendanceControl_Load(object sender, EventArgs e)
        {
        }

        private void AttendanceControl_Load_1(object sender, EventArgs e)
        {
        }
    }
}
