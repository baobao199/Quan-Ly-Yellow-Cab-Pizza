using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    
    class reportNhapHang_Control
    {
        reportNhapHang_Model reportNhapHangModel = new reportNhapHang_Model();
        public Boolean ThanhTien()
        {
            return reportNhapHangModel.ThanhTien();
        }
    }
}
