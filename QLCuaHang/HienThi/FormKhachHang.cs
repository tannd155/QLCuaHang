using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QLCuaHang.HienThi
{
    public partial class FormKhachHang : Form
    {
        Lib.Controllers.KhachHangController khc = new Lib.Controllers.KhachHangController();
        public FormKhachHang()
        {
            InitializeComponent();
            dtvKH.DataSource = khc.LayDSKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.KhachHangInfo kh = new Lib.InfoClass.KhachHangInfo();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SoDienThoai = txtSoDienThoai.Text;
            int kq = khc.ThemKhachHang(kh);
            if (kq == -1)
                MessageBox.Show("Thêm Khách Hàng Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Khách Hàng Thành Công!");
                dtvKH.DataSource = khc.LayDSKhachHang();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtvKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Lib.InfoClass.KhachHangInfo kh = new Lib.InfoClass.KhachHangInfo();
                kh.MaKH= dtvKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                DataTable dt = khc.TimKH(kh);
                txtMaKH.Text = dt.Rows[0]["MaKH"].ToString();
                txtTenKH.Text = dt.Rows[0]["TenKH"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["DienThoai"].ToString();
            }
            catch
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.KhachHangInfo kh = new Lib.InfoClass.KhachHangInfo();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SoDienThoai = txtSoDienThoai.Text;
            int kq = khc.CapNhatKhachHang(kh);
            if (kq == -1)
                MessageBox.Show("Cập Nhật Khách Hàng Không Thành Công");
            else
            {
                MessageBox.Show("Cập Nhật Khách Hàng Thành Công!");
                dtvKH.DataSource = khc.LayDSKhachHang();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.KhachHangInfo kh = new Lib.InfoClass.KhachHangInfo();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SoDienThoai = txtSoDienThoai.Text;
            dtvKH.DataSource = khc.TimKH(kh);
        }
    }
}
