using BUS;
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
  public partial class fInvoice : Form {
    DataSet dsHoaDon = new DataSet();
    public fInvoice() {
      InitializeComponent();
    }

    private void fInvoice_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }

    private void btnPrint_Click(object sender, EventArgs e) {

    }

    private void fInvoice_Load(object sender, EventArgs e) {
      dgvInvoice.AutoGenerateColumns = false;

      LoadDSHD();
    }
    private void LoadDSHD() {
      string query = "Select * From HoaDon";
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query);
      if (dsHoaDon.Tables.Count > 0) {
        dsHoaDon.Tables[0].Clear();
        dsHoaDon.Tables[0].Merge(data);
      } else {
        dsHoaDon.Tables.Add(data);
      }
      dgvInvoice.DataSource = dsHoaDon.Tables[0]; // Đặt trực tiếp DataTable vào DataGridView
    }

    private void dgvInvoice_SelectionChanged(object sender, EventArgs e) {
      if (dgvInvoice.SelectedRows.Count > 0) {
        txtMaHD.Text = dgvInvoice.SelectedRows[0].Cells["colMaHD"].Value.ToString();
        txtMaKH.Text = dgvInvoice.SelectedRows[0].Cells["colMaKH"].Value.ToString();
        txtMaNV.Text = dgvInvoice.SelectedRows[0].Cells["colMaNV"].Value.ToString();
        txtThanhTien.Text = dgvInvoice.SelectedRows[0].Cells["colThanhTien"].Value.ToString();
        dateNgayLapHD.Value = Convert.ToDateTime(dgvInvoice.SelectedRows[0].Cells["colNgayLapHoaDon"].Value);
        txtDiaChiGiao.Text = dgvInvoice.SelectedRows[0].Cells["colDiaChiGiao"].Value.ToString();
        txtTrangThai.Text = dgvInvoice.SelectedRows[0].Cells["colTrangThai"].Value.ToString();
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(txtMaHD.Text)) {
        MessageBox.Show("Bạn chưa chọn!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else if(Xoa()){
        MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } else {
        MessageBox.Show("Đã xóa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      LoadDSHD();
    }
    private bool Xoa() {
      string query = "Delete From HoaDon Where MaHD = @MaHD";
      if (DataProviderBUS.Instance.ExecuteNonQuery(query, new Object[] { txtMaHD.Text }) > 0) {
        return true;
      }
      return false;
    }
  }
}
