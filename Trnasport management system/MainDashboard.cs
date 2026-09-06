using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class MainDashboard : Form
    {
        private string currentUser = "";

        public MainDashboard(string username = "Admin")
        {
            InitializeComponent();
            currentUser = username;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + currentUser;
            LoadVehicles(); // Default load vehicles
        }

        private void LoadVehicles()
        {
            lblSectionTitle.Text = "Vehicle Fleet";
            LoadData("SELECT id AS 'ID', vehicle_number AS 'Vehicle No', vehicle_type AS 'Type', capacity AS 'Capacity', status AS 'Status' FROM vehicles");
        }

        private void LoadDrivers()
        {
            lblSectionTitle.Text = "Drivers Fleet";
            LoadData("SELECT id AS 'ID', driver_name AS 'Driver Name', phone AS 'Contact No', license_no AS 'License No', status AS 'Status' FROM drivers");
        }

        private void LoadTours()
        {
            lblSectionTitle.Text = "Tour Bookings";
            LoadData("SELECT t.id AS 'Tour ID', t.customer_name AS 'Customer', t.pickup_location AS 'Pickup', t.destination AS 'Destination', t.request_date AS 'Date', v.vehicle_number AS 'Vehicle', d.driver_name AS 'Driver', t.status AS 'Status' " +
                     "FROM tour_requests t " +
                     "LEFT JOIN vehicles v ON t.vehicle_id = v.id " +
                     "LEFT JOIN drivers d ON t.driver_id = d.id");
        }

        private void LoadData(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvData.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        private void btnTours_Click(object sender, EventArgs e)
        {
            LoadTours();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}