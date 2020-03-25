using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class nguyenLieu_Control
    {
        nguyenLieu_Model nguyenLieuModel = new nguyenLieu_Model();
        public Boolean xoa_NguyenLieu(string id)
        {
            return nguyenLieuModel.xoa_NguyenLieu(id);
        }
        public Boolean them_NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string loaiNguyenLieu, string nhaCungCap, int giaTien)
        {
            return nguyenLieuModel.them_NguyenLieu( maNguyenLieu,  tenNguyenLieu,  loaiNguyenLieu,  nhaCungCap,  giaTien);
        }
        public Boolean sua_NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string loaiNguyenLieu, string nhaCungCap, int giaTien)
        {
            return nguyenLieuModel.sua_NguyenLieu(maNguyenLieu, tenNguyenLieu, loaiNguyenLieu, nhaCungCap, giaTien);
        }
    }
}
