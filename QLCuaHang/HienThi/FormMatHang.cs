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
    public partial class FormMatHang : Form
    {
        Lib.Controllers.LoaiHangController lhc = new Lib.Controllers.LoaiHangController();
        Lib.Controllers.MatHangController mhc = new Lib.Controllers.MatHangController();
        public FormMatHang()
        {
            InitializeComponent();
            cbbLH.DataSource = lhc.LayDSLoaiHang();
            cbbLH.DisplayMember = "TenLoaiHang";
            cbbLH.ValueMember = "MaLoaiHang";
            dtvMH.DataSource = mhc.LayDSMatHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.MatHangInfo mh = new Lib.InfoClass.MatHangInfo();
            mh.Mamh = txtMaMH.Text;
            mh.Tenmh = txtTenMH.Text;
            mh.Lh = new Lib.InfoClass.LoaiHangInfo(cbbLH.SelectedValue.ToString(), cbbLH.SelectedText);
            mh.Donvitinh = txtDVT.Text;
            mh.Hangsx = txtHangSX.Text;
            int kq = mhc.ThemMatHang(mh);
            if (kq == -1)
                MessageBox.Show("Thêm Mặt Hàng Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Mặt Hàng Thành Công!");
                dtvMH.DataSource = mhc.LayDSMatHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.MatHangInfo mh = new Lib.InfoClass.MatHangInfo();
            mh.Mamh = txtMaMH.Text;
            mh.Tenmh = txtTenMH.Text;
            mh.Lh = new Lib.InfoClass.LoaiHangInfo(cbbLH.SelectedValue.ToString(), cbbLH.SelectedText);
            mh.Donvitinh = txtDVT.Text;
            mh.Hangsx = txtHangSX.Text;
            int kq = mhc.CapNhatMatHang(mh);
            if (kq == -1)
                MessageBox.Show("Cập Nhật Mặt Hàng Không Thành Công");
            else
            {
                MessageBox.Show("Cập Nhật Mặt Hàng Thành Công!");
                dtvMH.DataSource = mhc.LayDSMatHang();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.MatHangInfo mh = new Lib.InfoClass.MatHangInfo();
            mh.Mamh = txtMaMH.Text;
            mh.Tenmh = txtTenMH.Text;
            mh.Lh = new Lib.InfoClass.LoaiHangInfo(cbbLH.SelectedValue.ToString(), cbbLH.SelectedText);
            mh.Donvitinh = txtDVT.Text;
            mh.Hangsx = txtHangSX.Text;
            dtvMH.DataSource = mhc.TimMH(mh);
        }
    }
}
