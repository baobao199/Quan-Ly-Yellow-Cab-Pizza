using Quản_Lý_Yellow_Cab_Pizza.MVC_Control;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Yellow_Cab_Pizza
{
    public partial class frm_XuatHang : Form
    {
        public frm_XuatHang()
        {
            InitializeComponent();
        }


        xuatHang_Model xuatHangModel = new xuatHang_Model();
        xuatHang_Control xuatHangControl = new xuatHang_Control();

        private void btThoat_Click(object sender, EventArgs e)
        {
            xuatHangControl.xoa_ChiTietXuatHang(txtSoHoaDon.Text);
            this.Close();
            Dispose();
        }
    
        private void frm_XuatHang_Load(object sender, EventArgs e)
        {
            dgvNguyenLieuXuat.DataSource = xuatHangModel.load_ChiTietXuatHang();
            dgvNguyenLieuXuat.Columns["SoHoaDon"].Visible = false;
        }

        private void btTaoHoaDon_Click(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            txtMaNL.Focus();
            DataTable dt = xuatHangModel.load_XuatHang();


            if (dt.Rows.Count > 0)
            {
                string iD1 = dt.Rows[0][0].ToString();
                int iD3 = int.Parse(iD1.Substring(5));
                txtSoHoaDon.Text = "YLCXH" + formatID(iD3 + 1);
                if (xuatHangControl.them_HoaDon(txtSoHoaDon.Text))
                {
                    MessageBox.Show("Hóa đơn mới được tạo");
                    btTaoHD.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hóa đơn không được tạo");
                }
            }
            else
            {
                txtSoHoaDon.Text = "YLCNH0001";
                xuatHangControl.them_HoaDon(txtSoHoaDon.Text);
                MessageBox.Show("Hóa đơn mới được tạo");
            }
        }
        private String formatID(int id)
        {
            string re = "";
            if (id < 10)
            {
                re = "000" + id.ToString();
            }
            else if (id < 100)
            {
                re = "00" + id.ToString();
            }
            else if (id < 1000)
            {
                re = "0" + id.ToString();
            }
            else
            {
                re = id.ToString();
            }
            return re;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btIn.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btTaoHD.Enabled = false;
            txtMaNL.Enabled = true;

            try
            {
                DateTime ngayNhap = DateTime.Now;
                if (xuatHangControl.them_BaoCaoXuatHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtNhaCC.Text, ngayNhap, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
                {

                    xuatHangControl.them_XuatNguyenLieu(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text));
                    if ((xuatHangControl.check_NguyenLieu(txtMaNL.Text)))
                    {

                        xuatHangControl.capnhat_SoLuong(Int32.Parse(txtSoLuong.Text), txtMaNL.Text, txtSoHoaDon.Text);
                    }
                    else
                    {
                        MessageBox.Show("Nguyên liệu đã hết hàng");
                    }

                    MessageBox.Show("Một sản phẩm đã được thêm");
                    txtMaNL.Focus();
                }
                else
                {
                    MessageBox.Show("Không thể thêm sản phẩm");
                }
                frm_XuatHang_Load(sender, e);
                macDinh();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi ~~");
                macDinh();
            }

        }
        public void macDinh()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtGiaTien.Text = "";
            txtSoLuong.Text = "";
            txtNhaCC.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text == "" || txtTenNL.Text == "" || txtNhaCC.Text == "" || txtSoLuong.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (xuatHangControl.sua_ChiTietXuatHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
                {

                    xuatHangControl.sua_BaoCaoXuatHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text));
                    MessageBox.Show("Nguyên liệu đã được cập nhật");
                }
                else
                {
                    MessageBox.Show("Nguyên liệu không được cập nhật");
                }
            }
            frm_XuatHang_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (xuatHangControl.xoa_ChiTietXuatHang(txtSoHoaDon.Text, txtMaNL.Text))
            {

                xuatHangControl.xoa_BaoCaoXuatHang(txtSoHoaDon.Text, txtMaNL.Text);
                MessageBox.Show("Nguyên liệu đã được xóa");
                macDinh();
            }
            else
            {
                MessageBox.Show("Nguyên liệu không xóa được");
            }
            frm_XuatHang_Load(sender, e);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            btTaoHD.Enabled = true;
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;

            if (xuatHangControl.xoa_ChiTietXuatHang(txtSoHoaDon.Text))
            {
                MessageBox.Show("Hóa đơn đang được xuất file exel");

            }
            else
            {
                MessageBox.Show("Xuất hóa đơn thất bại");
            }

            macDinh();
            txtSoHoaDon.Text = "";
            frm_XuatHang_Load(sender, e);
        }
    }
}
