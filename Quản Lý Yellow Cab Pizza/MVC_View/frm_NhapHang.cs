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

        int i;
        nhapHang_Control nhapHangControl = new nhapHang_Control();
        nhapHang_Model nhapHangModel = new nhapHang_Model();

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();

        }

        private void btTaoHD_Click(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            string iD1 = dgvNguyenLieuNhap[0, dgvNguyenLieuNhap.RowCount - 1].Value.ToString();
            int iD3 = int.Parse( iD1.Substring(5));

            txtSoHoaDon.Text = "YLCNH" + formatID(iD3+1);

            
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
            //if (nhapHangControl.them_NhapNguyenLieu(txtSoHoaDon.Text, txtMaNL.Text, txtTenNL.Text, txtLoaiNL.Text, txtNhaCC.Text, Int32.Parse(txtGiaTien.Text), Int32.Parse(txtSoLuong.Text)))
            //{
            //    MessageBox.Show("NhapThanh Cong");
            //}
            //else
            //{
            //    MessageBox.Show("Nhap k Thanh Cong");
            //}
            //frm_NhapHang_Load(sender, e);
            //macDinh();
            int indexRow = dgvNguyenLieuNhap.Rows.Count-1 ;
            dgvNguyenLieuNhap[1, indexRow].Value = txtMaNL.Text;
            dgvNguyenLieuNhap[2, indexRow].Value = txtTenNL.Text;
        }



        public void macDinh()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtGiaTien.Text = "";
            txtLoaiNL.Text = "";
            txtSoLuong.Text = "";
            txtNhaCC.Text = "";
        }

        private void frm_NhapHang_Load(object sender, EventArgs e)
        {
            dgvNguyenLieuNhap.DataSource = nhapHangModel.load_Data();
            dgvNguyenLieuNhap.Columns[0].Visible = false;
        }
    }
}
