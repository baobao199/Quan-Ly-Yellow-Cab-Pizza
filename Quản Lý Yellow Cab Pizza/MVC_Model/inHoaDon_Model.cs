using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class inHoaDon_Model
    {
        public DataTable load_ChiTietNhapHang()
            //load chi tiết hóa đơn nhập lên phần mềm
        {
            DataTable da;
            string sql = "select * from ChiTietNhapHang";
            da = xuly.creatTable(sql);
            return da;
        }
        public DataTable load_ChiTietXuatHang()
        //load chi tiết hóa đơn xuất lên phần mềm
        {
            DataTable da;
            string sql = "select * from ChiTietXuatHang";
            da = xuly.creatTable(sql);
            return da;
        }
        public Boolean xoa_ChiTietNguyenLieu(string soHoaDon)
        // xóa hóa đơn để tạo hóa đơn mới
        {
            bool re = false;
            string sql = "delete ChiTietNhapHang where SoHoaDon = '" + soHoaDon + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean xoa_ChiTietXuatHang(string soHoaDon)
        // xóa hóa đơn để tạo hóa đơn mới
        {
            bool re = false;
            string sql = "delete ChiTietXuatHang where SoHoaDon = '" + soHoaDon + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

    }
}
