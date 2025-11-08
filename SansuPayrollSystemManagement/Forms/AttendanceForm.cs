using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class AttendanceForm : Form
    {
        private DBHelper db = new DBHelper();

        public AttendanceForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadAttendanceData();
            string deleteQuery = @"
        DELETE a1 FROM Attendance a1
        JOIN Attendance a2 
        ON a1.EmployeeID = a2.EmployeeID 
        AND a1.Date = a2.Date 
        AND a1.AttendanceID > a2.AttendanceID;
    ";

            db.ExecuteNonQuery(deleteQuery);

            LoadAttendanceData();
        }

        private void LoadAttendanceData(string search = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=sansu_payroll_db;uid=root;pwd=;"))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        a.AttendanceID AS 'ID',
                                        e.FullName AS 'Employee Name',
                                        e.Position AS 'Position',
                                        a.Date AS 'Date',
                                        a.TimeIn AS 'Time In',
                                        a.TimeOut AS 'Time Out',
                                        a.Status AS 'Status'
                                    FROM Attendance a
                                    JOIN Employees e ON a.EmployeeID = e.EmployeeID";

                    if (!string.IsNullOrEmpty(search))
                        query += " WHERE e.FullName LIKE @search OR e.Position LIKE @search";

                    query += " ORDER BY a.Date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(search))
                        cmd.Parameters.AddWithValue("@search", $"%{search}%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    guna2DataGridViewAttendance.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadAttendanceData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAttendanceData(txtSearch.Text.Trim());
        }

        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashboardForm("Admin").ShowDialog();
            this.Close();
        }

        private void btnScanFingerprint_Click(object sender, EventArgs e)
        {
            try
            {
                // Simulate fingerprint scan (replace this later with SDK logic)
                byte[] scanned = new byte[] { 0x01, 0x02, 0x03 };

                // In your current DB, only FullName is available for display
                var dt = db.GetData("SELECT EmployeeID, FullName FROM Employees WHERE EmployeeID = 1");

                if (dt.Rows.Count == 0)
                {
                    lblScanStatus.Text = "Fingerprint not recognized.";
                    return;
                }

                int empId = Convert.ToInt32(dt.Rows[0]["EmployeeID"]);
                string empName = dt.Rows[0]["FullName"].ToString();

                // Check if employee already has attendance record today
                string checkSql = "SELECT TimeIn, TimeOut FROM Attendance WHERE EmployeeID=@id AND Date=CURDATE()";
                var check = db.GetData(checkSql, new MySqlParameter[] { new MySqlParameter("@id", empId) });

                if (check.Rows.Count == 0)
                {
                    string insertSql = "INSERT INTO Attendance (EmployeeID, Date, TimeIn, Status) VALUES (@id, CURDATE(), NOW(), 'Present')";
                    db.ExecuteNonQuery(insertSql, new MySqlParameter[] { new MySqlParameter("@id", empId) });
                    lblScanStatus.Text = $"Clock-in recorded for {empName} at {DateTime.Now:T}";
                }
                else if (check.Rows[0].IsNull("TimeOut"))
                {
                    string updateSql = "UPDATE Attendance SET TimeOut=NOW() WHERE EmployeeID=@id AND Date=CURDATE()";
                    db.ExecuteNonQuery(updateSql, new MySqlParameter[] { new MySqlParameter("@id", empId) });
                    lblScanStatus.Text = $"Clock-out recorded for {empName} at {DateTime.Now:T}";
                }
                else
                {
                    lblScanStatus.Text = $"{empName} already clocked out today.";
                }

                LoadAttendanceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scanning fingerprint: " + ex.Message);
            }
        }

        private void guna2DataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2DataGridViewAttendance.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an employee record first.",
                                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int empId = Convert.ToInt32(guna2DataGridViewAttendance.SelectedRows[0].Cells["ID"].Value);

                // Check if attendance record exists for today
                string checkSql = "SELECT * FROM Attendance WHERE EmployeeID = @id AND Date = CURDATE()";
                var check = db.GetData(checkSql, new MySql.Data.MySqlClient.MySqlParameter[] {
            new MySql.Data.MySqlClient.MySqlParameter("@id", empId)
        });

                if (check.Rows.Count == 0)
                {
                    // Mark new attendance for today
                    string insertSql = @"INSERT INTO Attendance (EmployeeID, Date, TimeIn, Status)
                                 VALUES (@id, CURDATE(), NOW(), 'Present')";
                    db.ExecuteNonQuery(insertSql, new MySql.Data.MySqlClient.MySqlParameter[] {
                new MySql.Data.MySqlClient.MySqlParameter("@id", empId)
            });

                    MessageBox.Show("Attendance marked as Present for today.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If already has a TimeIn but no TimeOut, mark TimeOut
                    if (check.Rows[0].IsNull("TimeOut"))
                    {
                        string updateSql = @"UPDATE Attendance 
                         SET TimeOut = NOW() 
                         WHERE EmployeeID = @id AND Date = CURDATE()";
                        db.ExecuteNonQuery(updateSql, new MySql.Data.MySqlClient.MySqlParameter[] {
        new MySql.Data.MySqlClient.MySqlParameter("@id", empId)
    });

                        MessageBox.Show("Time-out recorded for today.", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadAttendanceData(); // refresh table
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking attendance: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }
    }
}