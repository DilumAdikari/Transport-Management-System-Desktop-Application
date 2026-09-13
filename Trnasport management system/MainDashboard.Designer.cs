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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnTours = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHomeOverview = new System.Windows.Forms.Panel();
            this.cardTours = new System.Windows.Forms.Panel();
            this.lblTourCount = new System.Windows.Forms.Label();
            this.lblTourTitle = new System.Windows.Forms.Label();
            this.cardDrivers = new System.Windows.Forms.Panel();
            this.lblDrivCount = new System.Windows.Forms.Label();
            this.lblDrivTitle = new System.Windows.Forms.Label();
            this.cardVehicles = new System.Windows.Forms.Panel();
            this.lblVehCount = new System.Windows.Forms.Label();
            this.lblVehTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlHomeOverview.SuspendLayout();
            this.cardTours.SuspendLayout();
            this.cardDrivers.SuspendLayout();
            this.cardVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnDrivers);
            this.pnlSidebar.Controls.Add(this.btnVehicles);
            this.pnlSidebar.Controls.Add(this.btnTours);
            this.pnlSidebar.Controls.Add(this.btnNewRequest);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 560);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.Gold;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(200, 65);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "TMS Dashboard";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 65);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 42);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Dashboard Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewRequest.FlatAppearance.BorderSize = 0;
            this.btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRequest.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNewRequest.ForeColor = System.Drawing.Color.Gold;
            this.btnNewRequest.Location = new System.Drawing.Point(0, 107);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNewRequest.Size = new System.Drawing.Size(200, 42);
            this.btnNewRequest.TabIndex = 2;
            this.btnNewRequest.Text = "+ New Request";
            this.btnNewRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // btnTours
            // 
            this.btnTours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTours.FlatAppearance.BorderSize = 0;
            this.btnTours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTours.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnTours.ForeColor = System.Drawing.Color.White;
            this.btnTours.Location = new System.Drawing.Point(0, 149);
            this.btnTours.Name = "btnTours";
            this.btnTours.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTours.Size = new System.Drawing.Size(200, 42);
            this.btnTours.TabIndex = 3;
            this.btnTours.Text = "Tour Requests";
            this.btnTours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTours.UseVisualStyleBackColor = true;
            this.btnTours.Click += new System.EventHandler(this.btnTours_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicles.FlatAppearance.BorderSize = 0;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Location = new System.Drawing.Point(0, 191);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVehicles.Size = new System.Drawing.Size(200, 42);
            this.btnVehicles.TabIndex = 4;
            this.btnVehicles.Text = "Vehicle Fleet";
            this.btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Location = new System.Drawing.Point(0, 233);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDrivers.Size = new System.Drawing.Size(200, 42);
            this.btnDrivers.TabIndex = 5;
            this.btnDrivers.Text = "Drivers Fleet";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 515);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(680, 65);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblWelcome.Location = new System.Drawing.Point(20, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(126, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.pnlHomeOverview);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(680, 495);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlHomeOverview
            // 
            this.pnlHomeOverview.Controls.Add(this.cardTours);
            this.pnlHomeOverview.Controls.Add(this.cardDrivers);
            this.pnlHomeOverview.Controls.Add(this.cardVehicles);
            this.pnlHomeOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHomeOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeOverview.Name = "pnlHomeOverview";
            this.pnlHomeOverview.Padding = new System.Windows.Forms.Padding(25);
            this.pnlHomeOverview.Size = new System.Drawing.Size(680, 495);
            this.pnlHomeOverview.TabIndex = 0;
            // 
            // cardTours
            // 
            this.cardTours.BackColor = System.Drawing.Color.White;
            this.cardTours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTours.Controls.Add(this.lblTourCount);
            this.cardTours.Controls.Add(this.lblTourTitle);
            this.cardTours.Location = new System.Drawing.Point(445, 25);
            this.cardTours.Name = "cardTours";
            this.cardTours.Size = new System.Drawing.Size(180, 110);
            this.cardTours.TabIndex = 2;
            // 
            // lblTourCount
            // 
            this.lblTourCount.AutoSize = true;
            this.lblTourCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTourCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblTourCount.Location = new System.Drawing.Point(15, 45);
            this.lblTourCount.Name = "lblTourCount";
            this.lblTourCount.Size = new System.Drawing.Size(35, 41);
            this.lblTourCount.TabIndex = 1;
            this.lblTourCount.Text = "0";
            // 
            // lblTourTitle
            // 
            this.lblTourTitle.AutoSize = true;
            this.lblTourTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTourTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTourTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTourTitle.Name = "lblTourTitle";
            this.lblTourTitle.Size = new System.Drawing.Size(91, 17);
            this.lblTourTitle.TabIndex = 0;
            this.lblTourTitle.Text = "Tour Requests";
            // 
            // cardDrivers
            // 
            this.cardDrivers.BackColor = System.Drawing.Color.White;
            this.cardDrivers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardDrivers.Controls.Add(this.lblDrivCount);
            this.cardDrivers.Controls.Add(this.lblDrivTitle);
            this.cardDrivers.Location = new System.Drawing.Point(235, 25);
            this.cardDrivers.Name = "cardDrivers";
            this.cardDrivers.Size = new System.Drawing.Size(180, 110);
            this.cardDrivers.TabIndex = 1;
            // 
            // lblDrivCount
            // 
            this.lblDrivCount.AutoSize = true;
            this.lblDrivCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblDrivCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblDrivCount.Location = new System.Drawing.Point(15, 45);
            this.lblDrivCount.Name = "lblDrivCount";
            this.lblDrivCount.Size = new System.Drawing.Size(35, 41);
            this.lblDrivCount.TabIndex = 1;
            this.lblDrivCount.Text = "0";
            // 
            // lblDrivTitle
            // 
            this.lblDrivTitle.AutoSize = true;
            this.lblDrivTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDrivTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblDrivTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDrivTitle.Name = "lblDrivTitle";
            this.lblDrivTitle.Size = new System.Drawing.Size(82, 17);
            this.lblDrivTitle.TabIndex = 0;
            this.lblDrivTitle.Text = "Total Drivers";
            // 
            // cardVehicles
            // 
            this.cardVehicles.BackColor = System.Drawing.Color.White;
            this.cardVehicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardVehicles.Controls.Add(this.lblVehCount);
            this.cardVehicles.Controls.Add(this.lblVehTitle);
            this.cardVehicles.Location = new System.Drawing.Point(25, 25);
            this.cardVehicles.Name = "cardVehicles";
            this.cardVehicles.Size = new System.Drawing.Size(180, 110);
            this.cardVehicles.TabIndex = 0;
            // 
            // lblVehCount
            // 
            this.lblVehCount.AutoSize = true;
            this.lblVehCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblVehCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblVehCount.Location = new System.Drawing.Point(15, 45);
            this.lblVehCount.Name = "lblVehCount";
            this.lblVehCount.Size = new System.Drawing.Size(35, 41);
            this.lblVehCount.TabIndex = 1;
            this.lblVehCount.Text = "0";
            // 
            // lblVehTitle
            // 
            this.lblVehTitle.AutoSize = true;
            this.lblVehTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVehTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblVehTitle.Location = new System.Drawing.Point(15, 15);
            this.lblVehTitle.Name = "lblVehTitle";
            this.lblVehTitle.Size = new System.Drawing.Size(89, 17);
            this.lblVehTitle.TabIndex = 0;
            this.lblVehTitle.Text = "Total Vehicles";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(850, 520);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transport Management System - Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlHomeOverview.ResumeLayout(false);
            this.cardTours.ResumeLayout(false);
            this.cardTours.PerformLayout();
            this.cardDrivers.ResumeLayout(false);
            this.cardDrivers.PerformLayout();
            this.cardVehicles.ResumeLayout(false);
            this.cardVehicles.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnLogout;
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