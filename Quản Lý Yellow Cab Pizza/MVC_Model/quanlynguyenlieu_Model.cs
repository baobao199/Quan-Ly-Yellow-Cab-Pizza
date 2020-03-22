using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class quanlynguyenlieu_Model
    {
        public DataTable load_Data()
        {
            DataTable re;
            string sql = "select * from QuanLyNguyenLieu";
            re = xuly.creatTable(sql);
            return re;
   
        }
        public Boolean xoa_NguyenLieu(string id)
        {
            bool re=false;
            string sql = "delete  from QuanLyNguyenLieu where MaNguyenLieu='" + id+"'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean xoa_BaoCaoNhapHang(string id)
        {
            bool re = false;
            string sql = "delete  from BaoCaoNhapHang where MaNguyenLieu='" + id + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean capNhat_NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong,int giaTien)
        {
            bool re = false;
            string sql = "update QuanLyNguyenLieu set TenNguyenLieu ='" + tenNguyenLieu+"', MaLoaiNguyenLieu = '"+maLoaiNguyenLieu+"', MaNhaCungCap ='"+maNhaCungCap+"', SoLuong='"+soLuong+"' , GiaTien='"+giaTien+"' where MaNguyenLieu = '"+maNguyenLieu+"'" ;
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean capNhat_BaoCaoNhapHang(string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        {
            bool re = false;
            string sql = "update BaoCaoNhapHang set TenNguyenLieu ='" + tenNguyenLieu + "', MaLoaiNguyenLieu = '" + maLoaiNguyenLieu + "', MaNhaCungCap ='" + maNhaCungCap + "', SoLuong='" + soLuong + "' , GiaTien='" + giaTien + "' where MaNguyenLieu = '" + maNguyenLieu + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public DataTable timKiem_Load(string obj)
        {
            DataTable da;
            string sql = "SELECT * FROM QuanLyNguyenLieu WHERE MaNguyenLieu LIKE '" + obj+"' or TenNguyenLieu = '"+obj+"'";
            da = xuly.creatTable(sql);
            return da;
        }
    }
}
