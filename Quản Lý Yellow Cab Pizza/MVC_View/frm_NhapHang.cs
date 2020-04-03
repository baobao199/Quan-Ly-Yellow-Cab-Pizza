using Quản_Lý_Yellow_Cab_Pizza.MVC_Control;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using Quản_Lý_Yellow_Cab_Pizza.MVC_View;
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
    public partial class frm_NhapHang : Form
    {
        public frm_NhapHang()
        {
            InitializeComponent();
        }


        nhapHang_Control nhapHangControl = new nhapHang_Control();
        nhapHang_Model nhapHangModel = new nhapHang_Model();

        private void frm_NhapHang_Load(object sender, EventArgs e)
        {
            dgvNguyenLieuNhap.DataSource = nhapHangModel.load_ChiTietNhapHang();
            dgvNguyenLieuNhap.Columns["SoHoaDon"].Visible = false;

            dgvNguyenLieuNhap.Columns["MaNguyenLieu"].Width = 150;
            dgvNguyenLieuNhap.Columns["TenNguyenLieu"].Width = 200;
            dgvNguyenLieuNhap.Columns["MaLoaiNguyenLieu"].Width = 150;
            dgvNguyenLieuNhap.Columns["MaNhaCungCap"].Width = 200;
            dgvNguyenLieuNhap.Columns["SoLuong"].Width = 150;
            dgvNguyenLieuNhap.Columns["GiaTien"].Width = 150;

            dgvNguyenLieuNhap.Columns[1].HeaderText = "Mã Nguyên Liệu";
            dgvNguyenLieuNhap.Columns[2].HeaderText = "Tên Nguyên Liệu";
            dgvNguyenLieuNhap.Columns[3].HeaderText = "Mã Loại Nguyên Liệu";
            dgvNguyenLieuNhap.Columns[4].HeaderText = "Mã Nhà Cung Cấp";
            dgvNguyenLieuNhap.Columns[5].HeaderText = "Số Lượng";
            dgvNguyenLieuNhap.Columns[6].HeaderText = "Giá Tiền";
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            nhapHangControl.xoa_ChiTietNguyenLieu(txtSoHoaDon.Text);
            this.Close();
            Dispose();
        }

        private void btTaoHD_Click(object sender, EventArgs e)
        {
           
            txtMaNL.Focus();
            DataTable dt = nhapHangModel.load_NhapHang();
            btThem.Enabled = true;
            btXoa.Enabled = true;
            btIn.Enabled = true;
            btSua.Enabled = true;

            if (dt.Rows.Count > 0)
            {
                string iD1 = dt.Rows[0][0].ToString();
                int iD3 = int.Parse(iD1.Substring(5));
                txtSoHoaDon.Text = "YLCNH" + formatID(iD3 + 1);
                if (nhapHangControl.them_HoaDon(txtSoHoaDon.Text))
                {
                    MessageBox.Show("Hóa đơn mới được tạo");
                    
                }
                else
                {
                    MessageBox.Show("Hóa đơn không được tạo");
                }
            }
            else
            {
                txtSoHoaDon.Text = "YLCNH0001";
                nhapHangControl.them_HoaDon(txtSoHoaDon.Text);
                MessageBox.Show("Hóa đơn mới được tạo");
            }
        }

        private String formatID(int id)
        {
            string re = "";
            if(id < 10)
            {
                re = "000" + id.ToString();
            }
            else if(id < 100)
            {
                re = "00" + id.ToString();
            }
            else if(id < 1000)
            {
                re = "0" + id.ToString();
            }
            else
            {
                re =  id.ToString();
            }
            return re;
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (Int32.Parse(txtSoLuong.Text) <= 0)
                {
                    MessageBox.Show("Số lượng không được âm");
                }
                else
                {
                    DateTime ngayNhap = DateTime.Now;
                    if (nhapHangControl.them_BaoCaoNhapHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, ngayNhap, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
                    {

                        nhapHangControl.them_NhapNguyenLieu(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text));
                        if ((nhapHangControl.check_NguyenLieu(txtMaNL.Text)))
                        {

                            nhapHangControl.capnhat_SoLuong(Int32.Parse(txtSoLuong.Text), txtMaNL.Text, txtSoHoaDon.Text);
                        }
                        else
                        {
                            nhapHangControl.them_QuanLyNguyenLieu(txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text));
                        }

                        MessageBox.Show("Một sản phẩm đã được thêm");
                        txtMaNL.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sản phẩm");
                    }
                }
                frm_NhapHang_Load(sender, e);
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

        private void btIn_Click(object sender, EventArgs e)
        {
            macDinh();
            txtSoHoaDon.Text = "";
            frm_InHoaDon inHoaDon = new frm_InHoaDon();
            inHoaDon.Show();
            this.Close();
        }

        private void dgvNguyenLieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            
            i = dgvNguyenLieuNhap.CurrentRow.Index;
   
            txtSoHoaDon.Text = dgvNguyenLieuNhap.Rows[i].Cells[0].Value.ToString();
            txtMaNL.Text = dgvNguyenLieuNhap.Rows[i].Cells[1].Value.ToString();
            txtTenNL.Text = dgvNguyenLieuNhap.Rows[i].Cells[2].Value.ToString();
            txtMaLoaiNL.Text = dgvNguyenLieuNhap.Rows[i].Cells[3].Value.ToString();
            txtNhaCC.Text = dgvNguyenLieuNhap.Rows[i].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvNguyenLieuNhap.Rows[i].Cells[5].Value.ToString();
            txtGiaTien.Text = dgvNguyenLieuNhap.Rows[i].Cells[6].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            
            if (txtMaNL.Text == "" || txtTenNL.Text == "" || txtNhaCC.Text == "" || txtSoLuong.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (Int32.Parse(txtSoLuong.Text) <= 0)
                {
                    MessageBox.Show("Số lượng không được âm");
                }
                else
                {
                    //giá trị chênh lệch để chỉnh sửa cập nhật số lượng quản lý nguyên liệu
                    int i;
                    i = dgvNguyenLieuNhap.CurrentRow.Index;
                    int soDu = Int32.Parse(dgvNguyenLieuNhap.Rows[i].Cells[5].Value.ToString()) - Int32.Parse(txtSoLuong.Text);
                    if (nhapHangControl.sua_ChiTietNhapHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
                    {
                        if (soDu > 0)
                        //bớt sản phẩm
                        {
                            nhapHangControl.capnhat_SoLuongSuaBot(layDuong(soDu), txtMaNL.Text);
                        }
                        else
                        // thêm sản phẩm 
                        {
                            nhapHangControl.capnhat_SoLuongSuaThem(layDuong(soDu), txtMaNL.Text);
                        }

                        nhapHangControl.sua_BaoCaoNhapHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text));
                        MessageBox.Show("Nguyên liệu đã được cập nhật");
                    }

                    else
                    {
                        MessageBox.Show("Nguyên liệu không được cập nhật");
                    }
                }
            }
            frm_NhapHang_Load(sender, e);
        }

        private int layDuong(int soDu)
        {
            int re;
            if(soDu < 0)
            {
                re = soDu * -1;
            }
            else
            {
                re = soDu;
            }
            return re;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (nhapHangControl.xoa_ChiTietNhapHang(txtSoHoaDon.Text,txtMaNL.Text))
            {
                int i;
                i = dgvNguyenLieuNhap.CurrentRow.Index;
                int soDu = Int32.Parse(dgvNguyenLieuNhap.Rows[i].Cells[5].Value.ToString());

                nhapHangControl.xoa_BaoCaoNhapHang(txtSoHoaDon.Text, txtMaNL.Text);
                nhapHangControl.capnhat_SoLuongSuaBot(layDuong(soDu),txtMaNL.Text);
                

                MessageBox.Show("Nguyên liệu đã được xóa");
                macDinh();
            }
            else
            {
                MessageBox.Show("Nguyên liệu không xóa được");
            }
            frm_NhapHang_Load(sender, e);
        }
        private void txtMaNL_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = nhapHangModel.load_NguyenLieu(txtMaNL.Text);
                txtTenNL.Text = dt.Rows[0][1].ToString();
                txtMaLoaiNL.Text = dt.Rows[0][2].ToString();
                txtNhaCC.Text = dt.Rows[0][3].ToString();
                txtGiaTien.Text = dt.Rows[0][4].ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            macDinh();
        }
    }
}
