namespace Trnasport_management_system
{
    partial class TourRequestsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvTours = new System.Windows.Forms.DataGridView();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.lblSelectedReq = new System.Windows.Forms.Label();
            this.lblVeh = new System.Windows.Forms.Label();
            this.cmbVehicles = new System.Windows.Forms.ComboBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTours)).BeginInit();
            this.pnlAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 21);
            this.lblTitle.Text = "Tour Requests Dispatch";
            // 
            // dgvTours
            // 
            this.dgvTours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTours.BackgroundColor = System.Drawing.Color.White;
            this.dgvTours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTours.Location = new System.Drawing.Point(20, 45);
            this.dgvTours.Name = "dgvTours";
            this.dgvTours.ReadOnly = true;
            this.dgvTours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTours.Size = new System.Drawing.Size(630, 270);
            this.dgvTours.TabIndex = 0;
            this.dgvTours.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTours_CellClick);
            // 
            // pnlAssign
            // 
            this.pnlAssign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAssign.BackColor = System.Drawing.Color.White;
            this.pnlAssign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAssign.Controls.Add(this.btnReject);
            this.pnlAssign.Controls.Add(this.btnAssign);
            this.pnlAssign.Controls.Add(this.cmbDrivers);
            this.pnlAssign.Controls.Add(this.lblDriver);
            this.pnlAssign.Controls.Add(this.cmbVehicles);
            this.pnlAssign.Controls.Add(this.lblVeh);
            this.pnlAssign.Controls.Add(this.lblSelectedReq);
            this.pnlAssign.Location = new System.Drawing.Point(20, 325);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(630, 115);
            this.pnlAssign.TabIndex = 1;
            // 
            // lblSelectedReq
            // 
            this.lblSelectedReq.AutoSize = true;
            this.lblSelectedReq.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSelectedReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSelectedReq.Location = new System.Drawing.Point(15, 12);
            this.lblSelectedReq.Name = "lblSelectedReq";
            this.lblSelectedReq.Size = new System.Drawing.Size(262, 17);
            this.lblSelectedReq.TabIndex = 0;
            this.lblSelectedReq.Text = "Select a Pending Tour Request from the table";
            // 
            // lblVeh
            // 
            this.lblVeh.AutoSize = true;
            this.lblVeh.Location = new System.Drawing.Point(15, 45);
            this.lblVeh.Name = "lblVeh";
            this.lblVeh.Size = new System.Drawing.Size(83, 15);
            this.lblVeh.TabIndex = 1;
            this.lblVeh.Text = "Assign Vehicle:";
            // 
            // cmbVehicles
            // 
            this.cmbVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicles.FormattingEnabled = true;
            this.cmbVehicles.Location = new System.Drawing.Point(18, 65);
            this.cmbVehicles.Name = "cmbVehicles";
            this.cmbVehicles.Size = new System.Drawing.Size(180, 23);
            this.cmbVehicles.TabIndex = 2;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(215, 45);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(77, 15);
            this.lblDriver.TabIndex = 3;
            this.lblDriver.Text = "Assign Driver:";
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.Location = new System.Drawing.Point(218, 65);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(180, 23);
            this.cmbDrivers.TabIndex = 4;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(415, 61);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(110, 30);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Approve";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(535, 61);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(80, 30);
            this.btnReject.TabIndex = 6;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // TourRequestsForm
            // 
            this.ClientSize = new System.Drawing.Size(670, 460);
            this.Controls.Add(this.pnlAssign);
            this.Controls.Add(this.dgvTours);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TourRequestsForm";
            this.Load += new System.EventHandler(this.TourRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTours)).EndInit();
            this.pnlAssign.ResumeLayout(false);
            this.pnlAssign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTours;
        private System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.Label lblSelectedReq;
        private System.Windows.Forms.Label lblVeh;
        private System.Windows.Forms.ComboBox cmbVehicles;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnReject;
    }
}