using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class nguyenlieu_Control
    {
        nguyenlieu_Model nguyenLieuModel = new nguyenlieu_Model();

        public Boolean xoa_NguyenLieu(string id)
        {
            return nguyenLieuModel.xoa_NguyenLieu(id);
        }
        public Boolean capNhat_NguyenLieu(String nguyenLieu, string maDanhMuc, string nhaCungCap, int soLuong, int giaTien)
        {
            return nguyenLieuModel.capNhat_NguyenLieu(nguyenLieu, maDanhMuc,nhaCungCap,soLuong,giaTien);
        }
    }
}
