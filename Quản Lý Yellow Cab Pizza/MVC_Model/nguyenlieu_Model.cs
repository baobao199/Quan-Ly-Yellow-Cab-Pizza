using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class nguyenlieu_Model
    {
        public DataTable load_Data()
        {
            DataTable re;
            string sql = "select * from NguyenLieu";
            re = xuly.creatTable(sql);
            return re;
   
        }
        public Boolean xoa_NguyenLieu(string id)
        {
            bool re=false;
            string sql = "delete  from NguyenLieu where MaNguyenLieu='"+id+"'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean capNhat_NguyenLieu(String nguyenLieu, string maDanhMuc, string nhaCungCap, int soLuong, int giaTien)
        {
            bool re = false;
            string sql = "update NguyenLieu set TenNguyenLieu ='"+nguyenLieu+"', MaDanhMuc = '"+maDanhMuc+"', NhaCungCap ='"+nhaCungCap+"', SoLuong='"+soLuong+"', GiaTien = '"+giaTien+"' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable timKiem_Load(string obj)
        {
            DataTable da;
            string sql = "SELECT * FROM NguyenLieu WHERE MaNguyenLieu LIKE '"+obj+"' or TenNguyenLieu = '"+obj+"'";
            da = xuly.creatTable(sql);
            return da;
        }
    }
}
