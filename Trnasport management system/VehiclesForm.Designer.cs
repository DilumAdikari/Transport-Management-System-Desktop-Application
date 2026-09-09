namespace Trnasport_management_system
{
    partial class VehiclesForm
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.txtVehNo = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblVNo = new System.Windows.Forms.Label();
            this.lblVType = new System.Windows.Forms.Label();
            this.lblVCap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 21);
            this.lblTitle.Text = "Vehicle Fleet";
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(20, 45);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(630, 310);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdd.BackColor = System.Drawing.Color.White;
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.txtCap);
            this.pnlAdd.Controls.Add(this.lblVCap);
            this.pnlAdd.Controls.Add(this.txtType);
            this.pnlAdd.Controls.Add(this.lblVType);
            this.pnlAdd.Controls.Add(this.txtVehNo);
            this.pnlAdd.Controls.Add(this.lblVNo);
            this.pnlAdd.Location = new System.Drawing.Point(20, 365);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(630, 80);
            // 
            // lblVNo
            // 
            this.lblVNo.AutoSize = true;
            this.lblVNo.Location = new System.Drawing.Point(10, 12);
            this.lblVNo.Name = "lblVNo";
            this.lblVNo.Size = new System.Drawing.Size(66, 15);
            this.lblVNo.Text = "Vehicle No:";
            // 
            // txtVehNo
            // 
            this.txtVehNo.Location = new System.Drawing.Point(10, 32);
            this.txtVehNo.Name = "txtVehNo";
            this.txtVehNo.Size = new System.Drawing.Size(130, 23);
            // 
            // lblVType
            // 
            this.lblVType.AutoSize = true;
            this.lblVType.Location = new System.Drawing.Point(150, 12);
            this.lblVType.Name = "lblVType";
            this.lblVType.Size = new System.Drawing.Size(34, 15);
            this.lblVType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(150, 32);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(130, 23);
            // 
            // lblVCap
            // 
            this.lblVCap.AutoSize = true;
            this.lblVCap.Location = new System.Drawing.Point(290, 12);
            this.lblVCap.Name = "lblVCap";
            this.lblVCap.Size = new System.Drawing.Size(56, 15);
            this.lblVCap.Text = "Capacity:";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(290, 32);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(80, 23);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(390, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 26);
            this.btnAdd.Text = "+ Add Vehicle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // VehiclesForm
            // 
            this.ClientSize = new System.Drawing.Size(670, 460);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehiclesForm";
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label lblVCap;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblVType;
        private System.Windows.Forms.TextBox txtVehNo;
        private System.Windows.Forms.Label lblVNo;
    }
}