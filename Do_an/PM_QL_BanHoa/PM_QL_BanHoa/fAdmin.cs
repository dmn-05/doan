using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QL_BanHoa {
  public partial class fAdmin : Form {
    public fAdmin() {
      InitializeComponent();
    }

    private void picQLSP_Click(object sender, EventArgs e) {

    }

    private void fAdmin_Load(object sender, EventArgs e) {

    }

    private void fAdmin_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }

    private void picEmployee_Click(object sender, EventArgs e) {
      fEmployee f = new fEmployee();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picCustomer_Click(object sender, EventArgs e) {
      fCustomer f = new fCustomer();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picInvoice_Click(object sender, EventArgs e) {
      fInvoice f = new fInvoice();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picInvoice_details_Click(object sender, EventArgs e) {

    }

    private void picImport_goods_Click(object sender, EventArgs e) {
      fImport_goods f = new fImport_goods();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picExport_goods_Click(object sender, EventArgs e) {

    }

    private void picStatistics_Click(object sender, EventArgs e) {

    }
  }
}
