using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    class PhieuBaoHanhInfo
    {
        private string sophieu;

        public string Sophieu
        {
            get { return sophieu; }
            set { sophieu = value; }
        }
        private InfoClass.KhachHangInfo khachhang;

        internal InfoClass.KhachHangInfo Khachhang
        {
            get { return khachhang; }
            set { khachhang = value; }
        }
        private InfoClass.MatHangInfo mathang;

        public InfoClass.MatHangInfo Mathang
        {
            get { return mathang; }
            set { mathang = value; }
        }
        private DateTime ngaybatdau;

        public DateTime Ngaybatdau
        {
            get { return ngaybatdau; }
            set { ngaybatdau = value; }
        }
        private DateTime ngayketthuc;

        public DateTime Ngayketthuc
        {
            get { return ngayketthuc; }
            set { ngayketthuc = value; }
        }


    }
}
