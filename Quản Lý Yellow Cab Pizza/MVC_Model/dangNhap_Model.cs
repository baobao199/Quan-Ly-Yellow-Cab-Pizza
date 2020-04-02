using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class dangNhap_Model
    {
        public DataTable check_TaiKhoan(string taiKhoan, string matKhau)
            //load tài khoản lên database
        {
            DataTable dt;
            string sql = "SELECT * FROM TaiKhoanQuanLy WHERE TaiKhoan ='" + taiKhoan + "'";
            dt = xuly.creatTable(sql);
            return dt;
        }
    }
}
