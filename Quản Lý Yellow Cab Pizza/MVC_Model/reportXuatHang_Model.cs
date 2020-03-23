using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class reportXuatHang_Model
    {
        public DataTable load_ReportXuatHang(string ngayBatDau, string ngayKetThuc)
        {
            DataTable da;
            string sql = "select SoHoaDon,MaNguyenLieu,TenNguyenLieu,MaLoaiNguyenLieu,MaNhaCungCap,NgayXuat,SoLuong,GiaTien, SoLuong*GiaTien as ThanhTien from BaoCaoXuatHang where NgayXuat between  '" + ngayBatDau + "' and '" + ngayKetThuc + "'";
            da = xuly.creatTable(sql);
            return da;
        }
    }
}
