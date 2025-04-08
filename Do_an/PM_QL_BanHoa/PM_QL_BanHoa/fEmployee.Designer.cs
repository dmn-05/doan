namespace PM_QL_BanHoa {
	partial class fEmployee {
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

		}

		#endregion

		private System.Windows.Forms.PictureBox ptbBillManagement;
		private System.Windows.Forms.PictureBox ptbCustomerManagement;
		private System.Windows.Forms.PictureBox ptbProductManagement;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolTip toolTip;
	}
}