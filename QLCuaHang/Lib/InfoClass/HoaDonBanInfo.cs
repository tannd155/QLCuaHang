using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    public class HoaDonBanInfo
    {
        private string mahdb;

        public string Mahdb
        {
            get { return mahdb; }
            set { mahdb = value; }
        }
        private KhachHangInfo kh;

        internal KhachHangInfo Kh
        {
            get { return kh; }
            set { kh = value; }
        }
        private DateTime ngayban;

        public DateTime Ngayban
        {
            get { return ngayban; }
            set { ngayban = value; }
        }

        public HoaDonBanInfo()
        {
            
        }
        public HoaDonBanInfo(string _mahdb, KhachHangInfo _kh, DateTime _ngayban)
        {
            this.mahdb = _mahdb;
            this.kh = _kh;
            this.ngayban = _ngayban;
        }
    }
}
