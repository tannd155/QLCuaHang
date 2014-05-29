using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCuaHang.Lib.InfoClass
{
    public class KhachHangInfo
    {
        private string makh;
        public string MaKH
        {
            get { return this.makh; }
            set
            {
                this.makh = value;
            }
        }
        private string tenkh;
        public string TenKH
        {
            get { return this.tenkh; }
            set {
                this.tenkh = value;
            }
        }
        private string diachi;
        public string DiaChi
        {
            get { return this.diachi; }
            set { this.diachi = value; }
        }

        private string sdt;
        public string SoDienThoai
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }
        public KhachHangInfo()
        {
 
        }
        public KhachHangInfo(string _makh, string _tenkh, string _diachi, string _sdt)
        {
            this.makh = _makh;
            this.tenkh = _tenkh;
            this.diachi = _diachi;
            this.sdt = _sdt;
        }
    }
}
