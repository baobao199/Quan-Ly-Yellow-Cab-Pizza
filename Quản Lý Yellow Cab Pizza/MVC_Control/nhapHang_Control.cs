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
        public Boolean them_NhapNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int giaTien, int SoLuong)
        {
            return nhapHangModel.them_NhapNguyenLieu(soHoaDon, maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, SoLuong, giaTien);
        }
        public Boolean them_HoaDon(string soHoaDon)
        {
            return nhapHangModel.them_HoaDon(soHoaDon);
        }
        public Boolean xoa_ChiTietNguyenLieu(string soHoaDon)
        {
            return nhapHangModel.xoa_ChiTietNguyenLieu(soHoaDon);
        }
        public Boolean them_BaoCaoNhapHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, DateTime ngayNhap, int SoLuong, int giaTien)
        {
            return nhapHangModel.them_BaoCaoNhapHang(soHoaDon, maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, ngayNhap, SoLuong, giaTien);
        }
        public Boolean sua_BaoCaoNhapHang(string maHoaDon, string maNguyenLieu, string tenNguyenLieu,string maLoaiNguyenLieu, string maNhaCungCap, int SoLuong, int giaTien)
        {
            return nhapHangModel.sua_BaoCaoNhapHang(maHoaDon, maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, SoLuong, giaTien);
        }
        public Boolean sua_ChiTietNhapHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int SoLuong, int giaTien)
        {
            return nhapHangModel.sua_ChiTietNhapHang(soHoaDon, maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, SoLuong, giaTien);
        }
        public Boolean xoa_ChiTietNhapHang(string soHoaDon, string maNguyenLieu)
        {
            return nhapHangModel.xoa_ChiTietNhapHang(soHoaDon, maNguyenLieu);
        }
        public Boolean xoa_BaoCaoNhapHang(string soHoaDon, string maNguyenLieu)
        {
            return nhapHangModel.xoa_BaoCaoNhapHang(soHoaDon, maNguyenLieu);
        }
        public Boolean capnhat_SoLuong(int soLuong, string maNguyenLieu, string soHoaDon)
        {
            return nhapHangModel.capnhat_SoLuong(soLuong, maNguyenLieu, soHoaDon);
        }
        public Boolean check_NguyenLieu(string maNguyenLieu)
        {
            return nhapHangModel.check_NguyenLieu(maNguyenLieu);
        }
        public Boolean them_QuanLyNguyenLieu(string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        {
            return nhapHangModel.them_QuanLyNguyenLieu(maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, soLuong, giaTien);
        }
    }
}
