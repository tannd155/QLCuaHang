using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Controllers
{
    class NhaCungCapController
    {
        Models.NhaCungCapModel nccm = new Models.NhaCungCapModel();
        public DataTable LayDSNhaCungCap()
        {
            return nccm.LayDSNCC();
        }
        public int ThemNhaCungCap(InfoClass.NhaCungCapInfo ncc)
        {
            return nccm.ThemNhaCungCap(ncc);
        }
        public int CapNhatNhaCungCap(InfoClass.NhaCungCapInfo ncc)
        {
            return nccm.CapNhatNhaCungCap(ncc);
        }
        public DataTable TimNhaCungCap(InfoClass.NhaCungCapInfo ncc)
        {
            return nccm.TimNCC(ncc);
        }
    }
}
