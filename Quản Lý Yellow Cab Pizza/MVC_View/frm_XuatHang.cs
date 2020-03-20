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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }
        xuatHang_Model xuatHangModel = new xuatHang_Model();
        xuatHang_Control xuatHangControl = new xuatHang_Control();

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
    }
}
