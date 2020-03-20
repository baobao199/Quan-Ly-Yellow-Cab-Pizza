using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class xuatHang_Control
    {
        xuatHang_Model xuatHangModel = new xuatHang_Model();
        public Boolean them_HoaDon(string soHoaDon)
        {
            return xuatHangModel.them_HoaDon(soHoaDon);
        }
        public Boolean them_XuatNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int giaTien, int SoLuong)
        {
            return xuatHangModel.them_XuatNguyenLieu(soHoaDon, maNguyenLieu, tenNguyenLieu, maNhaCungCap, giaTien, SoLuong);
        }

        public Boolean xoa_ChiTietXuatHang(string soHoaDon)
        {
            return xuatHangModel.xoa_ChiTietXuatHang(soHoaDon);
        }
        public Boolean them_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, DateTime ngayNhap, int soLuong, int giaTien)
        {
            return xuatHangModel.them_BaoCaoXuatHang(soHoaDon, maNguyenLieu, tenNguyenLieu, maNhaCungCap, ngayNhap, soLuong, giaTien);
        }
        public Boolean sua_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        {
            return xuatHangModel.sua_BaoCaoXuatHang( soHoaDon,  maNguyenLieu,  tenNguyenLieu,  maNhaCungCap,  soLuong,  giaTien);
        }
        public Boolean sua_ChiTietXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        {
            return xuatHangModel.sua_ChiTietXuatHang(soHoaDon, maNguyenLieu, tenNguyenLieu, maNhaCungCap, soLuong, giaTien);
        }
        public Boolean xoa_ChiTietXuatHang(string soHoaDon, string maNguyenLieu)
        {
            return xuatHangModel.xoa_ChiTietXuatHang(soHoaDon,maNguyenLieu);
        }
        public Boolean xoa_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu)
        {
            return xuatHangModel.xoa_BaoCaoXuatHang(soHoaDon, maNguyenLieu);
        }
        public Boolean capnhat_SoLuong(int soLuong, string maNguyenLieu, string soHoaDon)
        {
            return xuatHangModel.capnhat_SoLuong(soLuong, maNguyenLieu, soHoaDon);
        }
        public Boolean check_NguyenLieu(string maNguyenLieu)
        {
            return xuatHangModel.check_NguyenLieu(maNguyenLieu);
        }

    }
}
