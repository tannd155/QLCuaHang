using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    class LoaiHangInfo
    {
        private string maloaihang;

        public string Maloaihang
        {
            get { return maloaihang; }
            set { maloaihang = value; }
        }
        private string tenloaihang;

        public string Tenloaihang
        {
            get { return tenloaihang; }
            set { tenloaihang = value; }
        }
        public LoaiHangInfo()
        {
 
        }
        public LoaiHangInfo(string _maloaihang,string _tenloaihang)
        {
            this.maloaihang = _maloaihang;
            this.tenloaihang = _tenloaihang;
        }
    }
}
