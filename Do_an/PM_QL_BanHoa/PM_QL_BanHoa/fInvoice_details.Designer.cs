namespace PM_QL_BanHoa {
  partial class fInvoice_details {
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
      this.dgvInvoice_details = new System.Windows.Forms.DataGridView();
      this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtMa = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice_details)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvInvoice_details
      // 
      this.dgvInvoice_details.AllowUserToOrderColumns = true;
      this.dgvInvoice_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvInvoice_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvInvoice_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvInvoice_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaSP,
            this.colSoLuong});
      this.dgvInvoice_details.Location = new System.Drawing.Point(24, 77);
      this.dgvInvoice_details.Name = "dgvInvoice_details";
      this.dgvInvoice_details.RowHeadersWidth = 51;
      this.dgvInvoice_details.RowTemplate.Height = 24;
      this.dgvInvoice_details.Size = new System.Drawing.Size(1133, 589);
      this.dgvInvoice_details.TabIndex = 0;
      // 
      // colMaHD
      // 
      this.colMaHD.DataPropertyName = "MaHD";
      this.colMaHD.HeaderText = "MaHD";
      this.colMaHD.MinimumWidth = 6;
      this.colMaHD.Name = "colMaHD";
      this.colMaHD.ReadOnly = true;
      // 
      // colMaSP
      // 
      this.colMaSP.DataPropertyName = "MaSP";
      this.colMaSP.HeaderText = "MaSP";
      this.colMaSP.MinimumWidth = 6;
      this.colMaSP.Name = "colMaSP";
      // 
      // colSoLuong
      // 
      this.colSoLuong.DataPropertyName = "SoLuong";
      this.colSoLuong.HeaderText = "SoLuong";
      this.colSoLuong.MinimumWidth = 6;
      this.colSoLuong.Name = "colSoLuong";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.txtMa);
      this.groupBox1.Controls.Add(this.dgvInvoice_details);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Blue;
      this.groupBox1.Location = new System.Drawing.Point(30, 27);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1185, 699);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Quản Lý Chi Tiết Hóa Đơn";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label1.ForeColor = System.Drawing.Color.Blue;
      this.label1.Location = new System.Drawing.Point(616, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "Nhập Mã:";
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
      // txtMa
      // 
      this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMa.Location = new System.Drawing.Point(742, 29);
      this.txtMa.Multiline = true;
      this.txtMa.Name = "txtMa";
      this.txtMa.Size = new System.Drawing.Size(286, 28);
      this.txtMa.TabIndex = 4;
      // 
      // fInvoice_details
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.groupBox1);
      this.Name = "fInvoice_details";
      this.Text = "fInvoice_details";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fInvoice_details_FormClosing);
      this.Load += new System.EventHandler(this.fInvoice_details_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice_details)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvInvoice_details;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtMa;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
  }
}