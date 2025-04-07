using PM_QL_BanHoa.BUS;
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


namespace PM_QL_BanHoa {
  public partial class fLogin : Form {
    public fLogin() {
      InitializeComponent();
    }

    private void btnExit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void btnLogin_Click(object sender, EventArgs e) {
      fAdmin f_Admin = new fAdmin();
      fEmployee f_Employee = new fEmployee();
      
      string Username = txtUserName.Text;
      string Password = txtPassword.Text;

      if (Login_Admin(Username, Password)) {
				MessageBox.Show(
					"Đăng nhập thành công quản trị viên",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				this.Hide();
        f_Admin.ShowDialog();
        this.Show();
      } else if (Login(Username, Password)) {
        MessageBox.Show(
          "Đăng nhập thành công nhân viên",
          "Thông báo",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information
        );
        this.Hide();
        f_Employee.ShowDialog();
        this.Show();
      } else {
				MessageBox.Show(
					"Đăng nhập thất bại",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
    }
    private bool Login(string username, string password) {
      return AccountBUS.Instance.Login(username, password);
    }
    private bool Login_Admin(string username, string password) {
      return AccountBUS.Instance.Login_Admin(username, password);
    }
    private void fLogin_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }

    private void chkShowPass_CheckedChanged(object sender, EventArgs e) {
      if (chkShowPass.Checked == true) {
        txtPassword.UseSystemPasswordChar = false;
      } else {
        txtPassword.UseSystemPasswordChar = true;
      }
    }
  }
}
