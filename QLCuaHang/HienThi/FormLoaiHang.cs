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
    public partial class FormLoaiHang : Form
    {
        Lib.Controllers.LoaiHangController lhc = new Lib.Controllers.LoaiHangController();
        public FormLoaiHang()
        {
            InitializeComponent();
            dtvLH.DataSource = lhc.LayDSLoaiHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.LoaiHangInfo lh = new Lib.InfoClass.LoaiHangInfo();
            lh.Maloaihang = txtMaLH.Text;
            lh.Tenloaihang = txtTenLH.Text;
            int kq = lhc.ThemLoaiHang(lh);
            if (kq == -1)
                MessageBox.Show("Thêm Loại Hàng Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Loại Hàng Thành Công!");
                dtvLH.DataSource = lhc.LayDSLoaiHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.LoaiHangInfo lh = new Lib.InfoClass.LoaiHangInfo();
            lh.Maloaihang = txtMaLH.Text;
            lh.Tenloaihang = txtTenLH.Text;
            int kq = lhc.CapNhatLoaiHang(lh);
            if (kq == -1)
                MessageBox.Show("Cập Nhật Loại Hàng Không Thành Công");
            else
            {
                MessageBox.Show("Cập Nhật Loại Hàng Thành Công!");
                dtvLH.DataSource = lhc.LayDSLoaiHang();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.LoaiHangInfo lh = new Lib.InfoClass.LoaiHangInfo();
            lh.Maloaihang = txtMaLH.Text;
            lh.Tenloaihang = txtTenLH.Text;
            dtvLH.DataSource = lhc.TimLoaiHang(lh);
        }
    }
}
