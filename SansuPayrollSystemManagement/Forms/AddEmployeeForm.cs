using MySql.Data.MySqlClient;
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

namespace SansuPayrollSystemManagement.Forms
{
    public partial class AddEmployeeForm : Form
    {
        private string connectionString = "server=localhost;database=sansu_payroll_db;uid=root;pwd=;";
        private int? editingEmployeeId = null; // null = adding new
        private string mode; // "Add", "Edit", or "View"
        private int employeeId;
        DBHelper db = new DBHelper();
        public AddEmployeeForm()
        {
            InitializeComponent();
            this.Text = "Add New Employee";
        }
        public AddEmployeeForm(int empId = 0, string formMode = "Add")
        {
            InitializeComponent();
            employeeId = empId;
            mode = formMode;
        }
        public AddEmployeeForm(int employeeId)
        {
            InitializeComponent();
            this.Text = "Edit Employee Details";
            editingEmployeeId = employeeId;

            LoadEmployeeData(employeeId); // fetch details to fields
        }
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            if (mode == "Edit" || mode == "View")
            {
                LoadEmployeeData(employeeId);
            }

            if (mode == "View")
            {
                // Disable editing controls
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox) ((TextBox)c).ReadOnly = true;
                    if (c is ComboBox) ((ComboBox)c).Enabled = false;
                    if (c is DateTimePicker) ((DateTimePicker)c).Enabled = false;
                }

                btnSave.Visible = false;
                btnCancel.Enabled = false;
            }
        }
        private void LoadEmployeeData(int employeeId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FullName, Position, ContactInfo, Salary FROM Employees WHERE EmployeeID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtFullName.Text = reader["FullName"].ToString();
                        txtPosition.Text = reader["Position"].ToString();
                        txtContact.Text = reader["ContactInfo"].ToString();
                        txtSalary.Text = reader["Salary"].ToString();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"INSERT INTO Employees (FullName, Position, ContactInfo, Salary, DateHired)
                           VALUES (@name, @pos, @contact, @salary, @date)";
            MySqlParameter[] p = {
                new MySqlParameter("@name", txtFullName.Text.Trim()),
                new MySqlParameter("@pos", txtPosition.Text.Trim()),
                new MySqlParameter("@contact", txtContact.Text.Trim()),
                new MySqlParameter("@salary", Convert.ToDecimal(txtSalary.Text)),
                new MySqlParameter("@date", dtpDateHired.Value.Date)
            };

            int rows = db.ExecuteNonQuery(sql, p);
            if (rows > 0)
            {
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}