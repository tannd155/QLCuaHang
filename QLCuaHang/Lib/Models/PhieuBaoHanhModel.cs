using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang.Lib.Models
{
    class PhieuBaoHanhModel
    {
        public DataTable LayDSPBH()
        {
            string query = @"SELECT * FROM PhieuBaoHanh";
            return MyDataLayer.CreateDataTable(query);
        }
        public int ThemPhieuBaoHanh(InfoClass.PhieuBaoHanhInfo pbh)
        {
            try
            {
                string query = "INSERT INTO PhieuBaoHanh(SoPhieu,MaKH,MaMH,NgayBatDau,NgayKetThuc) VALUES('" + pbh.Sophieu + "','" + pbh.Khachhang.MaKH + "','" + pbh.Mathang.Mamh + "','" + Convert.ToDateTime(pbh.Ngaybatdau).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(pbh.Ngayketthuc).ToString("yyyy-MM-dd") + "')";
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
        public int CapNhatPhieuBaoHanh(InfoClass.PhieuBaoHanhInfo pbh)
        {
            try
            {
                string query = "UPDATE PhieuBaoHanh SET NgayBatDau = '" + Convert.ToDateTime(pbh.Ngaybatdau).ToString("yyyy-MM-dd") + "', NgayKetThuc = '" + Convert.ToDateTime(pbh.Ngayketthuc).ToString("yyyy-MM-dd") + "' WHERE SoPhieu = '" + pbh.Sophieu + "'";
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
