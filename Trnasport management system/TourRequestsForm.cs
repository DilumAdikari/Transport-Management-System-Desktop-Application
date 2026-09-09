using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class TourRequestsForm : Form
    {
        public TourRequestsForm() => InitializeComponent();

        private void TourRequestsForm_Load(object sender, EventArgs e) => LoadTours();

        public void LoadTours()
        {
            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT id AS 'Req ID', department AS 'Department', from_location AS 'From', to_location AS 'To', request_date AS 'Date', request_time AS 'Time', remark AS 'Remark', status AS 'Status' FROM tour_requests ORDER BY id DESC", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTours.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message);
                }
            }
        }
    }
}