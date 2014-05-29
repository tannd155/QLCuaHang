using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Models
{
    class LoaiHangModel
    {
        public DataTable LayDSLH()
        {
            string query = @"SELECT * FROM LoaiHang";
            return MyDataLayer.CreateDataTable(query);
        }
        public int ThemLoaiHang(InfoClass.LoaiHangInfo lh)
        {
            try
            {
                string query = "INSERT INTO LoaiHang(MaLoaiHang,TenLoaiHang) VALUES('" + lh.Maloaihang + "','" + lh.Tenloaihang + "')";
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
        public int CapNhatLoaiHang(InfoClass.LoaiHangInfo lh)
        {
            try
            {
                string query = "UPDATE LoaiHang SET TenLoaiHang='" + lh.Tenloaihang + "' WHERE MaLoaiHang = '" + lh.Maloaihang + "'";
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
        public DataTable TimLH(InfoClass.LoaiHangInfo lh)
        {
            try
            {
                string query = "SELECT * FROM LoaiHang WHERE MaLoaiHang like '%" + lh.Maloaihang + "%' and TenLoaiHang like '%" + lh.Tenloaihang + "%'";
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
