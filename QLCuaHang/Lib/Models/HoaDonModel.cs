using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Models
{
    class HoaDonModel
    {
        public DataTable LayDSHDB()
        {
            string query = @"SELECT * FROM HoaDonBan";
            return MyDataLayer.CreateDataTable(query);
        }
        
        public DataTable LayDSCTHDB()
        {
            string query = @"SELECT * FROM CTHoaDonBan";
            return MyDataLayer.CreateDataTable(query);
        }

        public DataTable TimTheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            string query = @"SELECT * FROM HoaDonBan WHERE NgayBan between '" + Convert.ToDateTime(TuNgay).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(DenNgay).ToString("yyyy-MM-dd") + "'";
            return MyDataLayer.CreateDataTable(query);
        }
        public int ThemHoaDonBan(InfoClass.HoaDonBanInfo hdb)
        {
            try
            {
                string query = "INSERT INTO HoaDonBan(MaHDB,MaKH,NgayBan) VALUES('" + hdb.Mahdb + "','" + hdb.Kh.MaKH + "','" + Convert.ToDateTime(hdb.Ngayban).ToString("yyyy-MM-dd") + "')";
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
        public int CapNhatHoaDonBan(InfoClass.HoaDonBanInfo hdb)
        {
            try
            {
                string query = "UPDATE HoaDonBan SET MaKH = '" + hdb.Kh.MaKH + "', NgayBan ='" + Convert.ToDateTime(hdb.Ngayban).ToString("yyyy-MM-dd") + "' WHERE MaHDB = '" + hdb.Mahdb + "'";
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
        public int ThemCTHoaDonBan(InfoClass.CTHoaDonBanInfo cthdb)
        {
            try
            {
                string query = "INSERT INTO CTHoaDonBan(MaHDB,MaMH,SoLuong,DonGia) VALUES('" + cthdb.Hdb.Mahdb + "','" + cthdb.Mh.Mamh + "','" + cthdb.Soluong + "','" + cthdb.Dongia + "')";
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
        public int CapNhatCTHoaDonBan(InfoClass.CTHoaDonBanInfo cthdb)
        {
            try
            {
                string query = "UPDATE CTHoaDonBan SET MaMH = '" + cthdb.Mh.Mamh + "', SoLuong ='" + +cthdb.Soluong + "',  DonGia ='" + cthdb.Dongia + "' WHERE MaHDB = '" + cthdb.Hdb.Mahdb + "'";
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
