using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class nhapHang_Control
    {
        nhapHang_Model nhapHangModel = new nhapHang_Model();
        public Boolean check_SoHoaDon(string obj)
        {
            return nhapHangModel.check_HoaDon(obj);
        }
        public Boolean them_NhapNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, string loaiNguyenLieu,  int giaTien, int SoLuong)
        {
            return nhapHangModel.them_NhapNguyenLieu(soHoaDon,maNguyenLieu,tenNguyenLieu, loaiNguyenLieu, maNhaCungCap,  giaTien, SoLuong);
        }
    }
}
