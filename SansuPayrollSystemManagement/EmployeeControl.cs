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
        public EmployeeControl()
        {
            InitializeComponent();
            CustomizeGridAppearance();
            LoadEmployees();
            AddActionButtons();

            dgvEmployees.CellPainting += dgvEmployees_CellPainting;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
        }

        // -------------------------------------------------------------------
        // LOAD EMPLOYEES
        // -------------------------------------------------------------------
        private void LoadEmployees()
        {
            string sql = "SELECT EmployeeID, FullName, Position, ContactInfo, Salary FROM Employees";
            DBHelper db = new DBHelper();
            dgvEmployees.DataSource = db.GetData(sql);
        }

        // -------------------------------------------------------------------
        // ADD BUTTON COLUMNS
        // -------------------------------------------------------------------
        private void AddActionButtons()
        {
            // View
            if (!dgvEmployees.Columns.Contains("View"))
            {
                DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
                viewBtn.Name = "View";
                viewBtn.HeaderText = "View";
                viewBtn.Text = "View";
                viewBtn.UseColumnTextForButtonValue = true;
                dgvEmployees.Columns.Add(viewBtn);
            }

            // Edit
            if (!dgvEmployees.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.Name = "Edit";
                editBtn.HeaderText = "Edit";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;
                dgvEmployees.Columns.Add(editBtn);
            }

            // Delete
            if (!dgvEmployees.Columns.Contains("Archive"))
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.Name = "Archive";
                deleteBtn.HeaderText = "Archive";
                deleteBtn.Text = "Archive";
                deleteBtn.UseColumnTextForButtonValue = true;
                dgvEmployees.Columns.Add(deleteBtn);
            }
        }

        // -------------------------------------------------------------------
        // CUSTOM PAINT BUTTONS
        // -------------------------------------------------------------------
        private void dgvEmployees_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string col = dgvEmployees.Columns[e.ColumnIndex].Name;

            if (col == "View")
                PaintButton(e, Color.FromArgb(66, 133, 244), "View"); // Blue

            if (col == "Edit")
                PaintButton(e, Color.FromArgb(251, 188, 5), "Edit"); // Yellow

            if (col == "Archive")
                PaintButton(e, Color.FromArgb(234, 67, 53), "Archive"); // Red
        }

        private void PaintButton(DataGridViewCellPaintingEventArgs e, Color color, string text)
        {
            e.PaintBackground(e.ClipBounds, true);

            e.Graphics.FillRectangle(new SolidBrush(color),
                e.CellBounds.Left + 5,
                e.CellBounds.Top + 10,
                e.CellBounds.Width - 10,
                e.CellBounds.Height - 20);

            TextRenderer.DrawText(
                e.Graphics,
                text,
                new Font("Segoe UI", 9F, FontStyle.Bold),
                new Rectangle(
                    e.CellBounds.Left + 5,
                    e.CellBounds.Top + 10,
                    e.CellBounds.Width - 10,
                    e.CellBounds.Height - 20),
                Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

            e.Handled = true;
        }

        // -------------------------------------------------------------------
        // BUTTON CLICK HANDLER
        // -------------------------------------------------------------------
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string col = dgvEmployees.Columns[e.ColumnIndex].Name;

            if (col == "View")
            {
                int id = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                ViewEmployee(id);
            }
            else if (col == "Edit")
            {
                int id = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                EditEmployee(id);
            }
            else if (col == "Archive")  // now archive
            {
                ArchiveEmployee(e.RowIndex);
            }
        }

        // -------------------------------------------------------------------
        // BUTTON ACTION METHODS
        // -------------------------------------------------------------------
        private void ViewEmployee(int id)
        {
            AddEmployeeForm viewForm = new AddEmployeeForm(id);
            viewForm.ShowDialog();
        }

        private void EditEmployee(int id)
        {
            AddEmployeeForm editForm = new AddEmployeeForm(id);
            if (editForm.ShowDialog() == DialogResult.OK)
                LoadEmployees();
        }

        private void ArchiveEmployee(int rowIndex)
        {
            DialogResult result = MessageBox.Show(
                "Archive this employee from the list? (This will NOT delete from database)",
                "Archive Employee",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvEmployees.Rows.RemoveAt(rowIndex);
            }
        }

        // -------------------------------------------------------------------
        // UI STYLING – Modern Web Style
        // -------------------------------------------------------------------
        private void CustomizeGridAppearance()
        {
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.EnableHeadersVisualStyles = false;

            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvEmployees.ColumnHeadersHeight = 45;

            dgvEmployees.DefaultCellStyle.BackColor = Color.White;
            dgvEmployees.DefaultCellStyle.ForeColor = Color.Black;
            dgvEmployees.DefaultCellStyle.Font = new Font("Segoe UI", 11F);
            dgvEmployees.DefaultCellStyle.Padding = new Padding(5, 8, 5, 8);

            dgvEmployees.RowTemplate.Height = 50;

            dgvEmployees.GridColor = Color.FromArgb(230, 230, 230);

            dgvEmployees.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvEmployees.RowHeadersVisible = false;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addForm = new AddEmployeeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
                LoadEmployees();
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeControl_Load_1(object sender, EventArgs e)
        {

        }
        private void GoBackToDashboard()
        {
            // Find the parent DashboardForm
            Form parent = this.FindForm();

            if (parent is DashboardForm dashboard)
            {
                dashboard.OpenDashboard(); // Call the method that loads the dashboard
            }
        }


        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            GoBackToDashboard();
        }
    }
}