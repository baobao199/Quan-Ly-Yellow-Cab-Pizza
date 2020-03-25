using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_View
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        dangNhap_Model dangNhapModel = new dangNhap_Model();

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = dangNhapModel.check_TaiKhoan(txtTenDangNhap.Text,txtMatKhau.Text);
            
            try
            {
                if (txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Tài khoản chưa được nhập");
                    txtTenDangNhap.Focus();
                }
                else if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Mật khẩu chưa được nhập");
                    txtMatKhau.Focus();
                }
                else if (txtTenDangNhap.Text != dt.Rows[0][0].ToString() && txtMatKhau.Text == dt.Rows[0][1].ToString())
                {
                    MessageBox.Show("Tên đăng nhập không đúng");
                    txtTenDangNhap.Focus();
                }
                else if (txtTenDangNhap.Text == dt.Rows[0][0].ToString() && txtMatKhau.Text != dt.Rows[0][1].ToString())
                {
                    MessageBox.Show("Mật khẩu không đúng");
                    txtMatKhau.Focus();
                }
                else if (txtTenDangNhap.Text == dt.Rows[0][0].ToString() && txtMatKhau.Text == dt.Rows[0][1].ToString())
                {

                    MessageBox.Show("Đăng nhập thành công");
                    frm_Main main = new frm_Main();
                    main.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Tên đăng nhập và Mật khẩu không đúng");
            }
            
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
