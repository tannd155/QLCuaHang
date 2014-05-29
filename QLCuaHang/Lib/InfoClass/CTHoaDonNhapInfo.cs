using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    class CTHoaDonNhapInfo
    {
        private InfoClass.HoaDonNhapInfo hdn;

        public InfoClass.HoaDonNhapInfo Hdn
        {
            get { return hdn; }
            set { hdn = value; }
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

        public CTHoaDonNhapInfo()
        {
 
        }

        public CTHoaDonNhapInfo(HoaDonNhapInfo _hdn, MatHangInfo _mh, int _soluong, float _dongia )
        {
            this.hdn = _hdn;
            this.mh = _mh;
            this.soluong = _soluong;
            this.dongia = _dongia;
        }
    }
}
