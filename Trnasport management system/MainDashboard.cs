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

        private void ShowGrid()
        {
            dgvData.Visible = true;
            pnlNewRequest.Visible = false;
        }

        private void LoadVehicles()
        {
            ShowGrid();
            lblSectionTitle.Text = "Vehicle Fleet";
            LoadData("SELECT id AS 'ID', vehicle_number AS 'Vehicle No', vehicle_type AS 'Type', capacity AS 'Capacity', status AS 'Status' FROM vehicles");
        }

        private void LoadDrivers()
        {
            ShowGrid();
            lblSectionTitle.Text = "Drivers Fleet";
            LoadData("SELECT id AS 'ID', driver_name AS 'Driver Name', phone AS 'Contact No', license_no AS 'License No', status AS 'Status' FROM drivers");
        }

        private void LoadTours()
        {
            ShowGrid();
            lblSectionTitle.Text = "Tour Requests";
            LoadData("SELECT id AS 'Req ID', department AS 'Department', from_location AS 'From', to_location AS 'To', request_date AS 'Date', request_time AS 'Time', remark AS 'Remark', status AS 'Status' FROM tour_requests ORDER BY id DESC");
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

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            dgvData.Visible = false;
            pnlNewRequest.Visible = true;
            lblSectionTitle.Text = "Create New Transport Request";
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            string dept = txtDepartment.Text.Trim();
            string fromLoc = txtFrom.Text.Trim();
            string toLoc = txtTo.Text.Trim();
            string reqDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string reqTime = txtTime.Text.Trim();
            string remark = txtRemark.Text.Trim();

            if (string.IsNullOrEmpty(dept) || string.IsNullOrEmpty(fromLoc) || string.IsNullOrEmpty(toLoc) || string.IsNullOrEmpty(reqTime))
            {
                MessageBox.Show("Please fill Department, From, To, and Time fields!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tour_requests (department, from_location, to_location, request_date, request_time, remark, status) " +
                                   "VALUES (@dept, @from, @to, @date, @time, @remark, 'Pending')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dept", dept);
                        cmd.Parameters.AddWithValue("@from", fromLoc);
                        cmd.Parameters.AddWithValue("@to", toLoc);
                        cmd.Parameters.AddWithValue("@date", reqDate);
                        cmd.Parameters.AddWithValue("@time", reqTime);
                        cmd.Parameters.AddWithValue("@remark", remark);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transport request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear inputs
                        txtDepartment.Clear();
                        txtFrom.Clear();
                        txtTo.Clear();
                        txtTime.Clear();
                        txtRemark.Clear();

                        // Form submit unata passe request table ekata navigate wenawa
                        LoadTours();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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