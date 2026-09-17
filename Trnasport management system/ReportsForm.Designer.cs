namespace Trnasport_management_system
{
    partial class ReportsForm
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
            this.cmbFilterVehicle = new System.Windows.Forms.ComboBox();
            this.cmbFilterDriver = new System.Windows.Forms.ComboBox();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVeh = new System.Windows.Forms.Label();
            this.lblDriv = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tour Dispatch Reports";
            // 
            // lblVeh
            // 
            this.lblVeh.AutoSize = true;
            this.lblVeh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVeh.Location = new System.Drawing.Point(27, 65);
            this.lblVeh.Name = "lblVeh";
            this.lblVeh.Size = new System.Drawing.Size(84, 15);
            this.lblVeh.TabIndex = 1;
            this.lblVeh.Text = "Filter Vehicle:";
            // 
            // cmbFilterVehicle
            // 
            this.cmbFilterVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterVehicle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterVehicle.FormattingEnabled = true;
            this.cmbFilterVehicle.Location = new System.Drawing.Point(28, 85);
            this.cmbFilterVehicle.Name = "cmbFilterVehicle";
            this.cmbFilterVehicle.Size = new System.Drawing.Size(180, 25);
            this.cmbFilterVehicle.TabIndex = 2;
            // 
            // lblDriv
            // 
            this.lblDriv.AutoSize = true;
            this.lblDriv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDriv.Location = new System.Drawing.Point(220, 65);
            this.lblDriv.Name = "lblDriv";
            this.lblDriv.Size = new System.Drawing.Size(78, 15);
            this.lblDriv.TabIndex = 3;
            this.lblDriv.Text = "Filter Driver:";
            // 
            // cmbFilterDriver
            // 
            this.cmbFilterDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterDriver.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterDriver.FormattingEnabled = true;
            this.cmbFilterDriver.Location = new System.Drawing.Point(223, 85);
            this.cmbFilterDriver.Name = "cmbFilterDriver";
            this.cmbFilterDriver.Size = new System.Drawing.Size(160, 25);
            this.cmbFilterDriver.TabIndex = 4;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStat.Location = new System.Drawing.Point(395, 65);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(45, 15);
            this.lblStat.TabIndex = 5;
            this.lblStat.Text = "Status:";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Location = new System.Drawing.Point(398, 85);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(130, 25);
            this.cmbFilterStatus.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(545, 83);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 28);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filter Report";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(655, 83);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 28);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(28, 125);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowTemplate.Height = 25;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(710, 380);
            this.dgvReport.TabIndex = 9;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 525);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.cmbFilterDriver);
            this.Controls.Add(this.lblDriv);
            this.Controls.Add(this.cmbFilterVehicle);
            this.Controls.Add(this.lblVeh);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVeh;
        private System.Windows.Forms.ComboBox cmbFilterVehicle;
        private System.Windows.Forms.Label lblDriv;
        private System.Windows.Forms.ComboBox cmbFilterDriver;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}