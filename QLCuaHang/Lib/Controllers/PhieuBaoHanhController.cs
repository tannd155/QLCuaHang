using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Controllers
{
    class PhieuBaoHanhController
    {
        Models.PhieuBaoHanhModel pbhm = new Models.PhieuBaoHanhModel();

        public DataTable LayDSPBH()
        {
            return pbhm.LayDSPBH();
        }

        public int ThemPhieuBaoHanh(InfoClass.PhieuBaoHanhInfo pbh)
        {
            return pbhm.ThemPhieuBaoHanh(pbh);
        }

        public int CapNhatPhieuBaoHanh(InfoClass.PhieuBaoHanhInfo pbh)
        {
            return pbhm.CapNhatPhieuBaoHanh(pbh);
        }

    }
}
