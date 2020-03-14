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
    public partial class frm_NguyenLieu : Form
    {
        public frm_NguyenLieu()
        {
            InitializeComponent();
        }

        int i;

        nguyenlieu_Model nguyenLieuModel = new nguyenlieu_Model();
        nguyenlieu_Control nguyenlieuControl = new nguyenlieu_Control();

        private void frm_NguyenLieu_Load(object sender, EventArgs e)
            //load dữ liệu lên datagirdview
        {
            dgvNguyenLieu.DataSource = nguyenLieuModel.load_Data();
        }
        private void macDinh()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtNhaCC.Text = "";
            txtLoaiNL.Text = "";
            txtGiaTien.Text = "";
            txtSoLuong.Text = "";
            lbTinhTrang.Text = "";
        }

        private void dgvNguyenLieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //hiện thị thông tin lên button khi nhấn vào item
        {
            i = dgvNguyenLieu.CurrentRow.Index;
            txtMaNL.Text = dgvNguyenLieu.Rows[i].Cells[0].Value.ToString();
            txtTenNL.Text = dgvNguyenLieu.Rows[i].Cells[1].Value.ToString();
            txtNhaCC.Text = dgvNguyenLieu.Rows[i].Cells[3].Value.ToString();
            txtLoaiNL.Text = dgvNguyenLieu.Rows[i].Cells[2].Value.ToString();
            txtGiaTien.Text = dgvNguyenLieu.Rows[i].Cells[5].Value.ToString();
            txtSoLuong.Text = dgvNguyenLieu.Rows[i].Cells[4].Value.ToString();
            try
            {
                int t = Int32.Parse(txtSoLuong.Text);
                if (t >= 10)
                {
                    lbTinhTrang.Text = "Còn Hàng";
                }
                else if (t < 10)
                {
                    lbTinhTrang.Text = "Sắp hết hàng";
                    
                }
                else if (t <= 5)
                {
                    lbTinhTrang.Text = "Cần nhập hàng ngay";
                }
            }
            catch
            {

            }
        }

        private void btMacDinh_Click(object sender, EventArgs e)
        {
            macDinh();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(txtTenNL.Text =="" ||txtMaNL.Text == "" || txtNhaCC.Text == "" || txtSoLuong.Text == "" || txtGiaTien.Text =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (nguyenlieuControl.capNhat_NguyenLieu(txtTenNL.Text, txtMaNL.Text, txtNhaCC.Text, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaTien.Text)))
                {
                    MessageBox.Show("Nguyên liệu đã được cập nhật");
                    btSave.Enabled = false;
                    frm_NguyenLieu_Load(sender, e);
                    macDinh();
                }
                else
                {
                    MessageBox.Show("Nguyên liệu chưa được cập nhật");
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string id = dgvNguyenLieu.Rows[i].Cells[0].Value.ToString(); 
                if (nguyenlieuControl.xoa_NguyenLieu(id))
                {
                    MessageBox.Show("Nguyên liệu đã được xóa");
                }
                else
                {
                    MessageBox.Show("Nguyên liệu chưa được xóa");
                }
                frm_NguyenLieu_Load(sender, e);
                macDinh();
            }
        }
    }
}
