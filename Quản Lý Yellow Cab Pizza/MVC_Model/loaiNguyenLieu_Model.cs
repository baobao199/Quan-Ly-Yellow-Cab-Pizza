using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class loaiNguyenLieu_Model
    {
        public DataTable load_Data()
        {
            DataTable re;
            string sql = "select * from LoaiNguyenLieu";
            re = xuly.creatTable(sql);
            return re;
        }
        public Boolean xoa_LoaiNguyenLieu(string id)
        {
            bool re = false;
            string sql = "delete from LoaiNguyenLieu where MaLoaiNguyenLieu='" + id + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true; 
            }
            return re;
        }
        public Boolean them_LoaiNguyenLieu(string maLoaiNguyenLieu, string tenLoaiNguyenLieu)
        {
            bool re = false;
            string sql = "insert into LoaiNguyenLieu values ('"+maLoaiNguyenLieu+"','"+tenLoaiNguyenLieu+"')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean sua_LoaiNguyenLieu(string maLoaiNguyenLieu, string tenLoaiNguyenLieu)
        {
            bool re = false;
            string sql = "update LoaiNguyenLieu set MaLoaiNguyenLieu = '"+maLoaiNguyenLieu+"', TenLoaiNguyenLieu = '"+tenLoaiNguyenLieu+"' where MaLoaiNguyenLieu = '"+maLoaiNguyenLieu+"' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
