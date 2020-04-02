using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class taiKhoan_Model
    {
        public DataTable taiKhoan(string taiKhoan)
            //load tai khoan
        {
            DataTable dt;
            string sql = "SELECT * FROM TaiKhoanQuanLy WHERE TaiKhoan ='" + taiKhoan + "'";
            dt = xuly.creatTable(sql);
            return dt;
        }
        public Boolean capNhat_MatKhau(string taiKhoan, string matKhau)
            //cap nhat mat khau
        {
            bool re =false;
            string sql = "update TaiKhoanQuanLy set MatKhau = '" + matKhau + "' where TaiKhoan = '" + taiKhoan + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
