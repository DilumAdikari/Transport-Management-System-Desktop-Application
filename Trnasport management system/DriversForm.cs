using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class DriversForm : Form
    {
        public DriversForm() => InitializeComponent();

        private void DriversForm_Load(object sender, EventArgs e) => LoadDrivers();

        private void LoadDrivers()
        {
            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT id AS 'ID', driver_name AS 'Driver Name', phone AS 'Contact No', license_no AS 'License No', status AS 'Status' FROM drivers", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDrivers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string lic = txtLicense.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(lic))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO drivers (driver_name, phone, license_no, status) VALUES (@name, @phone, @lic, 'Available')", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@lic", lic);
                        cmd.ExecuteNonQuery();
                    }
                    txtName.Clear();
                    txtPhone.Clear();
                    txtLicense.Clear();
                    LoadDrivers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message);
                }
            }
        }
    }
}