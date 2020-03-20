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
    }
}
