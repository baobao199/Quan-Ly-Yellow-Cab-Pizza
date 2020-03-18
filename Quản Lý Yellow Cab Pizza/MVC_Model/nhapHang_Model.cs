using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class nhapHang_Model
    {
        public DataTable load_NhapHang()
        {
            DataTable da;
            string sql = "select * from NhapHang ORDER BY SoHoaDon  DESC";
            da = xuly.creatTable(sql);
            return da;
        }
        public DataTable load_ChiTietNhapHang()
        {
            DataTable da;
            string sql = "select * from ChiTietNhapHang";
            da = xuly.creatTable(sql);
            return da;
        }

        public Boolean check_HoaDon(string obj)
        {
            bool re = false;
            string sql = "select count(SoHoaDon) from NhapHang where SoHoaDon = '" + obj + "'";
            if (xuly.executeScalar(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_NhapNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int giaTien, int SoLuong)
        {
            bool re = false;
            string sql = "insert into ChiTietNhapHang values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','" + maNhaCungCap + "','" + SoLuong + "','" + giaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_HoaDon(string soHoaDon)
        {
            bool re = false;
            string sql = "insert into NhapHang(SoHoaDon) values ('" + soHoaDon + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean xoa_ChiTietNguyenLieu(string soHoaDon)
        {
            bool re = false;
            string sql = "delete ChiTietNhapHang where SoHoaDon = '" + soHoaDon + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_BaoCaoNhapHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, DateTime ngayNhap, int soLuong, int giaTien)
        {
            bool re = false;
            string sql = "insert into BaoCaoNhapHang values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','" + maNhaCungCap + "','" + ngayNhap + "','" + soLuong + "','" + giaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean sua_BaoCaoNhapHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        {
            bool re = false;
            string sql = "update BaoCaoNhapHang set MaNguyenLieu ='"+maNguyenLieu+"', TenNguyenLieu = '"+tenNguyenLieu+"', MaNhaCungCap ='"+maNhaCungCap+"', SoLuong='"+soLuong+"', GiaTien = '"+giaTien+"' where SoHoaDon = '"+soHoaDon+"' and MaNguyenLieu = '"+maNguyenLieu+"'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean sua_ChiTietNhapHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        {
            bool re = false;
            string sql = "update ChiTietNhapHang set MaNguyenLieu ='" + maNguyenLieu + "', TenNguyenLieu = '" + tenNguyenLieu + "', MaNhaCungCap ='" + maNhaCungCap + "', SoLuong='" + soLuong + "', GiaTien = '" + giaTien + "' where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean xoa_ChiTietNhapHang(string soHoaDon, string maNguyenLieu)
        {
            bool re = false;
            string sql = "delete ChiTietNhapHang where SoHoaDon ='"+soHoaDon+"' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean xoa_BaoCaoNhapHang(string soHoaDon, string maNguyenLieu)
        {
            bool re = false;
            string sql = "delete BaoCaoNhapHang where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
