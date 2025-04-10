namespace PM_QL_BanHoa.Employee {
	partial class frmBillManagement {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAddressDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grbBillManagement = new System.Windows.Forms.GroupBox();
			this.btnCreateBill = new System.Windows.Forms.Button();
			this.btnUpdateBill = new System.Windows.Forms.Button();
			this.txtBillID = new System.Windows.Forms.TextBox();
			this.txtStaffID = new System.Windows.Forms.TextBox();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtAddressDelivery = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.grbBillManagement.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.grbBillManagement);
			this.panel1.Controls.Add(this.dataGridView);
			this.panel1.Location = new System.Drawing.Point(11, 10);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1479, 702);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBillID,
            this.colStaffID,
            this.colCustomerID,
            this.colDate,
            this.colStatus,
            this.colAddressDelivery,
            this.colTotal});
			this.dataGridView.Location = new System.Drawing.Point(3, 2);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(905, 698);
			this.dataGridView.TabIndex = 0;
			// 
			// colTotal
			// 
			this.colTotal.DataPropertyName = "ThanhTien";
			this.colTotal.HeaderText = "Thành tiền";
			this.colTotal.MinimumWidth = 8;
			this.colTotal.Name = "colTotal";
			// 
			// colAddressDelivery
			// 
			this.colAddressDelivery.DataPropertyName = "DiaChiGiao";
			this.colAddressDelivery.HeaderText = "Địa chỉ giao";
			this.colAddressDelivery.MinimumWidth = 8;
			this.colAddressDelivery.Name = "colAddressDelivery";
			// 
			// colStatus
			// 
			this.colStatus.DataPropertyName = "TrangThai";
			this.colStatus.HeaderText = "Trạng thái";
			this.colStatus.MinimumWidth = 8;
			this.colStatus.Name = "colStatus";
			// 
			// colDate
			// 
			this.colDate.DataPropertyName = "NgayLapHoaDon";
			this.colDate.HeaderText = "Ngày lập hóa đơn";
			this.colDate.MinimumWidth = 8;
			this.colDate.Name = "colDate";
			// 
			// colCustomerID
			// 
			this.colCustomerID.DataPropertyName = "MaKH";
			this.colCustomerID.HeaderText = "Mã khách hàng";
			this.colCustomerID.MinimumWidth = 8;
			this.colCustomerID.Name = "colCustomerID";
			// 
			// colStaffID
			// 
			this.colStaffID.DataPropertyName = "MaNV";
			this.colStaffID.HeaderText = "Mã nhân viên";
			this.colStaffID.MinimumWidth = 8;
			this.colStaffID.Name = "colStaffID";
			// 
			// colBillID
			// 
			this.colBillID.DataPropertyName = "MaHD";
			this.colBillID.HeaderText = "Mã hóa đơn";
			this.colBillID.MinimumWidth = 8;
			this.colBillID.Name = "colBillID";
			// 
			// grbBillManagement
			// 
			this.grbBillManagement.Controls.Add(this.txtAddressDelivery);
			this.grbBillManagement.Controls.Add(this.txtTotal);
			this.grbBillManagement.Controls.Add(this.txtStatus);
			this.grbBillManagement.Controls.Add(this.dateTimePicker);
			this.grbBillManagement.Controls.Add(this.txtCustomerID);
			this.grbBillManagement.Controls.Add(this.txtStaffID);
			this.grbBillManagement.Controls.Add(this.txtBillID);
			this.grbBillManagement.Controls.Add(this.btnUpdateBill);
			this.grbBillManagement.Controls.Add(this.btnCreateBill);
			this.grbBillManagement.Location = new System.Drawing.Point(914, 3);
			this.grbBillManagement.Name = "grbBillManagement";
			this.grbBillManagement.Size = new System.Drawing.Size(562, 696);
			this.grbBillManagement.TabIndex = 1;
			this.grbBillManagement.TabStop = false;
			this.grbBillManagement.Text = "Xử lý hóa đơn";
			// 
			// btnCreateBill
			// 
			this.btnCreateBill.Location = new System.Drawing.Point(95, 611);
			this.btnCreateBill.Name = "btnCreateBill";
			this.btnCreateBill.Size = new System.Drawing.Size(150, 50);
			this.btnCreateBill.TabIndex = 0;
			this.btnCreateBill.Text = "Tạo hóa đơn";
			this.btnCreateBill.UseVisualStyleBackColor = true;
			// 
			// btnUpdateBill
			// 
			this.btnUpdateBill.Location = new System.Drawing.Point(344, 611);
			this.btnUpdateBill.Name = "btnUpdateBill";
			this.btnUpdateBill.Size = new System.Drawing.Size(150, 50);
			this.btnUpdateBill.TabIndex = 1;
			this.btnUpdateBill.Text = "Chỉnh sửa hóa đơn";
			this.btnUpdateBill.UseVisualStyleBackColor = true;
			// 
			// txtBillID
			// 
			this.txtBillID.Location = new System.Drawing.Point(260, 66);
			this.txtBillID.Name = "txtBillID";
			this.txtBillID.Size = new System.Drawing.Size(250, 22);
			this.txtBillID.TabIndex = 2;
			// 
			// txtStaffID
			// 
			this.txtStaffID.Location = new System.Drawing.Point(260, 132);
			this.txtStaffID.Name = "txtStaffID";
			this.txtStaffID.ReadOnly = true;
			this.txtStaffID.Size = new System.Drawing.Size(250, 22);
			this.txtStaffID.TabIndex = 3;
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(260, 205);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.ReadOnly = true;
			this.txtCustomerID.Size = new System.Drawing.Size(250, 22);
			this.txtCustomerID.TabIndex = 4;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(260, 268);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(250, 22);
			this.dateTimePicker.TabIndex = 5;
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(260, 477);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(250, 22);
			this.txtStatus.TabIndex = 6;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(260, 534);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(250, 22);
			this.txtTotal.TabIndex = 7;
			// 
			// txtAddressDelivery
			// 
			this.txtAddressDelivery.Location = new System.Drawing.Point(260, 321);
			this.txtAddressDelivery.Multiline = true;
			this.txtAddressDelivery.Name = "txtAddressDelivery";
			this.txtAddressDelivery.ReadOnly = true;
			this.txtAddressDelivery.Size = new System.Drawing.Size(250, 120);
			this.txtAddressDelivery.TabIndex = 8;
			// 
			// frmBillManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1500, 722);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmBillManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý hóa đơn";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBillManagement_FormClosing);
			this.Load += new System.EventHandler(this.frmBillManagement_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.grbBillManagement.ResumeLayout(false);
			this.grbBillManagement.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox grbBillManagement;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBillID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAddressDelivery;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.TextBox txtStaffID;
		private System.Windows.Forms.TextBox txtBillID;
		private System.Windows.Forms.Button btnUpdateBill;
		private System.Windows.Forms.Button btnCreateBill;
		private System.Windows.Forms.TextBox txtAddressDelivery;
	}
}