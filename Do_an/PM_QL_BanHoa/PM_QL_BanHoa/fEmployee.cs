using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PM_QL_BanHoa.Employee;

namespace PM_QL_BanHoa {
	public partial class fEmployee : Form {
		public fEmployee() {
			InitializeComponent();
		}

		private void fEmployee_FormClosing(object sender, FormClosingEventArgs e) {
			if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
				e.Cancel = true;
			}
		}

		private void ptbBillManagement_MouseHover(object sender, EventArgs e) {
			toolTip.SetToolTip(this.ptbBillManagement, "Quản lý hóa đơn");
		}

		private void ptbCustomerManagement_MouseHover(object sender, EventArgs e) {
			toolTip.SetToolTip(this.ptbCustomerManagement, "Quản lý khách hàng");
		}

		private void ptbProductManagement_MouseHover(object sender, EventArgs e) {
			toolTip.SetToolTip(this.ptbProductManagement, "Quản lý sản phẩm");
		}

		private void ptbBillManagement_Click(object sender, EventArgs e) {
			frmBillManagement billManagement = new frmBillManagement();

			this.Hide();
			billManagement.ShowDialog();
			this.Show();
		}

		private void ptbCustomerManagement_Click(object sender, EventArgs e) {
			frmCustomerManagement customerManagement = new frmCustomerManagement();

			this.Hide();
			customerManagement.ShowDialog();
			this.Show();
		}

		private void ptbProductManagement_Click(object sender, EventArgs e) {
			frmProductManagement productManagement = new frmProductManagement();

			this.Hide();
			productManagement.ShowDialog();
			this.Show();
		}

	}
}
