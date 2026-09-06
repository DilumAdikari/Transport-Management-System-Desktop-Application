using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (lblError != null)
            {
                lblError.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(Program.ConnString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT full_name, role FROM users WHERE username = @user AND password = @pass";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullName = reader["full_name"].ToString();
                                MessageBox.Show($"Login Successful! Welcome {fullName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // MainDashboard ekata navigate kirima
                                MainDashboard dashboard = new MainDashboard(fullName);
                                dashboard.Show();

                                // Login form eka hide kirima
                                this.Hide();
                            }
                            else
                            {
                                lblError.Text = "Invalid username or password!";
                                textBox2.Clear();
                                textBox2.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}