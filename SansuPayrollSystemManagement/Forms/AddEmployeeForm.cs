using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace SansuPayrollSystemManagement.Forms
{
    public partial class AddEmployeeForm : Form
    {
        private string mode = "Add";     // Add, Edit, View
        private int employeeId = 0;
        private DBHelper db = new DBHelper();

        public AddEmployeeForm()
        {
            InitializeComponent();
            mode = "Add";
            this.Text = "Add New Employee";
        }

        public AddEmployeeForm(int id, string formMode)
        {
            InitializeComponent();
            employeeId = id;
            mode = formMode;     // “Edit” or “View”
        }

        public AddEmployeeForm(int id)   // default to EDIT
        {
            InitializeComponent();
            employeeId = id;
            mode = "Edit";
        }


        // ================================
        // FORM LOAD
        // ================================
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            if (mode == "Edit" || mode == "View")
            {
                LoadEmployeeData(employeeId);
            }

            if (mode == "Add")
            {
                btnSave.Visible = true;
                btnCancel.Text = "Cancel";
                guna2HtmlLabel5.Text = "ADD NEW EMPLOYEE";
            }

            if (mode == "Edit")
            {
                btnSave.Visible = true;
                btnCancel.Text = "Cancel";
                guna2HtmlLabel5.Text = "EDIT EMPLOYEE";
            }

            if (mode == "View")
            {
                guna2HtmlLabel5.Text = "VIEW EMPLOYEE";

                btnSave.Visible = false;
                btnCancel.Text = "Close";

                // Disable ALL fields
                txtFullName.Enabled = false;
                txtPosition.Enabled = false;
                txtContact.Enabled = false;
                txtSalary.Enabled = false;
                dtpDateHired.Enabled = false;
            }
        }


        // ================================
        // LOAD EMPLOYEE DATA
        // ================================
        private void LoadEmployeeData(int employeeId)
        {
            string sql = "SELECT FullName, Position, ContactInfo, Salary, DateHired FROM Employees WHERE EmployeeID = @id";

            DataTable dt = db.GetData(sql, new MySqlParameter[]
            {
        new MySqlParameter("@id", employeeId)
            });

            if (dt.Rows.Count == 0) return;

            DataRow r = dt.Rows[0];

            txtFullName.Text = r["FullName"].ToString();
            txtPosition.Text = r["Position"].ToString();
            txtContact.Text = r["ContactInfo"].ToString();
            txtSalary.Text = r["Salary"].ToString();

            if (DateTime.TryParse(r["DateHired"].ToString(), out DateTime d))
                dtpDateHired.Value = d;
        }

        // ================================
        // SAVE EMPLOYEE
        // ================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Please fill out all required fields.",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate salary is numeric
            if (!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Salary must be a valid number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (mode == "Add")
                {
                    SaveNewEmployee();
                }
                else if (mode == "Edit")
                {
                    UpdateEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving employee: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================================
        // SAVE NEW EMPLOYEE
        // ================================
        private void SaveNewEmployee()
        {
            string sql = @"INSERT INTO Employees 
                           (FullName, Position, ContactInfo, Salary, DateHired)
                           VALUES (@name, @pos, @contact, @salary, @date)";

            MySqlParameter[] p =
            {
                new MySqlParameter("@name", txtFullName.Text.Trim()),
                new MySqlParameter("@pos", txtPosition.Text.Trim()),
                new MySqlParameter("@contact", txtContact.Text.Trim()),
                new MySqlParameter("@salary", Convert.ToDecimal(txtSalary.Text)),
                new MySqlParameter("@date", dtpDateHired.Value.Date)
            };

            int rows = db.ExecuteNonQuery(sql, p);

            if (rows > 0)
            {
                MessageBox.Show("Employee added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add employee.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================================
        // UPDATE EXISTING EMPLOYEE
        // ================================
        private void UpdateEmployee()
        {
            string sql = @"UPDATE Employees 
                           SET FullName = @name, Position = @pos, 
                               ContactInfo = @contact, Salary = @salary, 
                               DateHired = @date
                           WHERE EmployeeID = @id";

            MySqlParameter[] p =
            {
                new MySqlParameter("@name", txtFullName.Text.Trim()),
                new MySqlParameter("@pos", txtPosition.Text.Trim()),
                new MySqlParameter("@contact", txtContact.Text.Trim()),
                new MySqlParameter("@salary", Convert.ToDecimal(txtSalary.Text)),
                new MySqlParameter("@date", dtpDateHired.Value.Date),
                new MySqlParameter("@id", employeeId)
            };

            int rows = db.ExecuteNonQuery(sql, p);

            if (rows > 0)
            {
                MessageBox.Show("Employee updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update employee.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================================
        // CANCEL BUTTON
        // ================================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
