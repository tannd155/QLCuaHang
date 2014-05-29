using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Controllers
{
    class HoaDonNhapController
    {
        Models.HoaDonNhapModel hdnm = new Models.HoaDonNhapModel();
        public DataTable LayDSHDN()
        {
            return hdnm.LayDSHDN();
        }
        public DataTable LayDSCTHDN()
        {
            return hdnm.LayDSCTHDN();
        }
        public DataTable TimTheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            return hdnm.TimTheoNgay(TuNgay, DenNgay);
        }
        public int ThemHDN(InfoClass.HoaDonNhapInfo hdn)
        {
            return hdnm.ThemHoaDonNhap(hdn);
        }
        public int CapNhatHDN(InfoClass.HoaDonNhapInfo hdn)
        {
            return hdnm.CapNhatHoaDonNhap(hdn);
        }
        public int ThemCTHDN(InfoClass.CTHoaDonNhapInfo cthdn)
        {
            return hdnm.ThemCTHoaDonNhap(cthdn);
        }
        public int CapNhatCTHDN(InfoClass.CTHoaDonNhapInfo cthdn)
        {
            return hdnm.CapNhatCTHoaDonNhap(cthdn);
        }
    }
}
