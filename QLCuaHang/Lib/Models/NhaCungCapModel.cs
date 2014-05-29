using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Models
{
    class NhaCungCapModel
    {
        public DataTable LayDSNCC()
        {
            string query = @"SELECT * FROM NhaCungCap";
            return MyDataLayer.CreateDataTable(query);
        }
        public int ThemNhaCungCap(InfoClass.NhaCungCapInfo ncc)
        {
            try
            {
                string query = "INSERT INTO NhaCungCap(MaNCC,TenNCC) VALUES('" + ncc.MaNCC + "','" + ncc.TenNCC + "')";
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
        public int CapNhatNhaCungCap(InfoClass.NhaCungCapInfo ncc)
        {
            try
            {
                string query = "UPDATE NhaCungCap SET TenNCC='" + ncc.TenNCC + "' WHERE MaNCC = '" + ncc.MaNCC + "'";
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
        public DataTable TimNCC(InfoClass.NhaCungCapInfo ncc)
        {
            try
            {
                string query = "SELECT * FROM NhaCungCap WHERE MaNCC like '%" + ncc.MaNCC + "%' and TenNCC like '%" + ncc.TenNCC + "%'";
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
