using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class inHoaDon_Control
    {
        inHoaDon_Model inHoaDonModel = new inHoaDon_Model();
        public Boolean xoa_ChiTietNguyenLieu(string soHoaDon)
        {
            return inHoaDonModel.xoa_ChiTietNguyenLieu(soHoaDon);
        }
    }
}
