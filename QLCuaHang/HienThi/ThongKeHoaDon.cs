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
    public partial class ThongKeHoaDon : Form
    {
        Lib.Controllers.HoaDonNhapController hdnc = new Lib.Controllers.HoaDonNhapController();
        Lib.Controllers.HoaDonController hdc = new Lib.Controllers.HoaDonController();
        public ThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKeNhap_Click(object sender, EventArgs e)
        {
            dtvHDN.DataSource = hdnc.TimTheoNgay(dtpHDNTu.Value, dtpHDNDen.Value);
        }

        private void btnThongKeBan_Click(object sender, EventArgs e)
        {
            dtvHDB.DataSource = hdc.TimTheoNgay(dtpHDBTu.Value, dtpHDBDen.Value);
        }
    }
}
