using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Controllers
{
    class LoaiHangController
    {
        Models.LoaiHangModel lhm = new Models.LoaiHangModel();
        public DataTable LayDSLoaiHang()
        {
            return lhm.LayDSLH();
        }
        public int ThemLoaiHang(InfoClass.LoaiHangInfo lh)
        {
            return lhm.ThemLoaiHang(lh);
        }
        public int CapNhatLoaiHang(InfoClass.LoaiHangInfo lh)
        {
            return lhm.CapNhatLoaiHang(lh);
        }
        public DataTable TimLoaiHang(InfoClass.LoaiHangInfo lh)
        {
            return lhm.TimLH(lh);
        }
    }
}
