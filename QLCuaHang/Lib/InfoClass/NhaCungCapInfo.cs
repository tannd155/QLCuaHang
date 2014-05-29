using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    public class NhaCungCapInfo
    {
        private string mancc;

        public string MaNCC
        {
            get { return mancc; }
            set { mancc = value; }
        }
        private string tenncc;

        public string TenNCC
        {
            get { return tenncc; }
            set { tenncc = value; }
        }
        public NhaCungCapInfo()
        {
 
        }
        public NhaCungCapInfo(string _mancc, string _tenncc)
        {
            this.mancc = _mancc;
            this.tenncc = _tenncc;
        }
    }
}
