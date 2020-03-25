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
using System.Data;
using System.Data.SqlClient;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Control;

namespace Quản_Lý_Yellow_Cab_Pizza
{
    public partial class frm_TaiKhoan : Form
    {
        public frm_TaiKhoan()
        {
            InitializeComponent();
        }
        taiKhoan_Model taiKhoanModel = new taiKhoan_Model();
        taiKhoan_Control taiKhoanControl = new taiKhoan_Control();
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }
        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            txtMatKhauMoi.Focus();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frm_DangNhap"];
            txtTKNhanVien.Text = ((frm_DangNhap)f).txtTenDangNhap.Text;

            DataTable dt = taiKhoanModel.taiKhoan(txtTKNhanVien.Text);

            txtTenNhanVien.Text = dt.Rows[0][2].ToString();

        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            DataTable dt = taiKhoanModel.taiKhoan(txtTKNhanVien.Text);
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ");
            }
            else if (txtMatKhauCu.Text != dt.Rows[0][1].ToString())
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            }
            else if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới");
            }
            else if (txtXacNhan.Text == "")
            {
                MessageBox.Show("Bạn chưa xác nhận mật khẩu mới");
            }
            else if(txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
            }
            else if(txtMatKhauCu.Text == dt.Rows[0][1].ToString() && txtMatKhauMoi.Text == txtXacNhan.Text)
            {
                taiKhoanControl.capNhat_MatKhau(txtTKNhanVien.Text, txtMatKhauMoi.Text);
                MessageBox.Show("Cập nhật mật khẩu thành công");
                frm_DangNhap dangNhap = new frm_DangNhap();
                this.Hide();
                dangNhap.Show();
            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu không thành công");
            }

        }
    }
}
