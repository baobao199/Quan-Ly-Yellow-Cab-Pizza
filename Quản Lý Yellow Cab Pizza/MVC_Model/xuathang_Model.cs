using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class xuatHang_Model
    {
        public DataTable load_XuatHang()
        // load dữ liệu lên phần mềm
        {
            DataTable da;
            string sql = "select * from XuatHang ORDER BY SoHoaDon  DESC";
            da = xuly.creatTable(sql);
            return da;
        }
        public DataTable load_ChiTietXuatHang()
        // load dữ liệu lên datagridview
        {
            DataTable da;
            string sql = "select * from ChiTietXuatHang";
            da = xuly.creatTable(sql);
            return da;
        }
        public Boolean them_HoaDon(string soHoaDon)
        // thêm hóa đơn
        {
            bool re = false;
            string sql = "insert into XuatHang(SoHoaDon) values ('" + soHoaDon + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_XuatNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int giaTien, int SoLuong)
        //thêm nguyên liệu nhập
        {
            bool re = false;
            string sql = "insert into ChiTietXuatHang values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','" + maNhaCungCap + "','" + SoLuong + "','" + giaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean xoa_ChiTietXuatHang(string soHoaDon)
        // xóa hóa đơn để tạo hóa đơn mới
        {
            bool re = false;
            string sql = "delete ChiTietXuatHang where SoHoaDon = '" + soHoaDon + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean them_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, DateTime ngayNhap, int soLuong, int giaTien)
        // thêm dữ liệu vào báo cáo nhập hàng
        {
            bool re = false;
            string sql = "insert into BaoCaoXuatHang values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','" + maNhaCungCap + "','" + ngayNhap + "','" + soLuong + "','" + giaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean sua_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        //cập nhật nguyên liệu báo cáo nhâp hàng
        {
            bool re = false;
            string sql = "update BaoCaoXuatHang set MaNguyenLieu ='" + maNguyenLieu + "', TenNguyenLieu = '" + tenNguyenLieu + "', MaNhaCungCap ='" + maNhaCungCap + "', SoLuong='" + soLuong + "', GiaTien = '" + giaTien + "' where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean sua_ChiTietXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        //cập nhật chi tiết nhập hàng
        {
            bool re = false;
            string sql = "update ChiTietXuatHang set MaNguyenLieu ='" + maNguyenLieu + "', TenNguyenLieu = '" + tenNguyenLieu + "', MaNhaCungCap ='" + maNhaCungCap + "', SoLuong='" + soLuong + "', GiaTien = '" + giaTien + "' where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean xoa_ChiTietXuatHang(string soHoaDon, string maNguyenLieu)
        //xóa 1 nguyên liệu trong chi tiết nhập hàng
        {
            bool re = false;
            string sql = "delete ChiTietXuatHang where SoHoaDon ='" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean xoa_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu)
        //xóa 1 nguyên liệu trong báo cáo nhập hàng
        {
            bool re = false;
            string sql = "delete BaoCaoXuatHang where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
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
            string sql = "update QuanLyNguyenLieu set SoLuong = SoLuong - (select SoLuong from BaoCaoXuatHang where MaNguyenLieu = '" + maNguyenLieu + "' and SoHoaDon = '" + soHoaDon + "') where MaNguyenLieu = '" + maNguyenLieu + "' ";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }
        public Boolean check_NguyenLieu(string maNguyenLieu)
        //kiểm tra nguyên liệu có trong quản lý nguyên liệu hay không
        {
            bool re = false;
            string sql = "select count(MaNguyenLieu) from QuanLyNguyenLieu where MaNguyenLieu = '" + maNguyenLieu + "' ";
            if (xuly.executeScalar(sql) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
