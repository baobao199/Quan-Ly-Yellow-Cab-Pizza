using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class nguyenLieu_Model
    {
        public DataTable load_Data()
        //load dữ liệu lên datagridview
        {
            DataTable da;
            string sql = "select * from NguyenLieu";
            da = xuly.creatTable(sql);
            return da;
        }
        public Boolean xoa_NguyenLieu(string id)
        //xoa nguyen lieu
        {
            bool re = false;
            string sql = "delete from NguyenLieu where MaNguyenLieu = '" + id + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string loaiNguyenLieu, string nhaCungCap, int giaTien)
            //them nguyen lieu
        {
            bool re = false;
            string sql = "insert into NguyenLieu values ('" + maNguyenLieu + "',N'" + tenNguyenLieu + "','" + loaiNguyenLieu + "','" + nhaCungCap + "','" + giaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean sua_NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string loaiNguyenLieu, string nhaCungCap, int giaTien)
            //sua nguyen lieu
        {
            bool re = false;
            string sql = "update NguyenLieu set TenNguyenLieu = N'" + tenNguyenLieu + "', MaLoaiNguyenLieu = '" + loaiNguyenLieu + "', MaNhaCungCap = '" + nhaCungCap + "', GiaTien = '" + giaTien + "' where MaNguyenLieu = '" + maNguyenLieu + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable timKiem_Load(string obj)
            //tim kiem nguyen lieu
        {
            DataTable da;
            string sql = "SELECT * FROM NguyenLieu WHERE MaNguyenLieu LIKE '" + obj + "' or TenNguyenLieu = '" + obj + "'";
            da = xuly.creatTable(sql);
            return da;
        }
    }
}

