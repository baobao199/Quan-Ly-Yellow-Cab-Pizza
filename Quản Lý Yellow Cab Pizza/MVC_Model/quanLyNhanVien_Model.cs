using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class quanLyNhanVien_Model
    {
        public DataTable load_Data()
        {
            DataTable da;
            string sql = "select * from NhanVien";
            da = xuly.creatTable(sql);
            return da;
        }
        public Boolean xoa_NhanVien(string id)
        {
            bool re = false;
            string sql = "delete from NhanVien where MaNhanVien = '" + id + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_NhanVien(string maNhanVien, string tenNhanVien, int namSinh, string diaChi, string soDienThoai)
        {
            bool re = false;
            string sql = "insert into NhanVien values ('" + maNhanVien + "',N'" + tenNhanVien + "','"+namSinh+"',N'" + diaChi + "','" + soDienThoai + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean sua_NhanVien(string maNhanVien, string tenNhanVien, int namSinh, string diaChi, string soDienThoai)
        {
            bool re = false;
            string sql = "update NhanVien set TenNhanVien = N'" + tenNhanVien + "', NamSinh = '"+namSinh+"',DiaChi = N'" + diaChi + "', SoDienThoai = '" + soDienThoai + "' where MaNhanVien = '" + maNhanVien + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable timKiem_Load(string obj)
        {
            DataTable da;
            string sql = "SELECT * FROM NhaVien WHERE MaNhaVien LIKE '" + obj + "' or TenNhanVien = '" + obj + "'";
            da = xuly.creatTable(sql);
            return da;
        }
    }
}
