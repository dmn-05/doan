﻿namespace PM_QL_BanHoa
{
    partial class fCustomer
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomer));
      this.dgvCustomer = new System.Windows.Forms.DataGridView();
      this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvCustomer
      // 
      this.dgvCustomer.AllowUserToOrderColumns = true;
      this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colSoDienThoai,
            this.colEmail,
            this.colDiaChi});
      this.dgvCustomer.Location = new System.Drawing.Point(24, 77);
      this.dgvCustomer.Name = "dgvCustomer";
      this.dgvCustomer.RowHeadersWidth = 51;
      this.dgvCustomer.RowTemplate.Height = 24;
      this.dgvCustomer.Size = new System.Drawing.Size(1133, 487);
      this.dgvCustomer.TabIndex = 0;
      // 
      // colMaKH
      // 
      this.colMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMaKH.DataPropertyName = "MaKH";
      this.colMaKH.FillWeight = 128.3422F;
      this.colMaKH.HeaderText = "MaKH";
      this.colMaKH.MinimumWidth = 70;
      this.colMaKH.Name = "colMaKH";
      this.colMaKH.ReadOnly = true;
      this.colMaKH.Width = 70;
      // 
      // colTenKH
      // 
      this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTenKH.DataPropertyName = "TenKH";
      this.colTenKH.FillWeight = 518.8315F;
      this.colTenKH.HeaderText = "TenKH";
      this.colTenKH.MinimumWidth = 140;
      this.colTenKH.Name = "colTenKH";
      this.colTenKH.Width = 190;
      // 
      // colSoDienThoai
      // 
      this.colSoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colSoDienThoai.DataPropertyName = "SoDienThoai";
      this.colSoDienThoai.FillWeight = 25.47104F;
      this.colSoDienThoai.HeaderText = "SoDienThoai";
      this.colSoDienThoai.MinimumWidth = 120;
      this.colSoDienThoai.Name = "colSoDienThoai";
      this.colSoDienThoai.Width = 120;
      // 
      // colEmail
      // 
      this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colEmail.DataPropertyName = "Email";
      this.colEmail.HeaderText = "Email";
      this.colEmail.MinimumWidth = 100;
      this.colEmail.Name = "colEmail";
      // 
      // colDiaChi
      // 
      this.colDiaChi.DataPropertyName = "DiaChi";
      this.colDiaChi.FillWeight = 25.47104F;
      this.colDiaChi.HeaderText = "DiaChi";
      this.colDiaChi.MinimumWidth = 200;
      this.colDiaChi.Name = "colDiaChi";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.txtName);
      this.groupBox1.Controls.Add(this.dgvCustomer);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Blue;
      this.groupBox1.Location = new System.Drawing.Point(29, 42);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1185, 597);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Quản Lý Khách Hàng";
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.Black;
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(1080, 659);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(135, 67);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "    Lưu";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label1.ForeColor = System.Drawing.Color.Blue;
      this.label1.Location = new System.Drawing.Point(616, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(114, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "Nhập Tên:";
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Location = new System.Drawing.Point(1055, 29);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(101, 28);
      this.btnSearch.TabIndex = 5;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(742, 29);
      this.txtName.Multiline = true;
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(286, 28);
      this.txtName.TabIndex = 4;
      // 
      // fCustomer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnSave);
      this.Name = "fCustomer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fCustomer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fCustomer_FormClosing);
      this.Load += new System.EventHandler(this.fCustomer_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.DataGridView dgvCustomer;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtName;
  }
}