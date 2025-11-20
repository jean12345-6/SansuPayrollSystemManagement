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
        // LOAD ATTENDANCE
        // ==========================================
        private void LoadAttendanceData(string search = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(
                    "server=localhost;database=sansu_payroll_db;uid=root;pwd=;"))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            a.AttendanceID AS 'ID',
                            e.FullName AS 'Employee Name',
                            a.Date AS 'Date',
                            a.TimeIn AS 'Time In',
                            a.TimeOut AS 'Time Out',
                            a.Status AS 'Status'
                        FROM Attendance a
                        JOIN Employees e ON a.EmployeeID = e.EmployeeID";

                    if (!string.IsNullOrEmpty(search))
                        query += " WHERE e.FullName LIKE @search";

                    query += " ORDER BY a.Date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(search))
                        cmd.Parameters.AddWithValue("@search", $"%{search}%");

                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(dt);

                    dgvAttendance.DataSource = dt;
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
        // IMPORT ATTENDANCE — FIXED FOR YOUR EXCEL
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
                    DataTable sheet = result.Tables[0];

                    int imported = 0;
                    int skipped = 0;

                    // Your file starts at row index 1 (row 2 in Excel)
                    for (int i = 1; i < sheet.Rows.Count; i++)
                    {
                        DataRow row = sheet.Rows[i];

                        // -----------------------------------------
                        // FullName (Column B = index 1)
                        // -----------------------------------------
                        string fullName = row[1]?.ToString().Trim();
                        if (string.IsNullOrEmpty(fullName))
                        {
                            skipped++;
                            continue;
                        }

                        object empIdObj = db.ExecuteScalar(
                            "SELECT EmployeeID FROM Employees WHERE LOWER(FullName)=LOWER(@name)",
                            new MySqlParameter[] { new MySqlParameter("@name", fullName) }
                        );

                        if (empIdObj == null)
                        {
                            skipped++;
                            continue;
                        }

                        int employeeId = Convert.ToInt32(empIdObj);

                        // -----------------------------------------
                        // Date (Column A = index 0)
                        // -----------------------------------------
                        DateTime date;
                        if (!DateTime.TryParse(row[0]?.ToString(), out date))
                        {
                            skipped++;
                            continue;
                        }

                        // -----------------------------------------
                        // Time In (Column C = index 2)
                        // -----------------------------------------
                        DateTime timeInParsed;
                        DateTime? timeIn = DateTime.TryParse(row[2]?.ToString(), out timeInParsed)
                            ? (DateTime?)timeInParsed
                            : null;

                        // -----------------------------------------
                        // Time Out (Column D = index 3)
                        // -----------------------------------------
                        DateTime timeOutParsed;
                        DateTime? timeOut = DateTime.TryParse(row[3]?.ToString(), out timeOutParsed)
                            ? (DateTime?)timeOutParsed
                            : null;

                        // -----------------------------------------
                        // Status (Column R = index 17)
                        // -----------------------------------------
                        string status = row[17]?.ToString().Trim();
                        if (string.IsNullOrEmpty(status))
                            status = "Present";

                        string insertSql = @"
                            INSERT INTO Attendance (EmployeeID, Date, TimeIn, TimeOut, Status)
                            VALUES (@id, @date, @timeIn, @timeOut, @status)";

                        db.ExecuteNonQuery(insertSql, new MySqlParameter[]
                        {
                            new MySqlParameter("@id", employeeId),
                            new MySqlParameter("@date", date),
                            new MySqlParameter("@timeIn", (object)timeIn ?? DBNull.Value),
                            new MySqlParameter("@timeOut", (object)timeOut ?? DBNull.Value),
                            new MySqlParameter("@status", status)
                        });

                        imported++;
                    }

                    MessageBox.Show(
                        $"Imported {imported} record(s).\nSkipped {skipped}.",
                        "Import Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadAttendanceData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing attendance: " + ex.Message);
            }
        }
    }
}
