using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Models
{
    class MatHangModel
    {
        public DataTable LayDSMH()
        {
            string query = @"SELECT * FROM MatHang";
            return MyDataLayer.CreateDataTable(query);
        }
        public int ThemMatHang(InfoClass.MatHangInfo mh)
        {
            try
            {
                string query = "INSERT INTO MatHang(MaMH,TenMH,MaLoaiHang,DonViTinh,HangSX) VALUES('" + mh.Mamh + "','" + mh.Tenmh + "','" + mh.Lh.Maloaihang + "','" + mh.Donvitinh + "','" + mh.Hangsx + "')";
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

        public int CapNhatMatHang(InfoClass.MatHangInfo mh)
        {
            try
            {
                string query = "UPDATE MatHang SET TenMH='" + mh.Tenmh + "', MaLoaiHang = '" + mh.Lh.Maloaihang + "', DonViTinh = '" + mh.Donvitinh + "', HangSX = '" + mh.Hangsx + "' WHERE MaMH = '" + mh.Mamh + "'";
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
        public DataTable TimMH(InfoClass.MatHangInfo mh)
        {
            try
            {
                string query = "SELECT * FROM MatHang WHERE MaMH='" + mh.Mamh + "' or TenMH like '%" + mh.Tenmh + "%' and DonViTinh like '%" + mh.Donvitinh + "%' and HangSX like '%" + mh.Hangsx + "%' or MaLoaiHang ='" + mh.Lh.Maloaihang + "'";
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
