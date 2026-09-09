using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class VehiclesForm : Form
    {
        public VehiclesForm() => InitializeComponent();

        private void VehiclesForm_Load(object sender, EventArgs e) => LoadVehicles();

        private void LoadVehicles()
        {
            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT id AS 'ID', vehicle_number AS 'Vehicle No', vehicle_type AS 'Type', capacity AS 'Capacity', status AS 'Status' FROM vehicles", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVehicles.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string no = txtVehNo.Text.Trim();
            string type = txtType.Text.Trim();
            if (string.IsNullOrEmpty(no) || string.IsNullOrEmpty(type) || !int.TryParse(txtCap.Text.Trim(), out int cap))
            {
                MessageBox.Show("Please fill all fields properly!", "Validation Error");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO vehicles (vehicle_number, vehicle_type, capacity, status) VALUES (@no, @type, @cap, 'Available')", conn))
                    {
                        cmd.Parameters.AddWithValue("@no", no);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@cap", cap);
                        cmd.ExecuteNonQuery();
                    }
                    txtVehNo.Clear();
                    txtType.Clear();
                    txtCap.Clear();
                    LoadVehicles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message);
                }
            }
        }
    }
}