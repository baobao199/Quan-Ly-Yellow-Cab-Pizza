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

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_View
{
    public partial class frm_XuatHang : Form
    {
        public frm_XuatHang()
        {
            InitializeComponent();
        }
        xuatHang_Control xuatHangControl = new xuatHang_Control();
        xuatHang_Model xuatHangModel = new xuatHang_Model();

        private void frm_XuatHang_Load(object sender, EventArgs e)
        {
          

            dgvNguyenLieuXuat.DataSource = xuatHangModel.load_ChiTietXuatHang();
            dgvNguyenLieuXuat.Columns["SoHoaDon"].Visible = false;

            dgvNguyenLieuXuat.Columns["MaNguyenLieu"].Width = 150;
            dgvNguyenLieuXuat.Columns["TenNguyenLieu"].Width = 200;
            dgvNguyenLieuXuat.Columns["MaLoaiNguyenLieu"].Width = 150;
            dgvNguyenLieuXuat.Columns["MaNhaCungCap"].Width = 200;
            dgvNguyenLieuXuat.Columns["SoLuong"].Width = 150;
            dgvNguyenLieuXuat.Columns["GiaTien"].Width = 150;

            dgvNguyenLieuXuat.Columns[1].HeaderText = "Mã Nguyên Liệu";
            dgvNguyenLieuXuat.Columns[2].HeaderText = "Tên Nguyên Liệu";
            dgvNguyenLieuXuat.Columns[3].HeaderText = "Mã Loại Nguyên Liệu";
            dgvNguyenLieuXuat.Columns[4].HeaderText = "Mã Nhà Cung Cấp";
            dgvNguyenLieuXuat.Columns[5].HeaderText = "Số Lượng";
            dgvNguyenLieuXuat.Columns[6].HeaderText = "Giá Tiền";
        }

        private void btTaoHD_Click(object sender, EventArgs e)
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
                txtSoHoaDon.Text = "YLCXH0001";
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
                if (xuatHangControl.them_BaoCaoXuatHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, ngayNhap, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
                {
                    xuatHangControl.them_ChiTietXuatHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text));
                    if ((xuatHangControl.check_NguyenLieu(txtMaNL.Text)))
                    {

                        xuatHangControl.capnhat_SoLuong(Int32.Parse(txtSoLuong.Text), txtMaNL.Text, txtSoHoaDon.Text);
                    }
                    else
                    {
                        MessageBox.Show("Nguyên liệu đã hết");
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
            txtMaLoaiNL.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text == "" || txtTenNL.Text == "" || txtNhaCC.Text == "" || txtSoLuong.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (xuatHangControl.sua_ChiTietXuatHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
                {
                    xuatHangControl.capnhat_SoLuong(Int32.Parse(txtSoLuong.Text),txtMaNL.Text,txtSoHoaDon.Text);
                    xuatHangControl.sua_BaoCaoXuatHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text));
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

        private void dgvNguyenLieuXuat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            txtMaNL.Enabled = false;
            i = dgvNguyenLieuXuat.CurrentRow.Index;

            txtSoHoaDon.Text = dgvNguyenLieuXuat.Rows[i].Cells[0].Value.ToString();
            txtMaNL.Text = dgvNguyenLieuXuat.Rows[i].Cells[1].Value.ToString();
            txtTenNL.Text = dgvNguyenLieuXuat.Rows[i].Cells[2].Value.ToString();
            txtMaLoaiNL.Text= dgvNguyenLieuXuat.Rows[i].Cells[3].Value.ToString();
            txtNhaCC.Text = dgvNguyenLieuXuat.Rows[i].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvNguyenLieuXuat.Rows[i].Cells[5].Value.ToString();
            txtGiaTien.Text = dgvNguyenLieuXuat.Rows[i].Cells[6].Value.ToString();
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
