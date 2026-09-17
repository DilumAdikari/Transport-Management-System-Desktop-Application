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
            btnReports = new Button();
            btnUsers = new Button();
            btnDrivers = new Button();
            btnVehicles = new Button();
            btnTours = new Button();
            btnNewRequest = new Button();
            btnHome = new Button();
            pnlBrand = new Panel();
            btnToggleSidebar = new Button();
            lblBrand = new Label();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            pnlContent = new Panel();
            pnlHomeOverview = new Panel();
            pnlRecent = new Panel();
            dgvRecentTours = new DataGridView();
            lblRecentTitle = new Label();
            pnlChart = new Panel();
            lblChartTitle = new Label();
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
            pnlBrand.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlHomeOverview.SuspendLayout();
            pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTours).BeginInit();
            pnlChart.SuspendLayout();
            cardTours.SuspendLayout();
            cardDrivers.SuspendLayout();
            cardVehicles.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(28, 32, 40);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnUsers);
            pnlSidebar.Controls.Add(btnDrivers);
            pnlSidebar.Controls.Add(btnVehicles);
            pnlSidebar.Controls.Add(btnTours);
            pnlSidebar.Controls.Add(btnNewRequest);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(pnlBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(235, 747);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 687);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(235, 60);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "⏻   Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 65);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReports.ForeColor = Color.FromArgb(240, 243, 246);
            btnReports.Location = new Point(0, 423);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(18, 0, 0, 0);
            btnReports.Size = new Size(235, 56);
            btnReports.TabIndex = 7;
            btnReports.Text = "📈   Tour Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnUsers
            // 
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 65);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUsers.ForeColor = Color.FromArgb(240, 243, 246);
            btnUsers.Location = new Point(0, 367);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(18, 0, 0, 0);
            btnUsers.Size = new Size(235, 56);
            btnUsers.TabIndex = 6;
            btnUsers.Text = "👥   Manage Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Cursor = Cursors.Hand;
            btnDrivers.Dock = DockStyle.Top;
            btnDrivers.FlatAppearance.BorderSize = 0;
            btnDrivers.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 65);
            btnDrivers.FlatStyle = FlatStyle.Flat;
            btnDrivers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDrivers.ForeColor = Color.FromArgb(240, 243, 246);
            btnDrivers.Location = new Point(0, 311);
            btnDrivers.Margin = new Padding(3, 4, 3, 4);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Padding = new Padding(18, 0, 0, 0);
            btnDrivers.Size = new Size(235, 56);
            btnDrivers.TabIndex = 5;
            btnDrivers.Text = "🪪   Drivers Fleet";
            btnDrivers.TextAlign = ContentAlignment.MiddleLeft;
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Cursor = Cursors.Hand;
            btnVehicles.Dock = DockStyle.Top;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 65);
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVehicles.ForeColor = Color.FromArgb(240, 243, 246);
            btnVehicles.Location = new Point(0, 255);
            btnVehicles.Margin = new Padding(3, 4, 3, 4);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Padding = new Padding(18, 0, 0, 0);
            btnVehicles.Size = new Size(235, 56);
            btnVehicles.TabIndex = 4;
            btnVehicles.Text = "🚐   Vehicle Fleet";
            btnVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnTours
            // 
            btnTours.Cursor = Cursors.Hand;
            btnTours.Dock = DockStyle.Top;
            btnTours.FlatAppearance.BorderSize = 0;
            btnTours.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 65);
            btnTours.FlatStyle = FlatStyle.Flat;
            btnTours.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTours.ForeColor = Color.FromArgb(240, 243, 246);
            btnTours.Location = new Point(0, 199);
            btnTours.Margin = new Padding(3, 4, 3, 4);
            btnTours.Name = "btnTours";
            btnTours.Padding = new Padding(18, 0, 0, 0);
            btnTours.Size = new Size(235, 56);
            btnTours.TabIndex = 3;
            btnTours.Text = "📑   Tour Requests";
            btnTours.TextAlign = ContentAlignment.MiddleLeft;
            btnTours.UseVisualStyleBackColor = true;
            btnTours.Click += btnTours_Click;
            // 
            // btnNewRequest
            // 
            btnNewRequest.Cursor = Cursors.Hand;
            btnNewRequest.Dock = DockStyle.Top;
            btnNewRequest.FlatAppearance.BorderSize = 0;
            btnNewRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 65);
            btnNewRequest.FlatStyle = FlatStyle.Flat;
            btnNewRequest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewRequest.ForeColor = Color.FromArgb(255, 204, 0);
            btnNewRequest.Location = new Point(0, 143);
            btnNewRequest.Margin = new Padding(3, 4, 3, 4);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Padding = new Padding(18, 0, 0, 0);
            btnNewRequest.Size = new Size(235, 56);
            btnNewRequest.TabIndex = 2;
            btnNewRequest.Text = "➕   New Request";
            btnNewRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnNewRequest.UseVisualStyleBackColor = true;
            btnNewRequest.Click += btnNewRequest_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 65);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(240, 243, 246);
            btnHome.Location = new Point(0, 87);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(18, 0, 0, 0);
            btnHome.Size = new Size(235, 56);
            btnHome.TabIndex = 1;
            btnHome.Text = "📊   Dashboard Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(21, 24, 30);
            pnlBrand.Controls.Add(btnToggleSidebar);
            pnlBrand.Controls.Add(lblBrand);
            pnlBrand.Dock = DockStyle.Top;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(235, 87);
            pnlBrand.TabIndex = 0;
            // 
            // btnToggleSidebar
            // 
            btnToggleSidebar.Cursor = Cursors.Hand;
            btnToggleSidebar.FlatAppearance.BorderSize = 0;
            btnToggleSidebar.FlatStyle = FlatStyle.Flat;
            btnToggleSidebar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnToggleSidebar.ForeColor = Color.Gold;
            btnToggleSidebar.Location = new Point(10, 20);
            btnToggleSidebar.Name = "btnToggleSidebar";
            btnToggleSidebar.Size = new Size(45, 45);
            btnToggleSidebar.TabIndex = 0;
            btnToggleSidebar.Text = "☰";
            btnToggleSidebar.UseVisualStyleBackColor = true;
            btnToggleSidebar.Click += btnToggleSidebar_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(255, 204, 0);
            lblBrand.Location = new Point(62, 28);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(134, 28);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "TMS PORTAL";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(235, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(771, 87);
            pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(33, 37, 41);
            lblWelcome.Location = new Point(25, 29);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(174, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);
            pnlContent.Controls.Add(pnlHomeOverview);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(235, 87);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(771, 660);
            pnlContent.TabIndex = 2;
            // 
            // pnlHomeOverview
            // 
            pnlHomeOverview.Controls.Add(pnlRecent);
            pnlHomeOverview.Controls.Add(pnlChart);
            pnlHomeOverview.Controls.Add(cardTours);
            pnlHomeOverview.Controls.Add(cardDrivers);
            pnlHomeOverview.Controls.Add(cardVehicles);
            pnlHomeOverview.Dock = DockStyle.Fill;
            pnlHomeOverview.Location = new Point(0, 0);
            pnlHomeOverview.Margin = new Padding(3, 4, 3, 4);
            pnlHomeOverview.Name = "pnlHomeOverview";
            pnlHomeOverview.Padding = new Padding(29, 33, 29, 33);
            pnlHomeOverview.Size = new Size(771, 660);
            pnlHomeOverview.TabIndex = 0;
            // 
            // pnlRecent
            // 
            pnlRecent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecent.BackColor = Color.White;
            pnlRecent.BorderStyle = BorderStyle.FixedSingle;
            pnlRecent.Controls.Add(dgvRecentTours);
            pnlRecent.Controls.Add(lblRecentTitle);
            pnlRecent.Location = new Point(377, 207);
            pnlRecent.Margin = new Padding(3, 4, 3, 4);
            pnlRecent.Name = "pnlRecent";
            pnlRecent.Padding = new Padding(17, 20, 17, 20);
            pnlRecent.Size = new Size(359, 412);
            pnlRecent.TabIndex = 4;
            // 
            // dgvRecentTours
            // 
            dgvRecentTours.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentTours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentTours.BackgroundColor = Color.White;
            dgvRecentTours.BorderStyle = BorderStyle.None;
            dgvRecentTours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentTours.Location = new Point(17, 67);
            dgvRecentTours.Margin = new Padding(3, 4, 3, 4);
            dgvRecentTours.Name = "dgvRecentTours";
            dgvRecentTours.ReadOnly = true;
            dgvRecentTours.RowHeadersVisible = false;
            dgvRecentTours.RowHeadersWidth = 51;
            dgvRecentTours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentTours.Size = new Size(323, 321);
            dgvRecentTours.TabIndex = 1;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblRecentTitle.Location = new Point(17, 20);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(196, 25);
            lblRecentTitle.TabIndex = 0;
            lblRecentTitle.Text = "Recent Tour Requests";
            // 
            // pnlChart
            // 
            pnlChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlChart.BackColor = Color.White;
            pnlChart.BorderStyle = BorderStyle.FixedSingle;
            pnlChart.Controls.Add(lblChartTitle);
            pnlChart.Location = new Point(29, 207);
            pnlChart.Margin = new Padding(3, 4, 3, 4);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(331, 412);
            pnlChart.TabIndex = 3;
            pnlChart.Paint += pnlChart_Paint;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblChartTitle.Location = new Point(17, 20);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(218, 25);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Requests Status Activity";
            // 
            // cardTours
            // 
            cardTours.BackColor = Color.White;
            cardTours.BorderStyle = BorderStyle.FixedSingle;
            cardTours.Controls.Add(lblTourCount);
            cardTours.Controls.Add(lblTourTitle);
            cardTours.Location = new Point(537, 33);
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
            cardDrivers.Location = new Point(283, 33);
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
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlHomeOverview.ResumeLayout(false);
            pnlRecent.ResumeLayout(false);
            pnlRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTours).EndInit();
            pnlChart.ResumeLayout(false);
            pnlChart.PerformLayout();
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
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Button btnToggleSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
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
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel pnlRecent;
        private System.Windows.Forms.DataGridView dgvRecentTours;
        private System.Windows.Forms.Label lblRecentTitle;
    }
}