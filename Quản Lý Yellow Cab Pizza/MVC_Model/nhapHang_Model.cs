using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class nhapHang_Model
    {
        public DataTable load_Data()
        {
            DataTable da;
            string sql = "select * from NhapHang";
            da = xuly.creatTable(sql);
            return da;
        }
        public Boolean check_HoaDon(string obj)
        {
            bool re = false;
            string sql = "select count(SoHoaDon) from NhapHang where SoHoaDon = '" + obj + "'";
            if (xuly.executeScalar(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_NhapNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, string loaiNguyenLieu, int giaTien, int SoLuong)
        {
            bool re = false;
            string sql = "insert into NhapHang(SoHoaDon,MaNguyenLieu,TenNguyenLieu,LoaiNguyenLieu,MaNhaCungCap,GiaTien,SoLuong) values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','" + loaiNguyenLieu + "','" + maNhaCungCap + "','" + giaTien + "','" + SoLuong + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
