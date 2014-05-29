using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    class CTHoaDonBanInfo
    {
        private InfoClass.HoaDonBanInfo hdb;

        public InfoClass.HoaDonBanInfo Hdb
        {
            get { return hdb; }
            set { hdb = value; }
        }
        private InfoClass.MatHangInfo mh;

        internal InfoClass.MatHangInfo Mh
        {
            get { return mh; }
            set { mh = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private float dongia;

        public float Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public CTHoaDonBanInfo()
        {
 
        }

        public CTHoaDonBanInfo(HoaDonBanInfo _hdb, MatHangInfo _mh, int _soluong, float _dongia )
        {
            this.hdb = _hdb;
            this.mh = _mh;
            this.soluong = _soluong;
            this.dongia = _dongia;
        }
    }
}
