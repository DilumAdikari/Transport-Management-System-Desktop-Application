namespace Trnasport_management_system
{
    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnTours = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.pnlNewRequest = new System.Windows.Forms.Panel();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlNewRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnNewRequest);
            this.pnlSidebar.Controls.Add(this.btnTours);
            this.pnlSidebar.Controls.Add(this.btnDrivers);
            this.pnlSidebar.Controls.Add(this.btnVehicles);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 550);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 505);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewRequest.FlatAppearance.BorderSize = 0;
            this.btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRequest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewRequest.ForeColor = System.Drawing.Color.White;
            this.btnNewRequest.Location = new System.Drawing.Point(0, 205);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNewRequest.Size = new System.Drawing.Size(200, 45);
            this.btnNewRequest.TabIndex = 4;
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
            this.btnTours.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTours.ForeColor = System.Drawing.Color.White;
            this.btnTours.Location = new System.Drawing.Point(0, 160);
            this.btnTours.Name = "btnTours";
            this.btnTours.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTours.Size = new System.Drawing.Size(200, 45);
            this.btnTours.TabIndex = 3;
            this.btnTours.Text = "Tour Requests";
            this.btnTours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTours.UseVisualStyleBackColor = true;
            this.btnTours.Click += new System.EventHandler(this.btnTours_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Location = new System.Drawing.Point(0, 115);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDrivers.Size = new System.Drawing.Size(200, 45);
            this.btnDrivers.TabIndex = 2;
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
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Location = new System.Drawing.Point(0, 70);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVehicles.Size = new System.Drawing.Size(200, 45);
            this.btnVehicles.TabIndex = 1;
            this.btnVehicles.Text = "Vehicle Fleet";
            this.btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.Gold;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(200, 70);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "TMS Dashboard";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(650, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblWelcome.Location = new System.Drawing.Point(20, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(126, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlContent.Controls.Add(this.pnlNewRequest);
            this.pnlContent.Controls.Add(this.lblSectionTitle);
            this.pnlContent.Controls.Add(this.dgvData);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(650, 480);
            this.pnlContent.TabIndex = 2;
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblSectionTitle.Location = new System.Drawing.Point(20, 15);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(95, 20);
            this.lblSectionTitle.TabIndex = 1;
            this.lblSectionTitle.Text = "Vehicle Fleet";
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(20, 45);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(610, 415);
            this.dgvData.TabIndex = 0;
            // 
            // pnlNewRequest
            // 
            this.pnlNewRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNewRequest.BackColor = System.Drawing.Color.White;
            this.pnlNewRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewRequest.Controls.Add(this.btnSubmitRequest);
            this.pnlNewRequest.Controls.Add(this.txtRemark);
            this.pnlNewRequest.Controls.Add(this.lblRemark);
            this.pnlNewRequest.Controls.Add(this.txtTime);
            this.pnlNewRequest.Controls.Add(this.lblTime);
            this.pnlNewRequest.Controls.Add(this.dtpDate);
            this.pnlNewRequest.Controls.Add(this.lblDate);
            this.pnlNewRequest.Controls.Add(this.txtTo);
            this.pnlNewRequest.Controls.Add(this.lblTo);
            this.pnlNewRequest.Controls.Add(this.txtFrom);
            this.pnlNewRequest.Controls.Add(this.lblFrom);
            this.pnlNewRequest.Controls.Add(this.txtDepartment);
            this.pnlNewRequest.Controls.Add(this.lblDept);
            this.pnlNewRequest.Location = new System.Drawing.Point(20, 45);
            this.pnlNewRequest.Name = "pnlNewRequest";
            this.pnlNewRequest.Size = new System.Drawing.Size(610, 415);
            this.pnlNewRequest.TabIndex = 2;
            this.pnlNewRequest.Visible = false;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDept.Location = new System.Drawing.Point(25, 12);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(73, 15);
            this.lblDept.Text = "Department:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDepartment.Location = new System.Drawing.Point(28, 30);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(550, 24);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFrom.Location = new System.Drawing.Point(25, 65);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(133, 15);
            this.lblFrom.Text = "From (Pickup Location):";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFrom.Location = new System.Drawing.Point(28, 83);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(260, 24);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTo.Location = new System.Drawing.Point(315, 65);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(126, 15);
            this.lblTo.Text = "To (Drop-off Location):";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTo.Location = new System.Drawing.Point(318, 83);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(260, 24);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Location = new System.Drawing.Point(25, 120);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 15);
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(28, 138);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(260, 24);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTime.Location = new System.Drawing.Point(315, 120);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 15);
            this.lblTime.Text = "Time (e.g. 09:30 AM):";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTime.Location = new System.Drawing.Point(318, 138);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(260, 24);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRemark.Location = new System.Drawing.Point(25, 175);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(50, 15);
            this.lblRemark.Text = "Remark:";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRemark.Location = new System.Drawing.Point(28, 193);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(550, 75);
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.BackColor = System.Drawing.Color.Gold;
            this.btnSubmitRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitRequest.Location = new System.Drawing.Point(28, 285);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(550, 40);
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transport Management System - Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlNewRequest.ResumeLayout(false);
            this.pnlNewRequest.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnTours;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlNewRequest;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnSubmitRequest;
    }
}