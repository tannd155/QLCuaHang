using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Controllers
{
    class HoaDonController
    {
        Models.HoaDonModel hdm = new Models.HoaDonModel();
        public DataTable LayDSHDB()
        {
            return hdm.LayDSHDB();
        }
        public DataTable LayDSCTHDB()
        {
            return hdm.LayDSCTHDB();
        }
        public DataTable TimTheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            return hdm.TimTheoNgay(TuNgay, DenNgay);
        }
        public int ThemHDB(InfoClass.HoaDonBanInfo hdb)
        {
            return hdm.ThemHoaDonBan(hdb);
        }
        public int CapNhatHDB(InfoClass.HoaDonBanInfo hdb)
        {
            return hdm.CapNhatHoaDonBan(hdb);
        }
        public int ThemCTHDB(InfoClass.CTHoaDonBanInfo cthdb)
        {
            return hdm.ThemCTHoaDonBan(cthdb);
        }
        public int CapNhatCTHDB(InfoClass.CTHoaDonBanInfo cthdb)
        {
            return hdm.CapNhatCTHoaDonBan(cthdb);
        }
    }
}
