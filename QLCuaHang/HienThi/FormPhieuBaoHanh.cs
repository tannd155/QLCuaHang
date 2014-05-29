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
    public partial class FormPhieuBaoHanh : Form
    {
        Lib.Controllers.KhachHangController khc = new Lib.Controllers.KhachHangController();
        Lib.Controllers.PhieuBaoHanhController pbhc = new Lib.Controllers.PhieuBaoHanhController();
        Lib.Controllers.MatHangController mhc = new Lib.Controllers.MatHangController();
        public FormPhieuBaoHanh()
        {
            InitializeComponent();
            cbbKH.DataSource = khc.LayDSKhachHang();
            cbbKH.DisplayMember = "TenKH";
            cbbKH.ValueMember = "MaKH";
            cbbMH.DataSource = mhc.LayDSMatHang();
            cbbMH.DisplayMember = "TenMH";
            cbbMH.ValueMember = "MaMH";
            dtvBH.DataSource = pbhc.LayDSPBH();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.PhieuBaoHanhInfo pbh = new Lib.InfoClass.PhieuBaoHanhInfo();
            pbh.Sophieu = txtSoPhieu.Text;
            pbh.Khachhang = new Lib.InfoClass.KhachHangInfo(cbbKH.SelectedValue.ToString(), cbbKH.SelectedText,null,null);
            pbh.Mathang = new Lib.InfoClass.MatHangInfo(cbbMH.SelectedValue.ToString(), cbbMH.SelectedText, null, null, null);
            pbh.Ngaybatdau = dtpBatDau.Value;
            pbh.Ngayketthuc = dtpKetThuc.Value;
            int kq = pbhc.ThemPhieuBaoHanh(pbh);
            if (kq == -1)
                MessageBox.Show("Thêm Phiếu Bảo Hàng Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Phiếu Bảo Hành Thành Công!");
                dtvBH.DataSource = pbhc.LayDSPBH();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.PhieuBaoHanhInfo pbh = new Lib.InfoClass.PhieuBaoHanhInfo();
            pbh.Sophieu = txtSoPhieu.Text;
            pbh.Khachhang = new Lib.InfoClass.KhachHangInfo(cbbKH.SelectedValue.ToString(), cbbKH.SelectedText, null, null);
            pbh.Mathang = new Lib.InfoClass.MatHangInfo(cbbMH.SelectedValue.ToString(), cbbMH.SelectedText, null, null, null);
            pbh.Ngaybatdau = dtpBatDau.Value;
            pbh.Ngayketthuc = dtpKetThuc.Value;
            int kq = pbhc.CapNhatPhieuBaoHanh(pbh);
            if (kq == -1)
                MessageBox.Show("Thêm Phiếu Bảo Hàng Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Phiếu Bảo Hành Thành Công!");
                dtvBH.DataSource = pbhc.LayDSPBH();
            }
        }
    }
}
