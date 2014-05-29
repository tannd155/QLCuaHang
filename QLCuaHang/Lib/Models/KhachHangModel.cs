using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Models
{
    class KhachHangModel
    {
        public DataTable LayDSKH()
        {
            string query = @"SELECT * FROM KhachHang";
            return MyDataLayer.CreateDataTable(query);
        }
        public int ThemKhachHang(InfoClass.KhachHangInfo kh)
        {
            try
            {
                string query = "INSERT INTO KhachHang(MaKH,TenKH,DiaChi,DienThoai) VALUES('" + kh.MaKH + "','" + kh.TenKH + "','" + kh.DiaChi + "','" + kh.SoDienThoai + "')";
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
        public int CapNhatKhachHang(InfoClass.KhachHangInfo kh)
        {
            try
            {
                string query = "UPDATE KhachHang SET TenKH='" + kh.TenKH + "', DiaChi = '" + kh.DiaChi + "', DienThoai = '" + kh.SoDienThoai + "' WHERE MaKH = '" + kh.MaKH + "'";
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
        public DataTable TimKH(InfoClass.KhachHangInfo kh)
        {
            try
            {
                string query = "SELECT * FROM KhachHang WHERE MaKH='" + kh.MaKH + "' or TenKH like '%" + kh.TenKH + "%' and DiaChi like '%"+ kh.DiaChi + "%' or DienThoai ='" + kh.SoDienThoai + "'";
                return MyDataLayer.CreateDataTable(query);
            }
            catch
            {
                return null;
            }
            finally
            {
                MyDataLayer.CloseConnection();
            }
        }
    }
}
