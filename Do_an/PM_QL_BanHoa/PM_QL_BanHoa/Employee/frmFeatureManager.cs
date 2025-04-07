using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QL_BanHoa.Employee {
	public partial class frmFeatureManager : Form {
		public frmFeatureManager() {
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e) {

		}

		private void pictureBox2_Click(object sender, EventArgs e) {

		}

		private void pictureBox3_Click(object sender, EventArgs e) {

		}

		private void pictureBox4_Click(object sender, EventArgs e) {

		}

		private void pictureBox1_MouseHover(object sender, EventArgs e) {
			ttip_Description.SetToolTip(ptbProductManagement, "Quản lý sản phẩm");
		}

		private void ptbCustomerManagement_MouseHover(object sender, EventArgs e) {
			ttip_Description.SetToolTip(ptbCustomerManagement, "Quản lý khách hàng");
		}

		private void ptbCheckout_MouseHover(object sender, EventArgs e) {
			ttip_Description.SetToolTip(ptbCheckout, "Quản lý hóa đơn");
		}

	}
}
