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
        }
    }
}
