using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Models
{
    class HoaDonNhapModel
    {
        public DataTable LayDSHDN()
        {
            string query = @"SELECT * FROM HoaDonNhap";
            return MyDataLayer.CreateDataTable(query);
        }
        public DataTable LayDSCTHDN()
        {
            string query = @"SELECT * FROM CTHoaDonNhap";
            return MyDataLayer.CreateDataTable(query);
        }
        public int ThemHoaDonNhap(InfoClass.HoaDonNhapInfo hdn)
        {
            try
            {
                string query = "INSERT INTO HoaDonNhap(MaHDN,MaNCC,NgayNhap) VALUES('" + hdn.Mahdn + "','" + hdn.Ncc.MaNCC + "','" + Convert.ToDateTime(hdn.Ngaynhap).ToString("yyyy-MM-dd") + "')";
                int kq = MyDataLayer.ExecuteNonQuery(query);
                return kq;
            }
            catch
            {
                return -1;
            }
            finally
            {
                MyDataLayer.CloseConnection();
            }
        }
        public int CapNhatHoaDonNhap(InfoClass.HoaDonNhapInfo hdn)
        {
            try
            {
                string query = "UPDATE HoaDonNhap SET MaNCC = '" + hdn.Ncc.MaNCC + "', NgayNhap ='" + Convert.ToDateTime(hdn.Ngaynhap).ToString("yyyy-MM-dd") + "' WHERE MaHDN = '" + hdn.Mahdn + "'";
                int kq = MyDataLayer.ExecuteNonQuery(query);
                return kq;
            }
            catch
            {
                return -1;
            }
            finally
            {
                MyDataLayer.CloseConnection();
            }
        }
        public int ThemCTHoaDonNhap(InfoClass.CTHoaDonNhapInfo cthdn)
        {
            try
            {
                string query = "INSERT INTO CTHoaDonNhap(MaHDN,MaMH,SoLuong,DonGia) VALUES('" + cthdn.Hdn.Mahdn + "','" + cthdn.Mh.Mamh + "','" + cthdn.Soluong + "','" + cthdn.Dongia + "')";
                int kq = MyDataLayer.ExecuteNonQuery(query);
                return kq;
            }
            catch
            {
                return -1;
            }
            finally
            {
                MyDataLayer.CloseConnection();
            }
        }
        public int CapNhatCTHoaDonNhap(InfoClass.CTHoaDonNhapInfo cthdn)
        {
            try
            {
                string query = "UPDATE CTHoaDonBan SET MaMH = '" + cthdn.Mh.Mamh + "', SoLuong ='" + +cthdn.Soluong + "',  DonGia ='" + cthdn.Dongia + "' WHERE MaHDN = '" + cthdn.Hdn.Mahdn + "'";
                int kq = MyDataLayer.ExecuteNonQuery(query);
                return kq;
            }
            catch
            {
                return -1;
            }
            finally
            {
                MyDataLayer.CloseConnection();
            }
        }
    }
}
