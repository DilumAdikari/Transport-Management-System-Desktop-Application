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
            currentUser = string.IsNullOrWhiteSpace(username) ? "Admin" : username;
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
                    {
                        object res = cmd.ExecuteScalar();
                        lblVehCount.Text = res != null ? res.ToString() : "0";
                    }

                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM drivers", conn))
                    {
                        object res = cmd.ExecuteScalar();
                        lblDrivCount.Text = res != null ? res.ToString() : "0";
                    }

                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tour_requests", conn))
                    {
                        object res = cmd.ExecuteScalar();
                        lblTourCount.Text = res != null ? res.ToString() : "0";
                    }
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

            // Content eke thiyena anith active forms clear kirima
            for (int i = pnlContent.Controls.Count - 1; i >= 0; i--)
            {
                Control ctrl = pnlContent.Controls[i];
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
        private void btnNewRequest_Click(object sender, EventArgs e) => LoadSubForm(new NewRequestForm(this));
        private void btnTours_Click(object sender, EventArgs e) => LoadSubForm(new TourRequestsForm());
        private void btnVehicles_Click(object sender, EventArgs e) => LoadSubForm(new VehiclesForm());
        private void btnDrivers_Click(object sender, EventArgs e) => LoadSubForm(new DriversForm());
        private void btnUsers_Click(object sender, EventArgs e) => LoadSubForm(new UsersForm());

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