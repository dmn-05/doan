namespace PM_QL_BanHoa.Employee {
	partial class frmFeatureManager {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeatureManager));
			this.panel1 = new System.Windows.Forms.Panel();
			this.ptbCheckout = new System.Windows.Forms.PictureBox();
			this.ptbCustomerManagement = new System.Windows.Forms.PictureBox();
			this.ptbProductManagement = new System.Windows.Forms.PictureBox();
			this.ttip_Description = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbCheckout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbCustomerManagement)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbProductManagement)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ptbCheckout);
			this.panel1.Controls.Add(this.ptbCustomerManagement);
			this.panel1.Controls.Add(this.ptbProductManagement);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(819, 374);
			this.panel1.TabIndex = 1;
			// 
			// ptbCheckout
			// 
			this.ptbCheckout.Image = ((System.Drawing.Image)(resources.GetObject("ptbCheckout.Image")));
			this.ptbCheckout.Location = new System.Drawing.Point(554, 87);
			this.ptbCheckout.Name = "ptbCheckout";
			this.ptbCheckout.Size = new System.Drawing.Size(200, 200);
			this.ptbCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbCheckout.TabIndex = 3;
			this.ptbCheckout.TabStop = false;
			this.ptbCheckout.Click += new System.EventHandler(this.pictureBox4_Click);
			this.ptbCheckout.MouseHover += new System.EventHandler(this.ptbCheckout_MouseHover);
			// 
			// ptbCustomerManagement
			// 
			this.ptbCustomerManagement.Image = ((System.Drawing.Image)(resources.GetObject("ptbCustomerManagement.Image")));
			this.ptbCustomerManagement.Location = new System.Drawing.Point(310, 87);
			this.ptbCustomerManagement.Name = "ptbCustomerManagement";
			this.ptbCustomerManagement.Size = new System.Drawing.Size(200, 200);
			this.ptbCustomerManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbCustomerManagement.TabIndex = 1;
			this.ptbCustomerManagement.TabStop = false;
			this.ptbCustomerManagement.Click += new System.EventHandler(this.pictureBox2_Click);
			this.ptbCustomerManagement.MouseHover += new System.EventHandler(this.ptbCustomerManagement_MouseHover);
			// 
			// ptbProductManagement
			// 
			this.ptbProductManagement.Image = ((System.Drawing.Image)(resources.GetObject("ptbProductManagement.Image")));
			this.ptbProductManagement.Location = new System.Drawing.Point(66, 87);
			this.ptbProductManagement.Name = "ptbProductManagement";
			this.ptbProductManagement.Size = new System.Drawing.Size(200, 200);
			this.ptbProductManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbProductManagement.TabIndex = 0;
			this.ptbProductManagement.TabStop = false;
			this.ptbProductManagement.Click += new System.EventHandler(this.pictureBox1_Click);
			this.ptbProductManagement.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
			// 
			// frmFeatureManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 399);
			this.Controls.Add(this.panel1);
			this.Name = "frmFeatureManager";
			this.Text = "Quản lý chức năng";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbCheckout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbCustomerManagement)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbProductManagement)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox ptbProductManagement;
		private System.Windows.Forms.PictureBox ptbCheckout;
		private System.Windows.Forms.PictureBox ptbCustomerManagement;
		private System.Windows.Forms.ToolTip ttip_Description;
	}
}