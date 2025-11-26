using MySql.Data.MySqlClient;
using SansuPayrollSystemManagement.Forms;
using SansuPayrollSystemManagement.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SansuPayrollSystemManagement
{
    public partial class EmployeeControl : UserControl
    {
        private string userRole = "employee";

        public EmployeeControl()
        {
            InitializeComponent();
            InitializeControl();
        }

        public EmployeeControl(string role)
        {
            userRole = (role ?? "").ToLower();
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            CustomizeGridAppearance();
            LoadEmployees();

            // IMPORTANT: buttons added ONLY if admin/hr
            if (IsPowerUser())
                AddActionButtons();

            ApplyRoleRestrictions();

            dgvEmployees.CellPainting += dgvEmployees_CellPainting;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
        }

        private bool IsPowerUser()
        {
            return userRole == "admin" ||
                   userRole == "administrator" ||
                   userRole == "hr" ||
                   userRole == "hr manager";
        }

        // ----------------------------------------
        // LOAD EMPLOYEES
        // ----------------------------------------
        private void LoadEmployees()
        {
            string sql;

            if (IsPowerUser())
            {
                sql = "SELECT EmployeeID, FullName, Position, ContactInfo, Salary FROM Employees";
            }
            else
            {
                sql = "SELECT EmployeeID, FullName, Position, ContactInfo FROM Employees";
            }

            dgvEmployees.DataSource = new DBHelper().GetData(sql);
        }

        // ----------------------------------------
        // ADD ACTION BUTTONS (ADMIN ONLY)
        // ----------------------------------------
        private void AddActionButtons()
        {
            if (!dgvEmployees.Columns.Contains("View"))
            {
                dgvEmployees.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "View",
                    HeaderText = "View",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                });
            }

            if (!dgvEmployees.Columns.Contains("Edit"))
            {
                dgvEmployees.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                });
            }

            if (!dgvEmployees.Columns.Contains("Archive"))
            {
                dgvEmployees.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "Archive",
                    HeaderText = "Archive",
                    Text = "Archive",
                    UseColumnTextForButtonValue = true
                });
            }
        }

        // ----------------------------------------
        // ROLE RESTRICTIONS
        // ----------------------------------------
        private void ApplyRoleRestrictions()
        {
            if (!IsPowerUser())
            {
                // Remove action columns
                if (dgvEmployees.Columns.Contains("View"))
                    dgvEmployees.Columns.Remove("View");

                if (dgvEmployees.Columns.Contains("Edit"))
                    dgvEmployees.Columns.Remove("Edit");

                if (dgvEmployees.Columns.Contains("Archive"))
                    dgvEmployees.Columns.Remove("Archive");

                // Hide salary
                if (dgvEmployees.Columns.Contains("Salary"))
                    dgvEmployees.Columns["Salary"].Visible = false;

                dgvEmployees.ClearSelection();
            }
        }

        // ----------------------------------------
        // PAINT BUTTONS
        // ----------------------------------------
        private void dgvEmployees_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || !IsPowerUser()) return;

            string col = dgvEmployees.Columns[e.ColumnIndex].Name;
            if (col != "View" && col != "Edit" && col != "Archive") return;

            Color bg = col == "View"
                ? Color.FromArgb(66, 133, 244)
                : col == "Edit"
                    ? Color.FromArgb(251, 188, 5)
                    : Color.FromArgb(234, 67, 53);

            PaintButton(e, bg, col);
        }

        private void PaintButton(DataGridViewCellPaintingEventArgs e, Color color, string text)
        {
            e.PaintBackground(e.ClipBounds, true);

            using (var brush = new SolidBrush(color))
                e.Graphics.FillRectangle(brush, e.CellBounds.Left + 5, e.CellBounds.Top + 10, e.CellBounds.Width - 10, e.CellBounds.Height - 20);

            TextRenderer.DrawText(e.Graphics, text, new Font("Segoe UI", 9F, FontStyle.Bold),
                new Rectangle(e.CellBounds.Left + 5, e.CellBounds.Top + 10, e.CellBounds.Width - 10, e.CellBounds.Height - 20),
                Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            e.Handled = true;
        }

        // ----------------------------------------
        // CLICK HANDLER
        // ----------------------------------------
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !IsPowerUser()) return;

            string col = dgvEmployees.Columns[e.ColumnIndex].Name;
            int id = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells["EmployeeID"].Value);

            if (col == "View") ViewEmployee(id);
            if (col == "Edit") EditEmployee(id);
            if (col == "Archive") ArchiveEmployee(e.RowIndex);
        }

        private void ViewEmployee(int id)
        {
            new AddEmployeeForm(id, "View").ShowDialog();
        }

        private void EditEmployee(int id)
        {
            AddEmployeeForm f = new AddEmployeeForm(id, "Edit");
            if (f.ShowDialog() == DialogResult.OK)
                LoadEmployees();
        }

        private void ArchiveEmployee(int rowIndex)
        {
            if (MessageBox.Show("Archive this employee?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                dgvEmployees.Rows.RemoveAt(rowIndex);
        }

        // ----------------------------------------
        // SEARCH
        // ----------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void SearchEmployees()
        {
            string s = txtSearch.Text.Trim();

            string sql = IsPowerUser()
                ? "SELECT EmployeeID, FullName, Position, ContactInfo, Salary FROM Employees WHERE FullName LIKE @s OR Position LIKE @s OR ContactInfo LIKE @s"
                : "SELECT EmployeeID, FullName, Position, ContactInfo FROM Employees WHERE FullName LIKE @s OR Position LIKE @s OR ContactInfo LIKE @s";

            var dt = new DBHelper().GetData(sql, new MySqlParameter[]
            {
                new MySqlParameter("@s", "%" + s + "%")
            });

            dgvEmployees.DataSource = dt;
            ApplyRoleRestrictions();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!IsPowerUser())
            {
                MessageBox.Show("You do not have permission to add employees.");
                return;
            }

            if (new AddEmployeeForm().ShowDialog() == DialogResult.OK)
                LoadEmployees();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void btnIconAttendance_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is DashboardForm form)
            {
                form.LoadPage(new AttendanceControl(userRole));
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

        private void btnIconEmployees_Click(object sender, EventArgs e)
        {
            // Already on Employees page, so do nothing or refresh
        }


        private void CustomizeGridAppearance()
        {
            dgvEmployees.BackgroundColor = Color.FromArgb(40, 40, 40);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
