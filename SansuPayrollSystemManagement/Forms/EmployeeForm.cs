using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Forms;
using SansuPayrollSystemManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class EmployeeForm : Form
    {
        private string connectionString = "server=localhost;database=sansu_payroll_db;uid=root;pwd=;";
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            string sql = "SELECT EmployeeID, FullName, Position, ContactInfo, Salary FROM Employees";
            DBHelper db = new DBHelper();
            dgvEmployees.DataSource = db.GetData(sql);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addForm = new AddEmployeeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees(); // Refresh the employee grid
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value);
                DBHelper db = new DBHelper();
                db.ExecuteNonQuery("DELETE FROM Employees WHERE EmployeeID=@id",
                    new MySqlParameter[] { new MySqlParameter("@id", id) });
                LoadEmployees();
            }
        }

        private void btnEnrollFingerprint_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int empId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value);
            string empName = dgvEmployees.SelectedRows[0].Cells["FullName"].Value.ToString();

            FingerprintEnrollForm enrollForm = new FingerprintEnrollForm(empId, empName);
            if (enrollForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees(); // Refresh the grid to reflect updates
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string sql = @"
        SELECT EmployeeID, FullName, Position, ContactInfo, Salary
        FROM Employees
        WHERE FullName LIKE @kw OR Position LIKE @kw OR ContactInfo LIKE @kw";

            DBHelper db = new DBHelper();
            MySqlParameter[] prms = { new MySqlParameter("@kw", "%" + keyword + "%") };
            dgvEmployees.DataSource = db.GetData(sql, prms);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();  // optional: clears the search field
            LoadEmployees();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int selectedEmployeeId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value);
                AddEmployeeForm editForm = new AddEmployeeForm(selectedEmployeeId);
                editForm.ShowDialog();

                LoadEmployees(); // Refresh employee list after editing
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int selectedEmployeeId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value);
                AddEmployeeForm viewForm = new AddEmployeeForm(selectedEmployeeId);
                viewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an employee to view.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void btnVerifyFingerprint_Click(object sender, EventArgs e)
        {
            try
            {
                // Simulated fingerprint data (replace this with real fingerprint SDK logic later)
                byte[] scannedFingerprint = new byte[] { 0x01, 0x02, 0x03 };

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT EmployeeName FROM employees WHERE FingerprintTemplate = @fp LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fp", scannedFingerprint);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show($"Fingerprint verified! Welcome, {result.ToString()}",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fingerprint not found in the database.",
                                        "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying fingerprint: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
