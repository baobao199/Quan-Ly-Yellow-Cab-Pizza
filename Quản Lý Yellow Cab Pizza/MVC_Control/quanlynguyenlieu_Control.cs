using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class quanlynguyenlieu_Control
    {
        quanlynguyenlieu_Model nguyenLieuModel = new quanlynguyenlieu_Model();

        //public Boolean xoa_NguyenLieu(string id)
        //{
        //    return nguyenLieuModel.xoa_NguyenLieu(id);
        //}
        //public Boolean capnhat_NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong,int giaTien)
        //{
        //    return nguyenLieuModel.capNhat_NguyenLieu(maNguyenLieu, tenNguyenLieu, maLoaiNguyenLieu,maNhaCungCap,soLuong,giaTien);
        //}
        //public Boolean capNhat_BaoCaoNhapHang(string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        //{
        //    return nguyenLieuModel.capNhat_BaoCaoNhapHang( maNguyenLieu,  tenNguyenLieu,  maLoaiNguyenLieu,  maNhaCungCap,  soLuong,  giaTien);
        //}
        public Boolean capNhat_SoLuong(string maNguyenLieu, int soLuong)
        {
            return nguyenLieuModel.capNhat_SoLuong(maNguyenLieu,soLuong);
        }
        //public Boolean xoa_BaoCaoNhapHang(string id)
        //{
        //    return nguyenLieuModel.xoa_BaoCaoNhapHang(id);
        //}
    }
}
