using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class nhaCungCap_Model
    {
        //load dữ liệu lên datagridview
        public DataTable load_Data()
        {
            DataTable da;
            string sql = "select * from NhaCungCap";
            da = xuly.creatTable(sql);
            return da;
        }
        //xoa nhà cung cấp
        public Boolean xoa_NhaCungCap(string id)
        {
            bool re = false;
            string sql = "delete from NhaCungCap where MaNhaCungCap = '"+id+"'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        //thêm nhà cung cấp
        public Boolean them_NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string eMail, string soDienThoai)
        {
            bool re = false;
            string sql = "insert into NhaCungCap values ('" + maNhaCungCap + "',N'" + tenNhaCungCap + "',N'"+diaChi+"','"+eMail+"','"+soDienThoai+"')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        //sửa nhà cung cấp
        public Boolean sua_NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string eMail, string soDienThoai)
        {
            bool re = false;
            string sql = "update NhaCungCap set TenNhaCungCap = N'" + tenNhaCungCap + "', DiaChi = N'"+ diaChi + "', Email = '"+ eMail + "', SoDienThoai = '"+ soDienThoai + "' where MaNhaCungCap = '" + maNhaCungCap + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        //tìm kiếm
        public DataTable timKiem_Load(string obj)
        {
            DataTable da;
            string sql = "SELECT * FROM NhaCungCap WHERE MaNhaCungCap LIKE '" + obj + "' or TenNhaCungCap = '" + obj + "'";
            da = xuly.creatTable(sql);
            return da;
        }
    }
}
