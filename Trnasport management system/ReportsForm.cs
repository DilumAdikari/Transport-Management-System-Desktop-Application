using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dgvReport.AllowUserToAddRows = false;
            dgvReport.RowHeadersVisible = false;
            dgvReport.CellFormatting += dgvReport_CellFormatting;

            LoadFilterDropdowns();
            LoadReportData(); // Load all data initially
        }

        private void LoadFilterDropdowns()
        {
            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();

                    // 1. Vehicle Dropdown (with "All Vehicles" option)
                    MySqlCommand cmdVeh = new MySqlCommand("SELECT id, CONCAT(vehicle_number, ' - ', vehicle_type) AS display_name FROM vehicles", conn);
                    MySqlDataAdapter daVeh = new MySqlDataAdapter(cmdVeh);
                    DataTable dtVeh = new DataTable();
                    daVeh.Fill(dtVeh);

                    DataRow drVeh = dtVeh.NewRow();
                    drVeh["id"] = 0;
                    drVeh["display_name"] = "-- All Vehicles --";
                    dtVeh.Rows.InsertAt(drVeh, 0);

                    cmbFilterVehicle.DataSource = dtVeh;
                    cmbFilterVehicle.DisplayMember = "display_name";
                    cmbFilterVehicle.ValueMember = "id";

                    // 2. Driver Dropdown (with "All Drivers" option)
                    MySqlCommand cmdDriv = new MySqlCommand("SELECT id, driver_name FROM drivers", conn);
                    MySqlDataAdapter daDriv = new MySqlDataAdapter(cmdDriv);
                    DataTable dtDriv = new DataTable();
                    daDriv.Fill(dtDriv);

                    DataRow drDriv = dtDriv.NewRow();
                    drDriv["id"] = 0;
                    drDriv["driver_name"] = "-- All Drivers --";
                    dtDriv.Rows.InsertAt(drDriv, 0);

                    cmbFilterDriver.DataSource = dtDriv;
                    cmbFilterDriver.DisplayMember = "driver_name";
                    cmbFilterDriver.ValueMember = "id";

                    // 3. Status Dropdown
                    if (cmbFilterStatus != null)
                    {
                        cmbFilterStatus.Items.Clear();
                        cmbFilterStatus.Items.AddRange(new object[] { "-- All Status --", "Approved", "Pending", "Rejected" });
                        cmbFilterStatus.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading filters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadReportData()
        {
            int selectedVehicleId = Convert.ToInt32(cmbFilterVehicle.SelectedValue ?? 0);
            int selectedDriverId = Convert.ToInt32(cmbFilterDriver.SelectedValue ?? 0);
            string selectedStatus = cmbFilterStatus != null ? cmbFilterStatus.SelectedItem?.ToString() ?? "-- All Status --" : "-- All Status --";

            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();

                    // Base Dynamic Query
                    string query = @"SELECT 
                                        t.id AS 'Req ID', 
                                        t.department AS 'Department', 
                                        t.from_location AS 'From', 
                                        t.to_location AS 'To', 
                                        t.request_date AS 'Date', 
                                        t.request_time AS 'Time', 
                                        IFNULL(v.vehicle_number, 'Not Assigned') AS 'Vehicle', 
                                        IFNULL(d.driver_name, 'Not Assigned') AS 'Driver', 
                                        t.status AS 'Status' 
                                     FROM tour_requests t
                                     LEFT JOIN vehicles v ON t.vehicle_id = v.id
                                     LEFT JOIN drivers d ON t.driver_id = d.id
                                     WHERE 1=1 ";

                    if (selectedVehicleId > 0)
                    {
                        query += " AND t.vehicle_id = @vId";
                    }

                    if (selectedDriverId > 0)
                    {
                        query += " AND t.driver_id = @dId";
                    }

                    if (!selectedStatus.Equals("-- All Status --", StringComparison.OrdinalIgnoreCase))
                    {
                        query += " AND t.status = @status";
                    }

                    query += " ORDER BY t.id DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (selectedVehicleId > 0) cmd.Parameters.AddWithValue("@vId", selectedVehicleId);
                        if (selectedDriverId > 0) cmd.Parameters.AddWithValue("@dId", selectedDriverId);
                        if (!selectedStatus.Equals("-- All Status --", StringComparison.OrdinalIgnoreCase)) cmd.Parameters.AddWithValue("@status", selectedStatus);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvReport.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Color coding for report rows
        private void dgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReport.Columns[e.ColumnIndex].Name.Equals("Status", StringComparison.OrdinalIgnoreCase) ||
                dgvReport.Columns[e.ColumnIndex].HeaderText.Equals("Status", StringComparison.OrdinalIgnoreCase))
            {
                DataGridViewRow row = dgvReport.Rows[e.RowIndex];
                string status = row.Cells[e.ColumnIndex].Value?.ToString()?.Trim() ?? "";

                if (string.Equals(status, "Approved", StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 218);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(21, 87, 36);
                }
                else if (string.Equals(status, "Rejected", StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(114, 28, 36);
                }
                else if (string.Equals(status, "Pending", StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(133, 100, 4);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbFilterVehicle.SelectedIndex = 0;
            cmbFilterDriver.SelectedIndex = 0;
            if (cmbFilterStatus != null) cmbFilterStatus.SelectedIndex = 0;
            LoadReportData();
        }
    }
}