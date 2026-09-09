using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class NewRequestForm : Form
    {
        private MainDashboard parentDashboard;

        public NewRequestForm(MainDashboard parent)
        {
            InitializeComponent();
            this.parentDashboard = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dept = txtDept.Text.Trim();
            string from = txtFrom.Text.Trim();
            string to = txtTo.Text.Trim();
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string time = txtTime.Text.Trim();
            string remark = txtRemark.Text.Trim();

            if (string.IsNullOrEmpty(dept) || string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("Please fill all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.Parameters.AddWithValue("@remark", remark);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Auto navigate back to TourRequestsForm
                    parentDashboard.LoadSubForm(new TourRequestsForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}