﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QL_BanHoa.Employee {
	public partial class frmProductManagement : Form {
		public frmProductManagement() {
			InitializeComponent();
		}

		private void frmProductManagement_FormClosing(object sender, FormClosingEventArgs e) {
			if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
				e.Cancel = true;
			}
		}
	}
}
