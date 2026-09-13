namespace Trnasport_management_system
{
    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnUsers = new Button();
            btnDrivers = new Button();
            btnVehicles = new Button();
            btnTours = new Button();
            btnNewRequest = new Button();
            btnHome = new Button();
            lblBrand = new Label();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            pnlContent = new Panel();
            pnlHomeOverview = new Panel();
            cardTours = new Panel();
            lblTourCount = new Label();
            lblTourTitle = new Label();
            cardDrivers = new Panel();
            lblDrivCount = new Label();
            lblDrivTitle = new Label();
            cardVehicles = new Panel();
            lblVehCount = new Label();
            lblVehTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlHomeOverview.SuspendLayout();
            cardTours.SuspendLayout();
            cardDrivers.SuspendLayout();
            cardVehicles.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(33, 37, 41);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnUsers);
            pnlSidebar.Controls.Add(btnDrivers);
            pnlSidebar.Controls.Add(btnVehicles);
            pnlSidebar.Controls.Add(btnTours);
            pnlSidebar.Controls.Add(btnNewRequest);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(229, 747);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 687);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(229, 60);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 9.5F);
            btnUsers.ForeColor = Color.Gold;
            btnUsers.Location = new Point(0, 367);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(17, 0, 0, 0);
            btnUsers.Size = new Size(229, 56);
            btnUsers.TabIndex = 6;
            btnUsers.Text = "Manage Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Dock = DockStyle.Top;
            btnDrivers.FlatAppearance.BorderSize = 0;
            btnDrivers.FlatStyle = FlatStyle.Flat;
            btnDrivers.Font = new Font("Segoe UI", 9.5F);
            btnDrivers.ForeColor = Color.Gold;
            btnDrivers.Location = new Point(0, 311);
            btnDrivers.Margin = new Padding(3, 4, 3, 4);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Padding = new Padding(17, 0, 0, 0);
            btnDrivers.Size = new Size(229, 56);
            btnDrivers.TabIndex = 5;
            btnDrivers.Text = "Drivers Fleet";
            btnDrivers.TextAlign = ContentAlignment.MiddleLeft;
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Dock = DockStyle.Top;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Segoe UI", 9.5F);
            btnVehicles.ForeColor = Color.Gold;
            btnVehicles.Location = new Point(0, 255);
            btnVehicles.Margin = new Padding(3, 4, 3, 4);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Padding = new Padding(17, 0, 0, 0);
            btnVehicles.Size = new Size(229, 56);
            btnVehicles.TabIndex = 4;
            btnVehicles.Text = "Vehicle Fleet";
            btnVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnTours
            // 
            btnTours.Dock = DockStyle.Top;
            btnTours.FlatAppearance.BorderSize = 0;
            btnTours.FlatStyle = FlatStyle.Flat;
            btnTours.Font = new Font("Segoe UI", 9.5F);
            btnTours.ForeColor = Color.Gold;
            btnTours.Location = new Point(0, 199);
            btnTours.Margin = new Padding(3, 4, 3, 4);
            btnTours.Name = "btnTours";
            btnTours.Padding = new Padding(17, 0, 0, 0);
            btnTours.Size = new Size(229, 56);
            btnTours.TabIndex = 3;
            btnTours.Text = "Tour Requests";
            btnTours.TextAlign = ContentAlignment.MiddleLeft;
            btnTours.UseVisualStyleBackColor = true;
            btnTours.Click += btnTours_Click;
            // 
            // btnNewRequest
            // 
            btnNewRequest.Dock = DockStyle.Top;
            btnNewRequest.FlatAppearance.BorderSize = 0;
            btnNewRequest.FlatStyle = FlatStyle.Flat;
            btnNewRequest.Font = new Font("Segoe UI", 9.5F);
            btnNewRequest.ForeColor = Color.Gold;
            btnNewRequest.Location = new Point(0, 143);
            btnNewRequest.Margin = new Padding(3, 4, 3, 4);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Padding = new Padding(17, 0, 0, 0);
            btnNewRequest.Size = new Size(229, 56);
            btnNewRequest.TabIndex = 2;
            btnNewRequest.Text = "+ New Request";
            btnNewRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnNewRequest.UseVisualStyleBackColor = true;
            btnNewRequest.Click += btnNewRequest_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9.5F);
            btnHome.ForeColor = Color.Gold;
            btnHome.Location = new Point(0, 87);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(17, 0, 0, 0);
            btnHome.Size = new Size(229, 56);
            btnHome.TabIndex = 1;
            btnHome.Text = "Dashboard Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lblBrand
            // 
            lblBrand.Dock = DockStyle.Top;
            lblBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBrand.ForeColor = Color.Gold;
            lblBrand.Location = new Point(0, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(229, 87);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "TMS Dashboard";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(229, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(777, 87);
            pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(40, 40, 40);
            lblWelcome.Location = new Point(23, 29);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(162, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 246, 250);
            pnlContent.Controls.Add(pnlHomeOverview);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(229, 87);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(777, 660);
            pnlContent.TabIndex = 2;
            // 
            // pnlHomeOverview
            // 
            pnlHomeOverview.Controls.Add(cardTours);
            pnlHomeOverview.Controls.Add(cardDrivers);
            pnlHomeOverview.Controls.Add(cardVehicles);
            pnlHomeOverview.Dock = DockStyle.Fill;
            pnlHomeOverview.Location = new Point(0, 0);
            pnlHomeOverview.Margin = new Padding(3, 4, 3, 4);
            pnlHomeOverview.Name = "pnlHomeOverview";
            pnlHomeOverview.Padding = new Padding(29, 33, 29, 33);
            pnlHomeOverview.Size = new Size(777, 660);
            pnlHomeOverview.TabIndex = 0;
            // 
            // cardTours
            // 
            cardTours.BackColor = Color.White;
            cardTours.BorderStyle = BorderStyle.FixedSingle;
            cardTours.Controls.Add(lblTourCount);
            cardTours.Controls.Add(lblTourTitle);
            cardTours.Location = new Point(509, 33);
            cardTours.Margin = new Padding(3, 4, 3, 4);
            cardTours.Name = "cardTours";
            cardTours.Size = new Size(205, 146);
            cardTours.TabIndex = 2;
            // 
            // lblTourCount
            // 
            lblTourCount.AutoSize = true;
            lblTourCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTourCount.ForeColor = Color.FromArgb(255, 193, 7);
            lblTourCount.Location = new Point(17, 60);
            lblTourCount.Name = "lblTourCount";
            lblTourCount.Size = new Size(43, 50);
            lblTourCount.TabIndex = 1;
            lblTourCount.Text = "0";
            // 
            // lblTourTitle
            // 
            lblTourTitle.AutoSize = true;
            lblTourTitle.Font = new Font("Segoe UI", 9.5F);
            lblTourTitle.ForeColor = Color.Gray;
            lblTourTitle.Location = new Point(17, 20);
            lblTourTitle.Name = "lblTourTitle";
            lblTourTitle.Size = new Size(107, 21);
            lblTourTitle.TabIndex = 0;
            lblTourTitle.Text = "Tour Requests";
            // 
            // cardDrivers
            // 
            cardDrivers.BackColor = Color.White;
            cardDrivers.BorderStyle = BorderStyle.FixedSingle;
            cardDrivers.Controls.Add(lblDrivCount);
            cardDrivers.Controls.Add(lblDrivTitle);
            cardDrivers.Location = new Point(269, 33);
            cardDrivers.Margin = new Padding(3, 4, 3, 4);
            cardDrivers.Name = "cardDrivers";
            cardDrivers.Size = new Size(205, 146);
            cardDrivers.TabIndex = 1;
            // 
            // lblDrivCount
            // 
            lblDrivCount.AutoSize = true;
            lblDrivCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDrivCount.ForeColor = Color.FromArgb(40, 167, 69);
            lblDrivCount.Location = new Point(17, 60);
            lblDrivCount.Name = "lblDrivCount";
            lblDrivCount.Size = new Size(43, 50);
            lblDrivCount.TabIndex = 1;
            lblDrivCount.Text = "0";
            // 
            // lblDrivTitle
            // 
            lblDrivTitle.AutoSize = true;
            lblDrivTitle.Font = new Font("Segoe UI", 9.5F);
            lblDrivTitle.ForeColor = Color.Gray;
            lblDrivTitle.Location = new Point(17, 20);
            lblDrivTitle.Name = "lblDrivTitle";
            lblDrivTitle.Size = new Size(96, 21);
            lblDrivTitle.TabIndex = 0;
            lblDrivTitle.Text = "Total Drivers";
            // 
            // cardVehicles
            // 
            cardVehicles.BackColor = Color.White;
            cardVehicles.BorderStyle = BorderStyle.FixedSingle;
            cardVehicles.Controls.Add(lblVehCount);
            cardVehicles.Controls.Add(lblVehTitle);
            cardVehicles.Location = new Point(29, 33);
            cardVehicles.Margin = new Padding(3, 4, 3, 4);
            cardVehicles.Name = "cardVehicles";
            cardVehicles.Size = new Size(205, 146);
            cardVehicles.TabIndex = 0;
            // 
            // lblVehCount
            // 
            lblVehCount.AutoSize = true;
            lblVehCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblVehCount.ForeColor = Color.FromArgb(0, 123, 255);
            lblVehCount.Location = new Point(17, 60);
            lblVehCount.Name = "lblVehCount";
            lblVehCount.Size = new Size(43, 50);
            lblVehCount.TabIndex = 1;
            lblVehCount.Text = "0";
            // 
            // lblVehTitle
            // 
            lblVehTitle.AutoSize = true;
            lblVehTitle.Font = new Font("Segoe UI", 9.5F);
            lblVehTitle.ForeColor = Color.Gray;
            lblVehTitle.Location = new Point(17, 20);
            lblVehTitle.Name = "lblVehTitle";
            lblVehTitle.Size = new Size(102, 21);
            lblVehTitle.TabIndex = 0;
            lblVehTitle.Text = "Total Vehicles";
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 747);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(969, 678);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transport Management System - Dashboard";
            FormClosed += MainDashboard_FormClosed;
            Load += MainDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlHomeOverview.ResumeLayout(false);
            cardTours.ResumeLayout(false);
            cardTours.PerformLayout();
            cardDrivers.ResumeLayout(false);
            cardDrivers.PerformLayout();
            cardVehicles.ResumeLayout(false);
            cardVehicles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnTours;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHomeOverview;
        private System.Windows.Forms.Panel cardTours;
        private System.Windows.Forms.Label lblTourCount;
        private System.Windows.Forms.Label lblTourTitle;
        private System.Windows.Forms.Panel cardDrivers;
        private System.Windows.Forms.Label lblDrivCount;
        private System.Windows.Forms.Label lblDrivTitle;
        private System.Windows.Forms.Panel cardVehicles;
        private System.Windows.Forms.Label lblVehCount;
        private System.Windows.Forms.Label lblVehTitle;
    }
}