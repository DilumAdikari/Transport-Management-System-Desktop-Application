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
            this.btnUsers = new System.Windows.Forms.Button();
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
            this.pnlRecent = new System.Windows.Forms.Panel();
            this.dgvRecentTours = new System.Windows.Forms.DataGridView();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
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
            this.pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTours)).BeginInit();
            this.pnlChart.SuspendLayout();
            this.cardTours.SuspendLayout();
            this.cardDrivers.SuspendLayout();
            this.cardVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnUsers);
            this.pnlSidebar.Controls.Add(this.btnDrivers);
            this.pnlSidebar.Controls.Add(this.btnVehicles);
            this.pnlSidebar.Controls.Add(this.btnTours);
            this.pnlSidebar.Controls.Add(this.btnNewRequest);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(229, 747);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 687);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(229, 60);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsers.Location = new System.Drawing.Point(0, 367);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(229, 56);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Location = new System.Drawing.Point(0, 311);
            this.btnDrivers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDrivers.Size = new System.Drawing.Size(229, 56);
            this.btnDrivers.TabIndex = 5;
            this.btnDrivers.Text = "Drivers Fleet";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicles.FlatAppearance.BorderSize = 0;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Location = new System.Drawing.Point(0, 255);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnVehicles.Size = new System.Drawing.Size(229, 56);
            this.btnVehicles.TabIndex = 4;
            this.btnVehicles.Text = "Vehicle Fleet";
            this.btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnTours
            // 
            this.btnTours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTours.FlatAppearance.BorderSize = 0;
            this.btnTours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTours.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTours.ForeColor = System.Drawing.Color.White;
            this.btnTours.Location = new System.Drawing.Point(0, 199);
            this.btnTours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTours.Name = "btnTours";
            this.btnTours.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTours.Size = new System.Drawing.Size(229, 56);
            this.btnTours.TabIndex = 3;
            this.btnTours.Text = "Tour Requests";
            this.btnTours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTours.UseVisualStyleBackColor = true;
            this.btnTours.Click += new System.EventHandler(this.btnTours_Click);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewRequest.FlatAppearance.BorderSize = 0;
            this.btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRequest.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewRequest.ForeColor = System.Drawing.Color.Gold;
            this.btnNewRequest.Location = new System.Drawing.Point(0, 143);
            this.btnNewRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnNewRequest.Size = new System.Drawing.Size(229, 56);
            this.btnNewRequest.TabIndex = 2;
            this.btnNewRequest.Text = "+ New Request";
            this.btnNewRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 87);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(229, 56);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Dashboard Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.ForeColor = System.Drawing.Color.Gold;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(229, 87);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "TMS Dashboard";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(229, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(777, 87);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblWelcome.Location = new System.Drawing.Point(23, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(162, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.pnlHomeOverview);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(229, 87);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(777, 660);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlHomeOverview
            // 
            this.pnlHomeOverview.Controls.Add(this.pnlRecent);
            this.pnlHomeOverview.Controls.Add(this.pnlChart);
            this.pnlHomeOverview.Controls.Add(this.cardTours);
            this.pnlHomeOverview.Controls.Add(this.cardDrivers);
            this.pnlHomeOverview.Controls.Add(this.cardVehicles);
            this.pnlHomeOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHomeOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeOverview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHomeOverview.Name = "pnlHomeOverview";
            this.pnlHomeOverview.Padding = new System.Windows.Forms.Padding(29, 33, 29, 33);
            this.pnlHomeOverview.Size = new System.Drawing.Size(777, 660);
            this.pnlHomeOverview.TabIndex = 0;
            // 
            // pnlRecent
            // 
            this.pnlRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecent.BackColor = System.Drawing.Color.White;
            this.pnlRecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecent.Controls.Add(this.dgvRecentTours);
            this.pnlRecent.Controls.Add(this.lblRecentTitle);
            this.pnlRecent.Location = new System.Drawing.Point(377, 207);
            this.pnlRecent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.Padding = new System.Windows.Forms.Padding(17, 20, 17, 20);
            this.pnlRecent.Size = new System.Drawing.Size(365, 412);
            this.pnlRecent.TabIndex = 4;
            // 
            // dgvRecentTours
            // 
            this.dgvRecentTours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecentTours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentTours.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentTours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentTours.Location = new System.Drawing.Point(17, 67);
            this.dgvRecentTours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRecentTours.Name = "dgvRecentTours";
            this.dgvRecentTours.ReadOnly = true;
            this.dgvRecentTours.RowHeadersVisible = false;
            this.dgvRecentTours.RowHeadersWidth = 51;
            this.dgvRecentTours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentTours.Size = new System.Drawing.Size(329, 321);
            this.dgvRecentTours.TabIndex = 1;
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.AutoSize = true;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRecentTitle.Location = new System.Drawing.Point(17, 20);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(199, 25);
            this.lblRecentTitle.TabIndex = 0;
            this.lblRecentTitle.Text = "Recent Tour Requests";
            // 
            // pnlChart
            // 
            this.pnlChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChart.Controls.Add(this.lblChartTitle);
            this.pnlChart.Location = new System.Drawing.Point(29, 207);
            this.pnlChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(331, 412);
            this.pnlChart.TabIndex = 3;
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblChartTitle.Location = new System.Drawing.Point(17, 20);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(217, 25);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "Requests Status Activity";
            // 
            // cardTours
            // 
            this.cardTours.BackColor = System.Drawing.Color.White;
            this.cardTours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTours.Controls.Add(this.lblTourCount);
            this.cardTours.Controls.Add(this.lblTourTitle);
            this.cardTours.Location = new System.Drawing.Point(537, 33);
            this.cardTours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardTours.Name = "cardTours";
            this.cardTours.Size = new System.Drawing.Size(205, 146);
            this.cardTours.TabIndex = 2;
            // 
            // lblTourCount
            // 
            this.lblTourCount.AutoSize = true;
            this.lblTourCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTourCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblTourCount.Location = new System.Drawing.Point(17, 60);
            this.lblTourCount.Name = "lblTourCount";
            this.lblTourCount.Size = new System.Drawing.Size(43, 50);
            this.lblTourCount.TabIndex = 1;
            this.lblTourCount.Text = "0";
            // 
            // lblTourTitle
            // 
            this.lblTourTitle.AutoSize = true;
            this.lblTourTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTourTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTourTitle.Location = new System.Drawing.Point(17, 20);
            this.lblTourTitle.Name = "lblTourTitle";
            this.lblTourTitle.Size = new System.Drawing.Size(107, 21);
            this.lblTourTitle.TabIndex = 0;
            this.lblTourTitle.Text = "Tour Requests";
            // 
            // cardDrivers
            // 
            this.cardDrivers.BackColor = System.Drawing.Color.White;
            this.cardDrivers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardDrivers.Controls.Add(this.lblDrivCount);
            this.cardDrivers.Controls.Add(this.lblDrivTitle);
            this.cardDrivers.Location = new System.Drawing.Point(283, 33);
            this.cardDrivers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardDrivers.Name = "cardDrivers";
            this.cardDrivers.Size = new System.Drawing.Size(205, 146);
            this.cardDrivers.TabIndex = 1;
            // 
            // lblDrivCount
            // 
            this.lblDrivCount.AutoSize = true;
            this.lblDrivCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDrivCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblDrivCount.Location = new System.Drawing.Point(17, 60);
            this.lblDrivCount.Name = "lblDrivCount";
            this.lblDrivCount.Size = new System.Drawing.Size(43, 50);
            this.lblDrivCount.TabIndex = 1;
            this.lblDrivCount.Text = "0";
            // 
            // lblDrivTitle
            // 
            this.lblDrivTitle.AutoSize = true;
            this.lblDrivTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDrivTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblDrivTitle.Location = new System.Drawing.Point(17, 20);
            this.lblDrivTitle.Name = "lblDrivTitle";
            this.lblDrivTitle.Size = new System.Drawing.Size(96, 21);
            this.lblDrivTitle.TabIndex = 0;
            this.lblDrivTitle.Text = "Total Drivers";
            // 
            // cardVehicles
            // 
            this.cardVehicles.BackColor = System.Drawing.Color.White;
            this.cardVehicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardVehicles.Controls.Add(this.lblVehCount);
            this.cardVehicles.Controls.Add(this.lblVehTitle);
            this.cardVehicles.Location = new System.Drawing.Point(29, 33);
            this.cardVehicles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardVehicles.Name = "cardVehicles";
            this.cardVehicles.Size = new System.Drawing.Size(205, 146);
            this.cardVehicles.TabIndex = 0;
            // 
            // lblVehCount
            // 
            this.lblVehCount.AutoSize = true;
            this.lblVehCount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVehCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblVehCount.Location = new System.Drawing.Point(17, 60);
            this.lblVehCount.Name = "lblVehCount";
            this.lblVehCount.Size = new System.Drawing.Size(43, 50);
            this.lblVehCount.TabIndex = 1;
            this.lblVehCount.Text = "0";
            // 
            // lblVehTitle
            // 
            this.lblVehTitle.AutoSize = true;
            this.lblVehTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVehTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblVehTitle.Location = new System.Drawing.Point(17, 20);
            this.lblVehTitle.Name = "lblVehTitle";
            this.lblVehTitle.Size = new System.Drawing.Size(102, 21);
            this.lblVehTitle.TabIndex = 0;
            this.lblVehTitle.Text = "Total Vehicles";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 747);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(969, 678);
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
            this.pnlRecent.ResumeLayout(false);
            this.pnlRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTours)).EndInit();
            this.pnlChart.ResumeLayout(false);
            this.pnlChart.PerformLayout();
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