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
    public partial class FormNhaCungCap : Form
    {
        Lib.Controllers.NhaCungCapController nccc = new Lib.Controllers.NhaCungCapController();
        public FormNhaCungCap()
        {
            InitializeComponent();
            dtvNCC.DataSource = nccc.LayDSNhaCungCap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.NhaCungCapInfo ncc = new Lib.InfoClass.NhaCungCapInfo();
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            int kq = nccc.ThemNhaCungCap(ncc);
            if (kq == -1)
                MessageBox.Show("Thêm Nhà Cung Cấp Không Thành Công");
            else
            {
                MessageBox.Show("Thêm Nhà Cung Cấp Thành Công!");
                dtvNCC.DataSource = nccc.LayDSNhaCungCap();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.NhaCungCapInfo ncc = new Lib.InfoClass.NhaCungCapInfo();
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            int kq = nccc.CapNhatNhaCungCap(ncc);
            if (kq == -1)
                MessageBox.Show("Cập Nhật Nhà Cung Cấp Không Thành Công");
            else
            {
                MessageBox.Show("Cập Nhật Nhà Cung Cấp Thành Công!");
                dtvNCC.DataSource = nccc.LayDSNhaCungCap();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Lib.InfoClass.NhaCungCapInfo ncc = new Lib.InfoClass.NhaCungCapInfo();
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text; ;
            dtvNCC.DataSource = nccc.TimNhaCungCap(ncc);
        }
    }
}
