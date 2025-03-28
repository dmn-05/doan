namespace PM_QL_BanHoa
{
    partial class fProduct
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProduct));
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dgvProduct = new System.Windows.Forms.DataGridView();
      this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGiaBanLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSoLuongTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.Black;
      this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
      this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button1.Location = new System.Drawing.Point(1080, 662);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(135, 67);
      this.button1.TabIndex = 3;
      this.button1.Text = "    Lưu";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.dgvProduct);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.ForeColor = System.Drawing.Color.Blue;
      this.groupBox2.Location = new System.Drawing.Point(26, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1189, 641);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Quản Lý Sản Phẩm";
      // 
      // dgvProduct
      // 
      this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colGiaBanLe,
            this.colGiaNhap,
            this.colGiaXuat,
            this.colSoLuongTonKho});
      this.dgvProduct.Location = new System.Drawing.Point(26, 46);
      this.dgvProduct.Name = "dgvProduct";
      this.dgvProduct.RowHeadersWidth = 51;
      this.dgvProduct.RowTemplate.Height = 24;
      this.dgvProduct.Size = new System.Drawing.Size(1137, 551);
      this.dgvProduct.TabIndex = 1;
      // 
      // colMaSP
      // 
      this.colMaSP.DataPropertyName = "MaSP";
      this.colMaSP.HeaderText = "MaSP";
      this.colMaSP.MinimumWidth = 6;
      this.colMaSP.Name = "colMaSP";
      // 
      // colTenSP
      // 
      this.colTenSP.DataPropertyName = "TenSP";
      this.colTenSP.HeaderText = "TenSP";
      this.colTenSP.MinimumWidth = 6;
      this.colTenSP.Name = "colTenSP";
      // 
      // colGiaBanLe
      // 
      this.colGiaBanLe.DataPropertyName = "GiaBanLe";
      this.colGiaBanLe.HeaderText = "GiaBanLe";
      this.colGiaBanLe.MinimumWidth = 6;
      this.colGiaBanLe.Name = "colGiaBanLe";
      // 
      // colGiaNhap
      // 
      this.colGiaNhap.DataPropertyName = "GiaNhap";
      this.colGiaNhap.HeaderText = "GiaNhap";
      this.colGiaNhap.MinimumWidth = 6;
      this.colGiaNhap.Name = "colGiaNhap";
      // 
      // colGiaXuat
      // 
      this.colGiaXuat.DataPropertyName = "GiaXuat";
      this.colGiaXuat.HeaderText = "GiaXuat";
      this.colGiaXuat.MinimumWidth = 6;
      this.colGiaXuat.Name = "colGiaXuat";
      // 
      // colSoLuongTonKho
      // 
      this.colSoLuongTonKho.DataPropertyName = "SoLuongTonKho";
      this.colSoLuongTonKho.HeaderText = "SoLuongTonKho";
      this.colSoLuongTonKho.MinimumWidth = 6;
      this.colSoLuongTonKho.Name = "colSoLuongTonKho";
      // 
      // fProduct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.button1);
      this.Name = "fProduct";
      this.Text = "fProduct";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fProduct_FormClosing);
      this.Load += new System.EventHandler(this.fProduct_Load);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dgvProduct;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBanLe;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGiaXuat;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTonKho;
  }
}