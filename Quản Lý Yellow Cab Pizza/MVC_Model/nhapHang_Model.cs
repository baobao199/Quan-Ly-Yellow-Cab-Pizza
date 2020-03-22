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
            // load dữ liệu lên phần mềm
        {
            DataTable da;
            string sql = "select * from NhapHang ORDER BY SoHoaDon  DESC";
            da = xuly.creatTable(sql);
            return da;
        }
        public DataTable load_ChiTietNhapHang()
        // load dữ liệu lên datagridview
        {
            DataTable da;
            string sql = "select * from ChiTietNhapHang";
            da = xuly.creatTable(sql);
            return da;
        }

        public Boolean them_NhapNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int giaTien, int SoLuong)
            //thêm nguyên liệu nhập
        {
            bool re = false;
            string sql = "insert into ChiTietNhapHang values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','"+maLoaiNguyenLieu+"','" + maNhaCungCap + "','" + SoLuong + "','" + giaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_HoaDon(string soHoaDon)
            // thêm hóa đơn
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
            // xóa hóa đơn để tạo hóa đơn mới
        {
            bool re = false;
            string sql = "delete ChiTietNhapHang where SoHoaDon = '" + soHoaDon + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_BaoCaoNhapHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, DateTime ngayNhap, int soLuong, int giaTien)
            // thêm dữ liệu vào báo cáo nhập hàng
        {
            bool re = false;
            string sql = "insert into BaoCaoNhapHang values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','"+maLoaiNguyenLieu+"','" + maNhaCungCap + "','" + ngayNhap + "','" + soLuong + "','" + giaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean sua_BaoCaoNhapHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu,string maNhaCungCap, int soLuong, int giaTien)
            //cập nhật nguyên liệu báo cáo nhâp hàng
        {
            bool re = false;
            string sql = "update BaoCaoNhapHang set MaNguyenLieu ='"+maNguyenLieu+"', TenNguyenLieu = '"+tenNguyenLieu+"', MaLoaiNguyenLieu='"+maLoaiNguyenLieu+"' ,MaNhaCungCap ='"+maNhaCungCap+"', SoLuong='"+soLuong+"', GiaTien = '"+giaTien+"' where SoHoaDon = '"+soHoaDon+"' and MaNguyenLieu = '"+maNguyenLieu+"'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean sua_ChiTietNhapHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
            //cập nhật chi tiết nhập hàng
        {
            bool re = false;
            string sql = "update ChiTietNhapHang set MaNguyenLieu ='" + maNguyenLieu + "', TenNguyenLieu = '" + tenNguyenLieu + "',  MaLoaiNguyenLieu='" + maLoaiNguyenLieu + "' ,MaNhaCungCap ='" + maNhaCungCap + "', SoLuong='" + soLuong + "', GiaTien = '" + giaTien + "' where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean xoa_ChiTietNhapHang(string soHoaDon, string maNguyenLieu)
            //xóa 1 nguyên liệu trong chi tiết nhập hàng
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
            //xóa 1 nguyên liệu trong báo cáo nhập hàng
        {
            bool re = false;
            string sql = "delete BaoCaoNhapHang where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean capnhat_SoLuong(int soLuong, string maNguyenLieu, string soHoaDon)
            //cập nhật số lượng nguyên liệu nhập vào quản lý nguyên liệu
        {
            bool re = false;
            string sql = "update QuanLyNguyenLieu set SoLuong = SoLuong + (select SoLuong from BaoCaoNhapHang where MaNguyenLieu = '"+maNguyenLieu+"' and SoHoaDon = '"+soHoaDon+"') where MaNguyenLieu = '"+maNguyenLieu+"' ";
            if (xuly.executeQuery(sql)>0)
            {
                re = true;
            }
            return re;
        }
        public Boolean check_NguyenLieu(string maNguyenLieu)
            //kiểm tra nguyên liệu có trong quản lý nguyên liệu hay không
        {
            bool re = false;
            string sql = "select count(MaNguyenLieu) from QuanLyNguyenLieu where MaNguyenLieu = '"+maNguyenLieu+"' ";
            if (xuly.executeScalar(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_QuanLyNguyenLieu(string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int GiaTien)
            //thêm vào quản lý nguyên liệu nếu không có
        {
            bool re = false;
            string sql = "insert into QuanLyNguyenLieu values('"+maNguyenLieu+"','"+tenNguyenLieu+"','"+maLoaiNguyenLieu+"','"+maNhaCungCap+"','"+soLuong+ "','" + GiaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

    }
}
