using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class TourRequestsForm : Form
    {
        private int selectedRequestId = -1;

        public TourRequestsForm()
        {
            InitializeComponent();
        }

        private void TourRequestsForm_Load(object sender, EventArgs e)
        {
            LoadTours();
            LoadDropdownData();
        }

        public void LoadTours()
        {
            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
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
                                     ORDER BY t.id DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTours.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDropdownData()
        {
            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();

                    // Available Vehicles load kirima
                    MySqlCommand cmdVeh = new MySqlCommand("SELECT id, CONCAT(vehicle_number, ' - ', vehicle_type) AS display_name FROM vehicles WHERE status = 'Available'", conn);
                    MySqlDataAdapter daVeh = new MySqlDataAdapter(cmdVeh);
                    DataTable dtVeh = new DataTable();
                    daVeh.Fill(dtVeh);
                    cmbVehicles.DataSource = dtVeh;
                    cmbVehicles.DisplayMember = "display_name";
                    cmbVehicles.ValueMember = "id";

                    // Available Drivers load kirima
                    MySqlCommand cmdDriv = new MySqlCommand("SELECT id, driver_name FROM drivers WHERE status = 'Available'", conn);
                    MySqlDataAdapter daDriv = new MySqlDataAdapter(cmdDriv);
                    DataTable dtDriv = new DataTable();
                    daDriv.Fill(dtDriv);
                    cmbDrivers.DataSource = dtDriv;
                    cmbDrivers.DisplayMember = "driver_name";
                    cmbDrivers.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load vehicles/drivers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTours.Rows[e.RowIndex];
                selectedRequestId = Convert.ToInt32(row.Cells["Req ID"].Value);
                string dept = row.Cells["Department"].Value?.ToString() ?? "";
                string to = row.Cells["To"].Value?.ToString() ?? "";
                string status = row.Cells["Status"].Value?.ToString() ?? "";

                lblSelectedReq.Text = $"Selected Request ID: {selectedRequestId} ({dept} to {to}) - Status: {status}";
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (selectedRequestId == -1)
            {
                MessageBox.Show("Please select a tour request from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbVehicles.SelectedValue == null || cmbDrivers.SelectedValue == null)
            {
                MessageBox.Show("Please select both an Available Vehicle and a Driver.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int vehicleId = Convert.ToInt32(cmbVehicles.SelectedValue);
            int driverId = Convert.ToInt32(cmbDrivers.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE tour_requests SET vehicle_id = @vId, driver_id = @dId, status = 'Approved' WHERE id = @reqId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@vId", vehicleId);
                        cmd.Parameters.AddWithValue("@dId", driverId);
                        cmd.Parameters.AddWithValue("@reqId", selectedRequestId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Vehicle & Driver assigned! Tour Approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedRequestId = -1;
                        lblSelectedReq.Text = "Select a Pending Tour Request from the table";
                        LoadTours();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (selectedRequestId == -1)
            {
                MessageBox.Show("Please select a tour request from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to reject this tour request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE tour_requests SET status = 'Rejected' WHERE id = @reqId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@reqId", selectedRequestId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Tour Request marked as Rejected.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectedRequestId = -1;
                            lblSelectedReq.Text = "Select a Pending Tour Request from the table";
                            LoadTours();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}