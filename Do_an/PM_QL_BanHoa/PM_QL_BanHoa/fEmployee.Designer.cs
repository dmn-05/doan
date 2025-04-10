namespace PM_QL_BanHoa
{
    partial class fEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

<<<<<<< HEAD
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployee));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dgvEmployee = new System.Windows.Forms.DataGridView();
      this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.txtName);
      this.groupBox1.Controls.Add(this.dgvEmployee);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Blue;
      this.groupBox1.Location = new System.Drawing.Point(26, 28);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1185, 597);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Quản Lý Nhân Viên";
      // 
      // dgvEmployee
      // 
      this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colTenDangNhap,
            this.colMatKhau,
            this.colSoDienThoai,
            this.colEmail,
            this.colDiaChi,
            this.colChucVu,
            this.colTrangThai});
      this.dgvEmployee.Location = new System.Drawing.Point(24, 81);
      this.dgvEmployee.Name = "dgvEmployee";
      this.dgvEmployee.RowHeadersWidth = 51;
      this.dgvEmployee.RowTemplate.Height = 24;
      this.dgvEmployee.Size = new System.Drawing.Size(1133, 487);
      this.dgvEmployee.TabIndex = 0;
      // 
      // colMaNV
      // 
      this.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMaNV.DataPropertyName = "MaNV";
      this.colMaNV.FillWeight = 128.3422F;
      this.colMaNV.HeaderText = "MaNV";
      this.colMaNV.MinimumWidth = 70;
      this.colMaNV.Name = "colMaNV";
      this.colMaNV.ReadOnly = true;
      this.colMaNV.Width = 70;
      // 
      // colTenNV
      // 
      this.colTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTenNV.DataPropertyName = "TenNV";
      this.colTenNV.FillWeight = 518.8315F;
      this.colTenNV.HeaderText = "TenNV";
      this.colTenNV.MinimumWidth = 140;
      this.colTenNV.Name = "colTenNV";
      this.colTenNV.Width = 200;
      // 
      // colTenDangNhap
      // 
      this.colTenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTenDangNhap.DataPropertyName = "TenDangNhap";
      this.colTenDangNhap.FillWeight = 25.47104F;
      this.colTenDangNhap.HeaderText = "TenDangNhap";
      this.colTenDangNhap.MinimumWidth = 140;
      this.colTenDangNhap.Name = "colTenDangNhap";
      this.colTenDangNhap.Width = 140;
      // 
      // colMatKhau
      // 
      this.colMatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMatKhau.DataPropertyName = "MatKhau";
      this.colMatKhau.FillWeight = 25.47104F;
      this.colMatKhau.HeaderText = "MatKhau";
      this.colMatKhau.MinimumWidth = 50;
      this.colMatKhau.Name = "colMatKhau";
      this.colMatKhau.Width = 125;
      // 
      // colSoDienThoai
      // 
      this.colSoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colSoDienThoai.DataPropertyName = "SoDienThoai";
      this.colSoDienThoai.FillWeight = 25.47104F;
      this.colSoDienThoai.HeaderText = "SoDienThoai";
      this.colSoDienThoai.MinimumWidth = 100;
      this.colSoDienThoai.Name = "colSoDienThoai";
      this.colSoDienThoai.Width = 125;
      // 
      // colEmail
      // 
      this.colEmail.DataPropertyName = "Email";
      this.colEmail.HeaderText = "Email";
      this.colEmail.MinimumWidth = 120;
      this.colEmail.Name = "colEmail";
      // 
      // colDiaChi
      // 
      this.colDiaChi.DataPropertyName = "DiaChi";
      this.colDiaChi.FillWeight = 25.47104F;
      this.colDiaChi.HeaderText = "DiaChi";
      this.colDiaChi.MinimumWidth = 150;
      this.colDiaChi.Name = "colDiaChi";
      // 
      // colChucVu
      // 
      this.colChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colChucVu.DataPropertyName = "ChucVu";
      this.colChucVu.FillWeight = 25.47104F;
      this.colChucVu.HeaderText = "ChucVu";
      this.colChucVu.MinimumWidth = 139;
      this.colChucVu.Name = "colChucVu";
      this.colChucVu.Width = 139;
      // 
      // colTrangThai
      // 
      this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTrangThai.DataPropertyName = "TrangThai";
      this.colTrangThai.FillWeight = 25.47104F;
      this.colTrangThai.HeaderText = "TrangThai";
      this.colTrangThai.MinimumWidth = 139;
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.Width = 139;
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.Black;
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(1073, 631);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(135, 67);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "    Lưu";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(743, 33);
      this.txtName.Multiline = true;
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(286, 28);
      this.txtName.TabIndex = 1;
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Location = new System.Drawing.Point(1056, 33);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(101, 28);
      this.btnSearch.TabIndex = 2;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label1.ForeColor = System.Drawing.Color.Blue;
      this.label1.Location = new System.Drawing.Point(617, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(114, 25);
      this.label1.TabIndex = 3;
      this.label1.Text = "Nhập Tên:";
      // 
      // fEmployee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1243, 710);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox1);
      this.Name = "fEmployee";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fQLNV";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fQLNV_FormClosing);
      this.Load += new System.EventHandler(this.fEmployee_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
      this.ResumeLayout(false);
=======
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployee));
			this.ptbBillManagement = new System.Windows.Forms.PictureBox();
			this.ptbCustomerManagement = new System.Windows.Forms.PictureBox();
			this.ptbProductManagement = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ptbBillManagement)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbCustomerManagement)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbProductManagement)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ptbBillManagement
			// 
			this.ptbBillManagement.Image = ((System.Drawing.Image)(resources.GetObject("ptbBillManagement.Image")));
			this.ptbBillManagement.Location = new System.Drawing.Point(3, 3);
			this.ptbBillManagement.Name = "ptbBillManagement";
			this.ptbBillManagement.Size = new System.Drawing.Size(225, 250);
			this.ptbBillManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbBillManagement.TabIndex = 0;
			this.ptbBillManagement.TabStop = false;
			this.ptbBillManagement.Click += new System.EventHandler(this.ptbBillManagement_Click);
			this.ptbBillManagement.MouseHover += new System.EventHandler(this.ptbBillManagement_MouseHover);
			// 
			// ptbCustomerManagement
			// 
			this.ptbCustomerManagement.Image = ((System.Drawing.Image)(resources.GetObject("ptbCustomerManagement.Image")));
			this.ptbCustomerManagement.Location = new System.Drawing.Point(234, 3);
			this.ptbCustomerManagement.Name = "ptbCustomerManagement";
			this.ptbCustomerManagement.Size = new System.Drawing.Size(225, 250);
			this.ptbCustomerManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbCustomerManagement.TabIndex = 1;
			this.ptbCustomerManagement.TabStop = false;
			this.ptbCustomerManagement.Click += new System.EventHandler(this.ptbCustomerManagement_Click);
			this.ptbCustomerManagement.MouseHover += new System.EventHandler(this.ptbCustomerManagement_MouseHover);
			// 
			// ptbProductManagement
			// 
			this.ptbProductManagement.Image = ((System.Drawing.Image)(resources.GetObject("ptbProductManagement.Image")));
			this.ptbProductManagement.Location = new System.Drawing.Point(465, 3);
			this.ptbProductManagement.Name = "ptbProductManagement";
			this.ptbProductManagement.Size = new System.Drawing.Size(225, 250);
			this.ptbProductManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbProductManagement.TabIndex = 2;
			this.ptbProductManagement.TabStop = false;
			this.ptbProductManagement.Click += new System.EventHandler(this.ptbProductManagement_Click);
			this.ptbProductManagement.MouseHover += new System.EventHandler(this.ptbProductManagement_MouseHover);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.ptbBillManagement);
			this.panel1.Controls.Add(this.ptbProductManagement);
			this.panel1.Controls.Add(this.ptbCustomerManagement);
			this.panel1.Location = new System.Drawing.Point(33, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(693, 257);
			this.panel1.TabIndex = 3;
			// 
			// fEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 358);
			this.Controls.Add(this.panel1);
			this.Name = "fEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhân viên";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fEmployee_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.ptbBillManagement)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbCustomerManagement)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbProductManagement)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
>>>>>>> origin/main

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label label1;
  }
=======
		private System.Windows.Forms.PictureBox ptbBillManagement;
		private System.Windows.Forms.PictureBox ptbCustomerManagement;
		private System.Windows.Forms.PictureBox ptbProductManagement;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolTip toolTip;
	}
>>>>>>> origin/main
}