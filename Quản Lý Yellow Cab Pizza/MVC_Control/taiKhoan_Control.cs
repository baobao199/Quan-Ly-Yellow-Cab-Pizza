using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class taiKhoan_Control
    {
        taiKhoan_Model taiKhoanModel = new taiKhoan_Model();
        public Boolean capNhat_MatKhau(string taiKhoan, string matKhau)
        {
            return taiKhoanModel.capNhat_MatKhau(taiKhoan, matKhau);
        }
    }
}
