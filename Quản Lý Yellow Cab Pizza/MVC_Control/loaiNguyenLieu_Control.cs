using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class loaiNguyenLieu_Control
    {
        loaiNguyenLieu_Model loaiNguyenLieuModel = new loaiNguyenLieu_Model();
        public Boolean xoa_LoaiNguyenLieu(string id)
        {
            return loaiNguyenLieuModel.xoa_LoaiNguyenLieu(id);
        }
        public Boolean them_LoaiNguyenLieu(string maLoaiNguyenLieu, string tenLoaiNguyenLieu)
        {
            return loaiNguyenLieuModel.them_LoaiNguyenLieu(maLoaiNguyenLieu, tenLoaiNguyenLieu);
        }
        public Boolean sua_LoaiNguyenLieu(string maLoaiNguyenLieu, string tenLoaiNguyenLieu)
        {
            return loaiNguyenLieuModel.sua_LoaiNguyenLieu(maLoaiNguyenLieu, tenLoaiNguyenLieu);
        }
    }
}
