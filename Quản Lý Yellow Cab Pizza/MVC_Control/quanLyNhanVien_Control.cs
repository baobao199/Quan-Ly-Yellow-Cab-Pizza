using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class quanLyNhanVien_Control
    {
        quanLyNhanVien_Model nhanVienModel = new quanLyNhanVien_Model();
        public Boolean xoa_NhanVien(string id)
        {
            return nhanVienModel.xoa_NhanVien(id);
        }
        public Boolean them_NhanVien(string maNhanVien, string tenNhanVien, int namSinh, string diaChi, string soDienThoai)
        {
            return nhanVienModel.them_NhanVien( maNhanVien,  tenNhanVien,  namSinh,  diaChi,  soDienThoai);
        }
        public Boolean sua_NhanVien(string maNhanVien, string tenNhanVien, int namSinh, string diaChi, string soDienThoai)
        {
            return nhanVienModel.sua_NhanVien(maNhanVien, tenNhanVien, namSinh, diaChi, soDienThoai);
        }
    }
}
