using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    public class HoaDonNhapInfo
    {
        private string mahdn;

        public string Mahdn
        {
            get { return mahdn; }
            set { mahdn = value; }
        }
        private NhaCungCapInfo ncc;

        internal NhaCungCapInfo Ncc
        {
            get { return ncc; }
            set { ncc = value; }
        }
        private DateTime ngaynhap;

        public DateTime Ngaynhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }

        public HoaDonNhapInfo()
        {
            
        }
        public HoaDonNhapInfo(string _mahdn, NhaCungCapInfo _ncc, DateTime _ngaynhap)
        {
            this.mahdn = _mahdn;
            this.ncc = _ncc;
            this.ngaynhap = _ngaynhap;
        }
    }
}
