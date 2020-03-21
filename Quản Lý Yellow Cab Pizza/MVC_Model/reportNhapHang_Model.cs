using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class reportNhapHang_Model
    {
        public DataTable load_ReportNhapHang(string ngayBatDau , string ngayKetThuc)
        {
            DataTable da;
            string sql = "select * from BaoCaoNhapHang  where NgayNhap between  '"+ ngayBatDau + "' and '"+ ngayKetThuc + "'";
            da = xuly.creatTable(sql);
            return da;
        }
        public Boolean ThanhTien()
        {
            bool re = false;
            string sql = "update BaoCaoNhapHang set ThanhTien =  SoLuong * GiaTien FROM BaoCaoNhapHang;";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
