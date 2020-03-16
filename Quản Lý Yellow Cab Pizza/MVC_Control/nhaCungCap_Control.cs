using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Control
{
    class nhaCungCap_Control
    {
        nhaCungCap_Model nhaCungCapModel = new nhaCungCap_Model();
        public Boolean xoa_NhaCungCap(string id)
        {
            return nhaCungCapModel.xoa_NhaCungCap(id);
        }
        public Boolean them_NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string eMail, string soDienThoai)
        {
            return nhaCungCapModel.them_NhaCungCap(maNhaCungCap,tenNhaCungCap,diaChi,eMail,soDienThoai);
        }
        public Boolean sua_NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string eMail, string soDienThoai)
        {
            return nhaCungCapModel.sua_NhaCungCap(maNhaCungCap, tenNhaCungCap, diaChi, eMail, soDienThoai);
        }
    }
}
