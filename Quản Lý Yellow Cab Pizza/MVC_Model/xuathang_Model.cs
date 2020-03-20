using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class xuatHang_Model
    {
        public DataTable load_XuatHang()
        // load dữ liệu lên phần mềm
        {
            DataTable da;
            string sql = "select * from XuatHang ORDER BY SoHoaDon  DESC";
            da = xuly.creatTable(sql);
            return da;
        }
        public DataTable load_ChiTietXuatHang()
        // load dữ liệu lên datagridview
        {
            DataTable da;
            string sql = "select * from ChiTietXuatHang";
            da = xuly.creatTable(sql);
            return da;
        }
        public Boolean them_HoaDon(string soHoaDon)
        // thêm hóa đơn
        {
            bool re = false;
            string sql = "insert into XuatHang(SoHoaDon) values ('" + soHoaDon + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
