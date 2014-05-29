using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Controllers
{
    class KhachHangController
    {
        Models.KhachHangModel khm = new Models.KhachHangModel();
        public int ThemKhachHang(InfoClass.KhachHangInfo kh)
        {
            return khm.ThemKhachHang(kh);
        }
        public DataTable LayDSKhachHang()
        {
            return khm.LayDSKH();
        }
        public DataTable TimKH(InfoClass.KhachHangInfo kh)
        {
            return khm.TimKH(kh);
        }
        public int CapNhatKhachHang(InfoClass.KhachHangInfo kh)
        {
            return khm.CapNhatKhachHang(kh);
        }
    }
}
