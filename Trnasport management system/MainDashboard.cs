using MySql.Data.MySqlClient;
using System;
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
            LoadDashboardSummary();
        }

        public void LoadDashboardSummary()
        {
            pnlHomeOverview.BringToFront();
            pnlHomeOverview.Visible = true;

            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM vehicles", conn))
                        lblVehCount.Text = cmd.ExecuteScalar().ToString();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM drivers", conn))
                        lblDrivCount.Text = cmd.ExecuteScalar().ToString();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tour_requests", conn))
                        lblTourCount.Text = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sub Forms panel eka athulata load karana method eka
        public void LoadSubForm(Form subForm)
        {
            pnlHomeOverview.Visible = false;

            // Content eke thiyena anith forms ain kirima
            foreach (Control ctrl in pnlContent.Controls)
            {
                if (ctrl != pnlHomeOverview)
                {
                    pnlContent.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }

            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(subForm);
            pnlContent.Tag = subForm;
            subForm.Show();
            subForm.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e) => LoadDashboardSummary();
        private void btnVehicles_Click(object sender, EventArgs e) => LoadSubForm(new VehiclesForm());
        private void btnDrivers_Click(object sender, EventArgs e) => LoadSubForm(new DriversForm());
        private void btnTours_Click(object sender, EventArgs e) => LoadSubForm(new TourRequestsForm());
        private void btnNewRequest_Click(object sender, EventArgs e) => LoadSubForm(new NewRequestForm(this));

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