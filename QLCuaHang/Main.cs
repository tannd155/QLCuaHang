using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QLCuaHang
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi.FormKhachHang f = new HienThi.FormKhachHang();
            f.Show();
            this.Visible = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn Có Muốn Thoát Không?","Thoát Chương Trình",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }

        private void thêmPhiếuBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi.FormPhieuBaoHanh f = new HienThi.FormPhieuBaoHanh();
            f.Show();
            this.Visible = true;
        }

        private void thêmLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi.FormLoaiHang f = new HienThi.FormLoaiHang();
            f.Show();
            this.Visible = true;
        }

        private void thêmNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi.FormNhaCungCap f = new HienThi.FormNhaCungCap();
            f.Show();
            this.Visible = true;
        }

        private void thêmMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi.FormMatHang f = new HienThi.FormMatHang();
            f.Show();
            this.Visible = true;
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi.HoaDonBan f = new HienThi.HoaDonBan();
            f.Show();
            this.Visible = true;
        }

        private void thêmHóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HienThi.HoaDonNhap f = new HienThi.HoaDonNhap();
            f.Show();
            this.Visible = true;
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi.TacGia f = new HienThi.TacGia();
            f.Show();
            this.Visible = true;
        }
    }
}
