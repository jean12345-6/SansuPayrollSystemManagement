using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SansuPayrollSystemManagement
{
    public partial class TimecardControl : UserControl
    {
        private int _employeeId;
        private string _employeeName;
        private string _employeePosition;
        private decimal _dailyRate;
        private decimal _hourlyRate;

        private DateTime _periodStart;
        private DateTime _periodEnd;
        private int _periodLengthDays = 7;

        private readonly string _connectionString =
            "server=localhost;database=sansu_payroll_db;uid=root;pwd=;";

        public TimecardControl()
        {
            InitializeComponent();

            // Always fill the parent (Dashboard panel)
            this.Dock = DockStyle.Fill;

            dgvTimecard.AutoGenerateColumns = true;

            // events
            btnPrevPeriod.Click += BtnPrev_Click;
            btnNextPeriod.Click += BtnNext_Click;
            btnExportPdf.Click += BtnExportPdf_Click;
            btnClose.Click += BtnClose_Click;
        }

        // ---------------------------------------------------------
        // CLOSE / BACK
        // ---------------------------------------------------------
        private void BtnClose_Click(object sender, EventArgs e)
        {
            var dash = this.FindForm() as DashboardForm;
            if (dash != null)
            {
                dash.OpenDashboard();
                return;
            }

            this.Parent?.Controls.Remove(this);
            this.Dispose();
        }

        // ---------------------------------------------------------
        // PUBLIC API
        // ---------------------------------------------------------
        public void InitializeTimecard(
            int employeeId,
            DateTime periodStart,
            DateTime periodEnd,
            System.Drawing.Image employeePhoto = null)
        {
            _employeeId = employeeId;
            _periodStart = periodStart.Date;
            _periodEnd = periodEnd.Date;

            _periodLengthDays = (_periodEnd - _periodStart).Days + 1;
            if (_periodLengthDays <= 0)
                _periodLengthDays = 7;

            if (employeePhoto != null)
                picEmployeePhoto.Image = employeePhoto;

            LoadEmployeeInfo();
            UpdateHeaderLabels();
            LoadTimecardData();
        }

        // ---------------------------------------------------------
        // LOAD EMPLOYEE INFO
        // ---------------------------------------------------------
        private void LoadEmployeeInfo()
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                string sql =
                @"SELECT FullName, Position, COALESCE(DailyRate, 550) AS DailyRate
                  FROM Employees
                  WHERE EmployeeID = @EmployeeID";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", _employeeId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _employeeName = reader["FullName"].ToString();
                            _employeePosition = reader["Position"].ToString();
                            _dailyRate = Convert.ToDecimal(reader["DailyRate"]);
                            _hourlyRate = _dailyRate / 8m;
                        }
                    }
                }
            }

            lblEmployeeName.Text = $"{_employeeName} – {_employeePosition}";
        }

        private void UpdateHeaderLabels()
        {
            lblDateRange.Text =
                $"{_periodStart:MMM dd, yyyy} – {_periodEnd:MMM dd, yyyy}";
        }

        // ---------------------------------------------------------
        // LOAD TIME CARD
        // ---------------------------------------------------------
        private void LoadTimecardData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Day", typeof(string));
            table.Columns.Add("RegularHours", typeof(decimal));
            table.Columns.Add("OvertimeHours", typeof(decimal));
            table.Columns.Add("SickHours", typeof(decimal));
            table.Columns.Add("VacationHours", typeof(decimal));
            table.Columns.Add("HolidayHours", typeof(decimal));
            table.Columns.Add("UnpaidLeaveHours", typeof(decimal));
            table.Columns.Add("OtherHours", typeof(decimal));
            table.Columns.Add("TotalHours", typeof(decimal));

            DataTable raw = GetAttendanceForPeriod(_employeeId, _periodStart, _periodEnd);

            for (DateTime d = _periodStart; d <= _periodEnd; d = d.AddDays(1))
            {
                DataRow row = table.NewRow();
                row["Day"] = $"{d:ddd MM/dd}";

                DataRow[] logs = raw.Select($"Date = '{d:yyyy-MM-dd}'");

                decimal totalHours = 0m;
                string status = "";

                if (logs.Length > 0)
                {
                    DataRow log = logs[0];
                    status = log["Status"]?.ToString() ?? "";

                    DateTime? timeIn = log["TimeIn"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(log["TimeIn"]);

                    DateTime? timeOut = log["TimeOut"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(log["TimeOut"]);

                    if (timeIn != null && timeOut != null)
                    {
                        double minutes = (timeOut.Value - timeIn.Value).TotalMinutes;
                        if (minutes < 0) minutes = 0;
                        totalHours = (decimal)(minutes / 60d);
                    }
                }

                decimal reg = 0, ot = 0, sick = 0, vac = 0, hol = 0, unpaid = 0, other = 0;
                string s = status.Trim().ToLower();

                if (s == "" || s == "present" || s == "late")
                {
                    reg = Math.Min(totalHours, 8m);
                    ot = Math.Max(0m, totalHours - 8m);
                }
                else if (s == "sick") sick = 8m;
                else if (s == "vacation") vac = 8m;
                else if (s == "holiday") hol = totalHours > 0 ? totalHours : 8m;
                else if (s == "unpaid") unpaid = 8m;
                else if (s == "absent")
                {
                    // zero everything
                }
                else
                {
                    reg = Math.Min(totalHours, 8m);
                    ot = Math.Max(0m, totalHours - 8m);
                }

                decimal total = reg + ot + sick + vac + hol + unpaid + other;

                row["RegularHours"] = reg;
                row["OvertimeHours"] = ot;
                row["SickHours"] = sick;
                row["VacationHours"] = vac;
                row["HolidayHours"] = hol;
                row["UnpaidLeaveHours"] = unpaid;
                row["OtherHours"] = other;
                row["TotalHours"] = total;

                table.Rows.Add(row);
            }

            dgvTimecard.DataSource = table;

            ComputeTotals(table);
        }

        private DataTable GetAttendanceForPeriod(int employeeId, DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();

            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                string sql =
                @"SELECT AttendanceID, EmployeeID, Date, TimeIn, TimeOut, Status
                  FROM Attendance
                  WHERE EmployeeID = @ID
                  AND Date BETWEEN @S AND @E
                  ORDER BY Date";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", employeeId);
                    cmd.Parameters.AddWithValue("@S", start);
                    cmd.Parameters.AddWithValue("@E", end);

                    using (var ad = new MySqlDataAdapter(cmd))
                    {
                        ad.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // ---------------------------------------------------------
        // TOTALS
        // ---------------------------------------------------------
        private void ComputeTotals(DataTable table)
        {
            decimal totalReg = 0, totalOT = 0, totalHours = 0;

            foreach (DataRow r in table.Rows)
            {
                totalReg += r.Field<decimal>("RegularHours");
                totalOT += r.Field<decimal>("OvertimeHours");
                totalHours += r.Field<decimal>("TotalHours");
            }

            decimal totalPay = totalHours * _hourlyRate;

            lblTotalRegularHours.Text = totalReg.ToString("0.##");
            lblTotalOvertimeHours.Text = totalOT.ToString("0.##");
            lblTotalHoursReported.Text = totalHours.ToString("0.##");
            lblTotalPay.Text = $"₱{totalPay:0,0.00}";
        }

        // ---------------------------------------------------------
        // NAVIGATION BUTTONS
        // ---------------------------------------------------------
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            _periodStart = _periodStart.AddDays(-_periodLengthDays);
            _periodEnd = _periodEnd.AddDays(-_periodLengthDays);

            UpdateHeaderLabels();
            LoadTimecardData();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _periodStart = _periodStart.AddDays(_periodLengthDays);
            _periodEnd = _periodEnd.AddDays(_periodLengthDays);

            UpdateHeaderLabels();
            LoadTimecardData();
        }

        // ---------------------------------------------------------
        // PDF EXPORT
        // ---------------------------------------------------------
        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvTimecard.DataSource == null)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog s = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = $"{_employeeName}_Timecard_{_periodStart:yyyyMMdd}_{_periodEnd:yyyyMMdd}.pdf"
            };

            if (s.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToPdf(s.FileName);
                    MessageBox.Show("Exported successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF:\n" + ex.Message);
                }
            }
        }

        private void ExportToPdf(string path)
        {
            Document doc = new Document(PageSize.A4, 36, 36, 36, 36);

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                Paragraph t = new Paragraph("Weekly Employee Timesheet\n\n", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(t);

                Paragraph info = new Paragraph(
                    $"Employee: {_employeeName}\n" +
                    $"Position: {_employeePosition}\n" +
                    $"Period: {_periodStart:MMM dd, yyyy} – {_periodEnd:MMM dd, yyyy}\n\n",
                    normalFont);
                doc.Add(info);

                PdfPTable pdfTable = new PdfPTable(dgvTimecard.Columns.Count)
                {
                    WidthPercentage = 100
                };

                foreach (DataGridViewColumn c in dgvTimecard.Columns)
                {
                    pdfTable.AddCell(new PdfPCell(new Phrase(c.HeaderText, normalFont))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });
                }

                foreach (DataGridViewRow r in dgvTimecard.Rows)
                {
                    if (r.IsNewRow) continue;

                    foreach (DataGridViewCell c in r.Cells)
                    {
                        pdfTable.AddCell(new PdfPCell(new Phrase(c.Value?.ToString() ?? "", normalFont))
                        {
                            HorizontalAlignment = Element.ALIGN_CENTER
                        });
                    }
                }

                Paragraph totals = new Paragraph(
                    $"\nTotal Regular Hours: {lblTotalRegularHours.Text}\n" +
                    $"Total Overtime Hours: {lblTotalOvertimeHours.Text}\n" +
                    $"Total Hours: {lblTotalHoursReported.Text}\n" +
                    $"Total Pay: {lblTotalPay.Text}\n\n",
                    normalFont);
                doc.Add(pdfTable);
                doc.Add(totals);

                Paragraph sig = new Paragraph(
                    "\nEmployee Signature: ____________________________   Date: _________\n" +
                    "Supervisor Signature: __________________________   Date: _________\n",
                    normalFont);
                doc.Add(sig);

                doc.Close();
                writer.Close();
            }
        }

        private void TimecardControl_Load(object sender, EventArgs e)
        {
            // nothing extra for now
        }
    }
}
