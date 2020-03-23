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

        public DataTable load_NguyenLieu(string maNguyenLieu)
        //load nguyên liệu lên phần mềm
        {
            DataTable da;
            string sql = "select * from NguyenLieu where MaNguyenLieu ='" + maNguyenLieu + "'";
            da = xuly.creatTable(sql);
            return da;
        }

        public Boolean them_ChiTietXuatNguyenLieu(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int giaTien, int SoLuong)
        //thêm nguyên liệu nhập
        {
            bool re = false;
            string sql = "insert into ChiTietXuatHang values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','" + maLoaiNguyenLieu + "','" + maNhaCungCap + "','" + SoLuong + "','" + giaTien + "')";
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
            string sql = "insert into XuatHang(SoHoaDon) values ('" + soHoaDon + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }


        public Boolean xoa_ChiTietXuatNguyenLieu(string soHoaDon)
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
        //xóa 1 nguyên liệu trong báo cáo nhập hàng bằng số hóa đơn
        {
            bool re = false;
            string sql = "delete BaoCaoXuatHang where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }


        public Boolean them_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, DateTime ngayXuat, int soLuong, int giaTien)
        // thêm dữ liệu vào báo cáo nhập hàng
        {
            bool re = false;
            string sql = "insert into BaoCaoXuatHang values('" + soHoaDon + "','" + maNguyenLieu + "','" + tenNguyenLieu + "','" + maLoaiNguyenLieu + "','" + maNhaCungCap + "','" + ngayXuat + "','" + soLuong + "','" + giaTien + "')";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }


        public Boolean sua_BaoCaoXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        //cập nhật nguyên liệu báo cáo nhâp hàng
        {
            bool re = false;
            string sql = "update BaoCaoXuatHang set MaNguyenLieu ='" + maNguyenLieu + "', TenNguyenLieu = '" + tenNguyenLieu + "', MaLoaiNguyenLieu='" + maLoaiNguyenLieu + "' ,MaNhaCungCap ='" + maNhaCungCap + "', SoLuong='" + soLuong + "', GiaTien = '" + giaTien + "' where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean sua_ChiTietXuatHang(string soHoaDon, string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int giaTien)
        //cập nhật chi tiết nhập hàng
        {
            bool re = false;
            string sql = "update ChiTietXuatHang set MaNguyenLieu ='" + maNguyenLieu + "', TenNguyenLieu = '" + tenNguyenLieu + "',  MaLoaiNguyenLieu='" + maLoaiNguyenLieu + "' ,MaNhaCungCap ='" + maNhaCungCap + "', SoLuong='" + soLuong + "', GiaTien = '" + giaTien + "' where SoHoaDon = '" + soHoaDon + "' and MaNguyenLieu = '" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }


        public Boolean capnhat_SoLuong(int soLuong, string maNguyenLieu)
        //cập nhật số lượng nguyên liệu nhập vào quản lý nguyên liệu
        {
            bool re = false;
            string sql = "update QuanLyNguyenLieu set SoLuong = SoLuong - '" + soLuong + "' where MaNguyenLieu='" + maNguyenLieu + "' ";
            if (xuly.executeQuery(sql) > 0)
            { 
                re = true;
            }
            return re;
        }


        public Boolean capnhat_SoLuongSuaBot(int soLuong, string maNguyenLieu)
        //cập nhật số lượng nguyên liệu nhập vào quản lý nguyên liệu
        {
            bool re = false;
            string sql = "update QuanLyNguyenLieu set SoLuong = SoLuong - '" + soLuong + "' where MaNguyenLieu='" + maNguyenLieu + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public Boolean capnhat_SoLuongSuaThem(int soLuong, string maNguyenLieu)
        //cập nhật số lượng nguyên liệu nhập vào quản lý nguyên liệu
        {
            bool re = false;
            string sql = "update QuanLyNguyenLieu set SoLuong = SoLuong + '" + soLuong + "' where MaNguyenLieu='" + maNguyenLieu + "' ";
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


        //public Boolean them_QuanLyNguyenLieu(string maNguyenLieu, string tenNguyenLieu, string maLoaiNguyenLieu, string maNhaCungCap, int soLuong, int GiaTien)
        ////thêm vào quản lý nguyên liệu nếu không có
        //{
        //    bool re = false;
        //    string sql = "insert into QuanLyNguyenLieu values('" + maNguyenLieu + "','" + tenNguyenLieu + "','" + maLoaiNguyenLieu + "','" + maNhaCungCap + "','" + soLuong + "','" + GiaTien + "')";
        //    if (xuly.executeQuery(sql) > 0)
        //    {
        //        re = true;
        //    }
        //    return re;
        //}

        public Boolean xoa_XuatHang(string soHoaDon)
        {
            bool re = false;
            string sql = "delete XuatHang where SoHoaDon ='" + soHoaDon + "'";
            if (xuly.executeQuery(sql) > 0)
            {
                re = true;
            }
            return re;
        }

        public DataTable check_ConHang(int soLuong, string maNguyenLieu)
        {
            DataTable da;
            string sql = "select SoLuong = SoLuong - '"+ soLuong + "' from QuanLyNguyenLieu where MaNguyenLieu = '"+ maNguyenLieu + "' ";
            da = xuly.creatTable(sql);
            return da;
        }
    }
}
