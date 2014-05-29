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
    public partial class HoaDonBan : Form
    {
        Lib.Controllers.KhachHangController khc = new Lib.Controllers.KhachHangController();
        Lib.Controllers.MatHangController mhc = new Lib.Controllers.MatHangController();
        Lib.Controllers.HoaDonController hdc = new Lib.Controllers.HoaDonController();
        public HoaDonBan()
        {
            InitializeComponent();
            cbbMaKH.DataSource = khc.LayDSKhachHang();
            cbbMaKH.DisplayMember = "TenKH";
            cbbMaKH.ValueMember = "MaKH";
            cbbMaMH.DataSource = mhc.LayDSMatHang();
            cbbMaMH.DisplayMember = "TenMH";
            cbbMaMH.ValueMember = "MaMH";
            dtvHDB.DataSource = hdc.LayDSHDB();
            dtvCTHDB.DataSource = hdc.LayDSCTHDB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHDB_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.HoaDonBanInfo hdb = new Lib.InfoClass.HoaDonBanInfo();
            hdb.Mahdb = txtMaHDB.Text;
            hdb.Kh = new Lib.InfoClass.KhachHangInfo(cbbMaKH.SelectedValue.ToString(), cbbMaKH.SelectedText, null, null);
            hdb.Ngayban = dtpNgayBan.Value;
            int kq = hdc.ThemHDB(hdb);
            if (kq == -1)
                MessageBox.Show("Thêm Hóa Đơn Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Hóa Đơn Thành Công!");
                dtvHDB.DataSource = hdc.LayDSHDB();
            }
        }

        private void btnSuaHDB_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.HoaDonBanInfo hdb = new Lib.InfoClass.HoaDonBanInfo();
            hdb.Mahdb = txtMaHDB.Text;
            hdb.Kh = new Lib.InfoClass.KhachHangInfo(cbbMaKH.SelectedValue.ToString(), cbbMaKH.SelectedText, null, null);
            hdb.Ngayban = dtpNgayBan.Value;
            int kq = hdc.CapNhatHDB(hdb);
            if (kq == -1)
                MessageBox.Show("Cập Nhật Hóa Đơn Không Thành Công");
            else
            {
                MessageBox.Show("Cập Nhật Hóa Đơn Thành Công!");
                dtvHDB.DataSource = hdc.LayDSHDB();
            }
        }

        private void btnThemCTHDB_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.CTHoaDonBanInfo cthdb = new Lib.InfoClass.CTHoaDonBanInfo();
            cthdb.Hdb = new Lib.InfoClass.HoaDonBanInfo(txtMaHDB.Text, null, dtpNgayBan.Value);
            cthdb.Mh = new Lib.InfoClass.MatHangInfo(cbbMaMH.SelectedValue.ToString(), cbbMaMH.SelectedText, null, null, null);
            cthdb.Soluong = int.Parse(txtSoLuong.Text);
            cthdb.Dongia = float.Parse(txtDonGia.Text);
            int kq = hdc.ThemCTHDB(cthdb);
            if (kq == -1)
                MessageBox.Show("Thêm Chi Tiết Hóa Đơn Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Chi Tiết Hóa Đơn Thành Công!");
                dtvCTHDB.DataSource = hdc.LayDSCTHDB();
            }
        }

        private void btnSuaCTHDB_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.CTHoaDonBanInfo cthdb = new Lib.InfoClass.CTHoaDonBanInfo();
            cthdb.Hdb = new Lib.InfoClass.HoaDonBanInfo(txtMaHDB.Text, null, dtpNgayBan.Value);
            cthdb.Mh = new Lib.InfoClass.MatHangInfo(cbbMaMH.SelectedValue.ToString(), cbbMaMH.SelectedText, null, null, null);
            cthdb.Soluong = int.Parse(txtSoLuong.Text);
            cthdb.Dongia = float.Parse(txtDonGia.Text);
            int kq = hdc.CapNhatCTHDB(cthdb);
            if (kq == -1)
                MessageBox.Show("Cập Nhật Chi Tiết Hóa Đơn Không Thành Công");
            else
            {
                MessageBox.Show("Cập Nhật Chi Tiết Hóa Đơn Thành Công!");
                dtvCTHDB.DataSource = hdc.LayDSCTHDB();
            }
        }
    }
}
