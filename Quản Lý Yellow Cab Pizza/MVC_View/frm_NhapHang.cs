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
            dgvNguyenLieuNhap.DataSource = nhapHangModel.load_NhapHang();
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
            string iD1 = dgvNguyenLieuNhap[0, dgvNguyenLieuNhap.RowCount - 2].Value.ToString();
            int iD3 = int.Parse(iD1.Substring(5));

            txtSoHoaDon.Text = "YLCNH" + formatID(iD3 + 1);
            //if (nhapHangControl.them_HoaDon(txtSoHoaDon.Text))
            //{
            //    MessageBox.Show("Hóa đơn mới được tạo");
            //}
            //else
            //{
            //    MessageBox.Show("Hóa đơn không được tạo");
            //}
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
            //if (nhapHangControl.them_NhapNguyenLieu(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
            //{
            //    MessageBox.Show("Một sản phẩm đã được thêm");
            //}
            //else
            //{
            //    MessageBox.Show("Không thể thêm sản phẩm");
            //}
            frm_NhapHang_Load(sender, e);
            macDinh();
        }



        public void macDinh()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtGiaTien.Text = "";
            txtLoaiNL.Text = "";
            txtSoLuong.Text = "";
            txtNhaCC.Text = "";
            txtSoHoaDon.Text = "";
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            btTaoHD.Enabled = true;
            btThem.Enabled = false;
            macDinh();

        }
    }
}
