using System;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Control;

namespace Quản_Lý_Yellow_Cab_Pizza
{
    public partial class frm_QuanLyNguyenLieu : Form
    {
        public frm_QuanLyNguyenLieu()
        {
            InitializeComponent();
        }

        int i;

        quanlynguyenlieu_Model nguyenLieuModel = new quanlynguyenlieu_Model();
        quanlynguyenlieu_Control nguyenlieuControl = new quanlynguyenlieu_Control();

        private void frm_NguyenLieu_Load(object sender, EventArgs e)
        //load dữ liệu lên datagirdview
        {
            dgvNguyenLieu.DataSource = nguyenLieuModel.load_Data();

            dgvNguyenLieu.Columns["MaNguyenLieu"].Width = 155;
            dgvNguyenLieu.Columns["TenNguyenLieu"].Width = 200;
            dgvNguyenLieu.Columns["MaLoaiNguyenLieu"].Width = 150;
            dgvNguyenLieu.Columns["MaNhaCungCap"].Width = 200;
            dgvNguyenLieu.Columns["SoLuong"].Width = 150;
            dgvNguyenLieu.Columns["GiaTien"].Width = 150;

            dgvNguyenLieu.Columns[0].HeaderText = "Mã Nguyên Liệu";
            dgvNguyenLieu.Columns[1].HeaderText = "Tên Nguyên Liệu";
            dgvNguyenLieu.Columns[2].HeaderText = "Mã Loại Nguyên Liệu";
            dgvNguyenLieu.Columns[3].HeaderText = "Mã Nhà Cung Cấp";
            dgvNguyenLieu.Columns[4].HeaderText = "Số Lượng";
            dgvNguyenLieu.Columns[5].HeaderText = "Giá Tiền";
            

            //MessageBox.Show(dgvNguyenLieu.Rows[0].Cells[4].Value.ToString());
            for (i = 0; i < dgvNguyenLieu.Rows.Count; i++)
            {
                if (Int32.Parse(dgvNguyenLieu.Rows[i].Cells[4].Value.ToString()) < 0)
                {
                    string mgl = dgvNguyenLieu.Rows[0].Cells[0].Value.ToString();
                    string sl = dgvNguyenLieu.Rows[i].Cells[4].Value.ToString();
                    sl = "0";
                    nguyenlieuControl.capNhat_SoLuong(mgl, Int32.Parse(sl));
                }
                continue;
            }
        }
        private void macDinh()
            //đưa dữ liệu về trạng thái rổng
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtNhaCC.Text = "";
            txtLoaiNL.Text = "";
            txtSoLuong.Text = "";
            lbTinhTrang.Text = "";
            txtTimKiem.Text = "";
            txtGiaTien.Text = "";

        }

        private void dgvNguyenLieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //hiện thị thông tin lên textbox khi nhấn vào item trong datagirdview
        {
            try
            {
                i = dgvNguyenLieu.CurrentRow.Index;
                txtMaNL.Text = dgvNguyenLieu.Rows[i].Cells[0].Value.ToString();
                txtTenNL.Text = dgvNguyenLieu.Rows[i].Cells[1].Value.ToString();
                txtNhaCC.Text = dgvNguyenLieu.Rows[i].Cells[3].Value.ToString();
                txtLoaiNL.Text = dgvNguyenLieu.Rows[i].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvNguyenLieu.Rows[i].Cells[4].Value.ToString();
                txtGiaTien.Text = dgvNguyenLieu.Rows[i].Cells[5].Value.ToString();

                int t = Int32.Parse(txtSoLuong.Text);
                if (t >= 10)
                {
                    lbTinhTrang.Text = "Còn Hàng";
                }
                else if (t > 5 && t < 10)
                {
                    lbTinhTrang.Text = "Sắp hết hàng";
                    
                }
                else if (t > 0 && t <= 5)
                {
                    lbTinhTrang.Text = "Nhập hàng ngay";
                }
                else if (t == 0)
                {
                    lbTinhTrang.Text = "Hết hàng";
                }
            }
            catch
            {
 
            }
        }

        private void btMacDinh_Click(object sender, EventArgs e)
        {
            macDinh();
            frm_NguyenLieu_Load(sender, e);

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                frm_NguyenLieu_Load(sender, e);
            }
            else
            {
                dgvNguyenLieu.DataSource = nguyenLieuModel.timKiem_Load(txtTimKiem.Text.Trim());
            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMacDinh_Click_1(object sender, EventArgs e)
        {
            macDinh();
            frm_NguyenLieu_Load(sender, e);
        }
    }
}
