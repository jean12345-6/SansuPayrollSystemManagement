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
    public partial class FingerprintEnrollForm : Form
    {
        private int employeeId;
        private byte[] capturedTemplate;
        private DBHelper db = new DBHelper();
        private FingerprintService fpService = new FingerprintService();

        public FingerprintEnrollForm(int empId, string empName)
        {
            InitializeComponent();
            employeeId = empId;
            lblEmployeeName.Text = $"Employee: {empName}";
            lblStatus.Text = "No fingerprint enrolled yet.";
        }
        public FingerprintEnrollForm()
        {
            InitializeComponent();
        }

        private void FingerprintEnrollForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            try
            {
                capturedTemplate = fpService.CaptureTemplate(); // placeholder until SDK integration
                lblStatus.Text = "Fingerprint captured successfully!";
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("Fingerprint capture not implemented. Replace FingerprintService later.",
                    "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                capturedTemplate = new byte[] { 0x01, 0x02, 0x03 }; // simulate stored fingerprint data
                lblStatus.Text = "Simulated fingerprint captured.";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (capturedTemplate == null)
            {
                MessageBox.Show("Please capture a fingerprint first.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE Employees SET FingerprintTemplate=@fp WHERE EmployeeID=@id";
            MySqlParameter[] p = {
                new MySqlParameter("@fp", capturedTemplate),
                new MySqlParameter("@id", employeeId)
            };

            int result = db.ExecuteNonQuery(sql, p);
            if (result > 0)
            {
                MessageBox.Show("Fingerprint enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save fingerprint.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
