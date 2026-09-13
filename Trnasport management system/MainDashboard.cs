using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TransportManagementSystem;

namespace Trnasport_management_system
{
    public partial class MainDashboard : Form
    {
        private string currentUser = "";

        // Status Counts for Chart
        private int countPending = 0;
        private int countApproved = 0;
        private int countRejected = 0;

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

                    // Card 1: Total Vehicles
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM vehicles", conn))
                    {
                        object res = cmd.ExecuteScalar();
                        lblVehCount.Text = res != null ? res.ToString() : "0";
                    }

                    // Card 2: Total Drivers
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM drivers", conn))
                    {
                        object res = cmd.ExecuteScalar();
                        lblDrivCount.Text = res != null ? res.ToString() : "0";
                    }

                    // Card 3: Total Tours
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tour_requests", conn))
                    {
                        object res = cmd.ExecuteScalar();
                        lblTourCount.Text = res != null ? res.ToString() : "0";
                    }

                    // Chart Status Counts
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tour_requests WHERE status = 'Pending'", conn))
                    {
                        object res = cmd.ExecuteScalar();
                        countPending = res != null ? Convert.ToInt32(res) : 0;
                    }

                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tour_requests WHERE status = 'Approved'", conn))
                    {
                        object res = cmd.ExecuteScalar();
                        countApproved = res != null ? Convert.ToInt32(res) : 0;
                    }

                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tour_requests WHERE status = 'Rejected'", conn))
                    {
                        object res = cmd.ExecuteScalar();
                        countRejected = res != null ? Convert.ToInt32(res) : 0;
                    }

                    // Recent 5 Tours Table Data
                    string queryRecent = @"SELECT 
                                            id AS 'ID', 
                                            department AS 'Dept', 
                                            to_location AS 'Destination', 
                                            status AS 'Status' 
                                           FROM tour_requests 
                                           ORDER BY id DESC 
                                           LIMIT 5";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(queryRecent, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRecentTours.DataSource = dt;
                    }

                    // Redraw the Donut Chart Panel
                    pnlChart.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Custom GDI+ Donut Chart Paint Event
        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int total = countPending + countApproved + countRejected;
            Rectangle rectChart = new Rectangle(70, 60, 190, 190);

            if (total == 0)
            {
                using (Pen emptyPen = new Pen(Color.FromArgb(230, 230, 230), 22))
                {
                    g.DrawEllipse(emptyPen, rectChart);
                }
                using (Font f = new Font("Segoe UI", 10F, FontStyle.Regular))
                using (Brush b = new SolidBrush(Color.Gray))
                {
                    g.DrawString("No Tour Data", f, b, new PointF(120, 145));
                }
                return;
            }

            float sweepApproved = (countApproved / (float)total) * 360f;
            float sweepPending = (countPending / (float)total) * 360f;
            float sweepRejected = (countRejected / (float)total) * 360f;

            float startAngle = -90f;

            // Draw Approved Arc (Green)
            using (Pen penApp = new Pen(Color.FromArgb(40, 167, 69), 24))
            {
                if (sweepApproved > 0) g.DrawArc(penApp, rectChart, startAngle, sweepApproved);
                startAngle += sweepApproved;
            }

            // Draw Pending Arc (Gold/Yellow)
            using (Pen penPend = new Pen(Color.FromArgb(255, 193, 7), 24))
            {
                if (sweepPending > 0) g.DrawArc(penPend, rectChart, startAngle, sweepPending);
                startAngle += sweepPending;
            }

            // Draw Rejected Arc (Red)
            using (Pen penRej = new Pen(Color.FromArgb(220, 53, 69), 24))
            {
                if (sweepRejected > 0) g.DrawArc(penRej, rectChart, startAngle, sweepRejected);
            }

            // Center Text inside Donut
            using (Font fNum = new Font("Segoe UI", 20F, FontStyle.Bold))
            using (Font fSub = new Font("Segoe UI", 9F, FontStyle.Regular))
            using (Brush bText = new SolidBrush(Color.FromArgb(50, 50, 50)))
            using (Brush bSub = new SolidBrush(Color.Gray))
            {
                string sTotal = total.ToString();
                SizeF sizeNum = g.MeasureString(sTotal, fNum);
                g.DrawString(sTotal, fNum, bText, rectChart.X + (rectChart.Width - sizeNum.Width) / 2, rectChart.Y + 60);
                g.DrawString("Total Tours", fSub, bSub, rectChart.X + 60, rectChart.Y + 105);
            }

            // Bottom Legend Items
            int legendY = 280;
            DrawLegendItem(g, 35, legendY, Color.FromArgb(40, 167, 69), $"Approved: {countApproved}");
            DrawLegendItem(g, 35, legendY + 35, Color.FromArgb(255, 193, 7), $"Pending: {countPending}");
            DrawLegendItem(g, 35, legendY + 70, Color.FromArgb(220, 53, 69), $"Rejected: {countRejected}");
        }

        private void DrawLegendItem(Graphics g, int x, int y, Color c, string text)
        {
            using (Brush bCircle = new SolidBrush(c))
            {
                g.FillEllipse(bCircle, x, y + 2, 14, 14);
            }
            using (Font f = new Font("Segoe UI", 10F, FontStyle.Regular))
            using (Brush bText = new SolidBrush(Color.FromArgb(60, 60, 60)))
            {
                g.DrawString(text, f, bText, x + 24, y);
            }
        }

        // Sub Forms panel eka athulata load karana method eka
        public void LoadSubForm(Form subForm)
        {
            pnlHomeOverview.Visible = false;

            // Content eke thiyena active forms dispose karala ain kirima
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