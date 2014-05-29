using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    class MatHangInfo
    {
        private string mamh;

        public string Mamh
        {
            get { return mamh; }
            set { mamh = value; }
        }
        private string tenmh;

        public string Tenmh
        {
            get { return tenmh; }
            set { tenmh = value; }
        }
        private InfoClass.LoaiHangInfo lh;

        internal InfoClass.LoaiHangInfo Lh
        {
            get { return lh; }
            set { lh = value; }
        }
        private string donvitinh;

        public string Donvitinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }
        private string hangsx;

        public string Hangsx
        {
            get { return hangsx; }
            set { hangsx = value; }
        }
        public MatHangInfo()
        {
 
        }
        public MatHangInfo(string _mamh, string _tenmh, LoaiHangInfo _lh, string _donvitinh, string _hangsx )
        {
            this.mamh = _mamh;
            this.tenmh = _tenmh;
            this.lh = _lh;
            this.donvitinh = _donvitinh;
            this.hangsx = _hangsx;
        }
    }
}
