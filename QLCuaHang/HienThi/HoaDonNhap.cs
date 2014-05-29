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
    public partial class HoaDonNhap : Form
    {
        Lib.Controllers.NhaCungCapController nccc = new Lib.Controllers.NhaCungCapController();
        Lib.Controllers.MatHangController mhc = new Lib.Controllers.MatHangController();
        Lib.Controllers.HoaDonNhapController hdnc = new Lib.Controllers.HoaDonNhapController();
        public HoaDonNhap()
        {
            InitializeComponent();
            cbbMaNCC.DataSource = nccc.LayDSNhaCungCap();
            cbbMaNCC.DisplayMember = "TenNCC";
            cbbMaNCC.ValueMember = "MaNCC";
            cbbMaMH.DataSource = mhc.LayDSMatHang();
            cbbMaMH.DisplayMember = "TenMH";
            cbbMaMH.ValueMember = "MaMH";
            dtvHDN.DataSource = hdnc.LayDSHDN();
            dtvCTHDN.DataSource = hdnc.LayDSCTHDN();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHDN_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.HoaDonNhapInfo hdn = new Lib.InfoClass.HoaDonNhapInfo();
            hdn.Mahdn = txtMaHDN.Text;
            hdn.Ncc = new Lib.InfoClass.NhaCungCapInfo(cbbMaNCC.SelectedValue.ToString(), cbbMaNCC.SelectedText);
            hdn.Ngaynhap = dtpNgayNhap.Value;
            int kq = hdnc.ThemHDN(hdn);
            if (kq == -1)
                MessageBox.Show("Thêm Hóa Đơn Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Hóa Đơn Thành Công!");
                dtvHDN.DataSource = hdnc.LayDSHDN();
            }
        }

        private void btnSuaHDN_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.HoaDonNhapInfo hdn = new Lib.InfoClass.HoaDonNhapInfo();
            hdn.Mahdn = txtMaHDN.Text;
            hdn.Ncc = new Lib.InfoClass.NhaCungCapInfo(cbbMaNCC.SelectedValue.ToString(), cbbMaNCC.SelectedText);
            hdn.Ngaynhap = dtpNgayNhap.Value;
            int kq = hdnc.CapNhatHDN(hdn);
            if (kq == -1)
                MessageBox.Show("Cập Nhật Hóa Đơn Không Thành Công");
            else
            {
                MessageBox.Show("Cập Nhật Hóa Đơn Thành Công!");
                dtvHDN.DataSource = hdnc.LayDSHDN();
            }
        }

        private void btnThemCTHDN_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.CTHoaDonNhapInfo cthdn = new Lib.InfoClass.CTHoaDonNhapInfo();
            cthdn.Hdn = new Lib.InfoClass.HoaDonNhapInfo(txtMaHDN.Text, null, dtpNgayNhap.Value);
            cthdn.Mh = new Lib.InfoClass.MatHangInfo(cbbMaMH.SelectedValue.ToString(), cbbMaMH.SelectedText, null, null, null);
            cthdn.Soluong = int.Parse(txtSoLuong.Text);
            cthdn.Dongia = float.Parse(txtDonGia.Text);
            int kq = hdnc.ThemCTHDN(cthdn);
            if (kq == -1)
                MessageBox.Show("Thêm Chi Tiết Hóa Đơn Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Chi Tiết Hóa Đơn Thành Công!");
                dtvCTHDN.DataSource = hdnc.LayDSCTHDN();
            }
        }

        private void btnSuaCTHDN_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.CTHoaDonNhapInfo cthdn = new Lib.InfoClass.CTHoaDonNhapInfo();
            cthdn.Hdn = new Lib.InfoClass.HoaDonNhapInfo(txtMaHDN.Text, null, dtpNgayNhap.Value);
            cthdn.Mh = new Lib.InfoClass.MatHangInfo(cbbMaMH.SelectedValue.ToString(), cbbMaMH.SelectedText, null, null, null);
            cthdn.Soluong = int.Parse(txtSoLuong.Text);
            cthdn.Dongia = float.Parse(txtDonGia.Text);
            int kq = hdnc.CapNhatCTHDN(cthdn);
            if (kq == -1)
                MessageBox.Show("Cập Nhật Chi Tiết Hóa Đơn Không Thành Công");
            else
            {
                MessageBox.Show("Cập Nhật Chi Tiết Hóa Đơn Thành Công!");
                dtvCTHDN.DataSource = hdnc.LayDSCTHDN();
            }
        }
    }
}
