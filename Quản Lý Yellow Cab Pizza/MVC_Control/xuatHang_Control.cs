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
        public Boolean them_ChiTietXuatNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int giaTien, int SoLuong)
        {
            return xuatHangModel.them_ChiTietXuatNguyenLieu(soHoaDon, maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, SoLuong, giaTien);
        }
        public Boolean them_HoaDon(string soHoaDon)
        {
            return xuatHangModel.them_HoaDon(soHoaDon);
        }
        public Boolean xoa_ChiTietXuatNguyenLieu(string soHoaDon)
        {
            return xuatHangModel.xoa_ChiTietXuatNguyenLieu(soHoaDon);
        }
        public Boolean them_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, DateTime ngayxuat, int SoLuong, int giaTien)
        {
            return xuatHangModel.them_BaoCaoXuatHang(soHoaDon, maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, ngayxuat, SoLuong, giaTien);
        }
        public Boolean sua_BaoCaoXuatHang(string maHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int SoLuong, int giaTien)
        {
            return xuatHangModel.sua_BaoCaoXuatHang(maHoaDon, maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, SoLuong, giaTien);
        }
        public Boolean sua_ChiTietXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int SoLuong, int giaTien)
        {
            return xuatHangModel.sua_ChiTietXuatHang(soHoaDon, maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, SoLuong, giaTien);
        }
        public Boolean xoa_ChiTietXuatHang(string soHoaDon, string maNguyenLieu)
        {
            return xuatHangModel.xoa_ChiTietXuatHang(soHoaDon, maNguyenLieu);
        }
        public Boolean xoa_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu)
        {
            return xuatHangModel.xoa_BaoCaoXuatHang(soHoaDon, maNguyenLieu);
        }
        public Boolean capnhat_SoLuong(int soLuong, string maNguyenLieu)
        {
            return xuatHangModel.capnhat_SoLuong(soLuong, maNguyenLieu);
        }
        public Boolean capnhat_SoLuongSuaBot(int soLuong, string maNguyenLieu)
        {
            return xuatHangModel.capnhat_SoLuongSuaBot(soLuong, maNguyenLieu);
        }
        public Boolean capnhat_SoLuongSuaThem(int soLuong, string maNguyenLieu)
        {
            return xuatHangModel.capnhat_SoLuongSuaThem(soLuong, maNguyenLieu);
        }
        public Boolean check_NguyenLieu(string maNguyenLieu)
        {
            return xuatHangModel.check_NguyenLieu(maNguyenLieu);
        }
        //public Boolean them_QuanLyNguyenLieu(string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        //{
        //    return xuatHangModel.them_QuanLyNguyenLieu(maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu, maNhaCungCap, soLuong, giaTien);
        //}
        public Boolean xoa_XuatHang(string soHoaDon)
        {
            return xuatHangModel.xoa_XuatHang(soHoaDon);
        } 

    }
}
