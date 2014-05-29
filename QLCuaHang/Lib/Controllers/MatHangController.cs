using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Controllers
{
    class MatHangController
    {
        Models.MatHangModel mhm = new Models.MatHangModel();
        public int ThemMatHang(InfoClass.MatHangInfo mh)
        {
            return mhm.ThemMatHang(mh);
        }
        public DataTable LayDSMatHang()
        {
            return mhm.LayDSMH();
        }
        public DataTable TimMH(InfoClass.MatHangInfo mh)
        {
            return mhm.TimMH(mh);
        }
        public int CapNhatMatHang(InfoClass.MatHangInfo mh)
        {
            return mhm.CapNhatMatHang(mh);
        }
    }
}
