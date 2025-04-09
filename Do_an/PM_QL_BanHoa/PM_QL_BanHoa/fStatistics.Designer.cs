namespace PM_QL_BanHoa {
  partial class fStatistics {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatistics));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnAll = new System.Windows.Forms.Button();
      this.dateTo = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.dateFrom = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.btnFilter = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtRevenue = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.groupBox1.Controls.Add(this.txtRevenue);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.btnAll);
      this.groupBox1.Controls.Add(this.dateTo);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.dateFrom);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnFilter);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Blue;
      this.groupBox1.Location = new System.Drawing.Point(52, 54);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1165, 652);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thống Kê Doanh Thu";
      // 
      // btnAll
      // 
      this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAll.BackgroundImage")));
      this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAll.Location = new System.Drawing.Point(717, 479);
      this.btnAll.Name = "btnAll";
      this.btnAll.Size = new System.Drawing.Size(150, 150);
      this.btnAll.TabIndex = 10;
      this.btnAll.UseVisualStyleBackColor = true;
      this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
      // 
      // dateTo
      // 
      this.dateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTo.CustomFormat = "\'   Ngày\' dd \'  Tháng\' MM \'  Năm\' yyyy";
      this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTo.Location = new System.Drawing.Point(319, 216);
      this.dateTo.Name = "dateTo";
      this.dateTo.Size = new System.Drawing.Size(778, 45);
      this.dateTo.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Blue;
      this.label2.Location = new System.Drawing.Point(70, 216);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(181, 38);
      this.label2.TabIndex = 8;
      this.label2.Text = "Đến Ngày:";
      // 
      // dateFrom
      // 
      this.dateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateFrom.CustomFormat = "\'   Ngày\' dd \'  Tháng\' MM \'  Năm\' yyyy";
      this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateFrom.Location = new System.Drawing.Point(319, 102);
      this.dateFrom.Name = "dateFrom";
      this.dateFrom.Size = new System.Drawing.Size(778, 45);
      this.dateFrom.TabIndex = 7;
      this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Blue;
      this.label1.Location = new System.Drawing.Point(70, 102);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(158, 38);
      this.label1.TabIndex = 6;
      this.label1.Text = "Từ Ngày:";
      // 
      // btnFilter
      // 
      this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
      this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFilter.Location = new System.Drawing.Point(947, 479);
      this.btnFilter.Name = "btnFilter";
      this.btnFilter.Size = new System.Drawing.Size(150, 150);
      this.btnFilter.TabIndex = 5;
      this.btnFilter.UseVisualStyleBackColor = true;
      this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Blue;
      this.label3.Location = new System.Drawing.Point(70, 331);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(197, 38);
      this.label3.TabIndex = 11;
      this.label3.Text = "Doanh Thu:";
      // 
      // txtRevenue
      // 
      this.txtRevenue.Location = new System.Drawing.Point(319, 331);
      this.txtRevenue.Name = "txtRevenue";
      this.txtRevenue.ReadOnly = true;
      this.txtRevenue.Size = new System.Drawing.Size(778, 45);
      this.txtRevenue.TabIndex = 12;
      // 
      // fStatistics
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.groupBox1);
      this.Name = "fStatistics";
      this.Text = "fStatistics";
      this.Load += new System.EventHandler(this.fStatistics_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dateFrom;
    private System.Windows.Forms.DateTimePicker dateTo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAll;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtRevenue;
  }
}