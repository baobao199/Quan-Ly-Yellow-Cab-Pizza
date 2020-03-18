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

        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();

        }

        private void btTaoHD_Click(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            DataTable dt = nhapHangModel.load_NhapHang();

            string iD1 = dt.Rows[0][0].ToString();
            int iD3 = int.Parse(iD1.Substring(5));

            

            txtSoHoaDon.Text = "YLCNH" + formatID(iD3 + 1);
            if (nhapHangControl.them_HoaDon(txtSoHoaDon.Text))
            {
                MessageBox.Show("Hóa đơn mới được tạo");
                btTaoHD.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hóa đơn không được tạo");
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
            btIn.Enabled = true;
            btTaoHD.Enabled = false;
            DateTime ngayNhap = DateTime.Now;
            if (nhapHangControl.them_BaoCaoNhapHang(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtNhaCC.Text, ngayNhap ,Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
            {

                nhapHangControl.them_NhapNguyenLieu(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text));
                MessageBox.Show("Một sản phẩm đã được thêm");
                txtMaNL.Focus();
            }
            else
            {
                MessageBox.Show("Không thể thêm sản phẩm");
            }
            frm_NhapHang_Load(sender, e);
            macDinh();
        }



        public void macDinh()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtGiaTien.Text = "";
            txtSoLuong.Text = "";
            txtNhaCC.Text = "";
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            btTaoHD.Enabled = true;
            btThem.Enabled = false;
            macDinh();
            if (nhapHangControl.xoa_ChiTietNguyenLieu(txtSoHoaDon.Text))
            {
                MessageBox.Show("Hóa đơn đang được xuất file exel");
                
            }
            else
            {
                MessageBox.Show("Xuất hóa đơn thất bại");
            }
            txtSoHoaDon.Text = "";
            frm_NhapHang_Load(sender, e);
        }

        private void dgvNguyenLieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNguyenLieuNhap.CurrentRow.Index;

            txtMaNL.Text = dgvNguyenLieuNhap.Rows[i].Cells[1].Value.ToString();
            txtTenNL.Text = dgvNguyenLieuNhap.Rows[i].Cells[2].Value.ToString();
            txtNhaCC.Text = dgvNguyenLieuNhap.Rows[i].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvNguyenLieuNhap.Rows[i].Cells[4].Value.ToString();
            txtGiaTien.Text = dgvNguyenLieuNhap.Rows[i].Cells[5].Value.ToString();
        }
    }
}
