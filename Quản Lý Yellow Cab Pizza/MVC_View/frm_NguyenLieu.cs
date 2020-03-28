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
    public partial class frm_NguyenLieu : Form
    {
        public frm_NguyenLieu()
        {
            InitializeComponent();
        }
        nguyenLieu_Control nguyenLieuControl = new nguyenLieu_Control();
        nguyenLieu_Model nguyenLieuModel = new nguyenLieu_Model();

        private void frm_NguyenLieu_Load(object sender, EventArgs e)
        {
            dgvNguyenLieu.DataSource = nguyenLieuModel.load_Data();

            dgvNguyenLieu.Columns["MaNguyenLieu"].Width = 110;
            dgvNguyenLieu.Columns["TenNguyenLieu"].Width = 110;
            dgvNguyenLieu.Columns["MaLoaiNguyenLieu"].Width = 130;
            dgvNguyenLieu.Columns["MaNhaCungCap"].Width = 130;
            dgvNguyenLieu.Columns["GiaTien"].Width = 110;

            dgvNguyenLieu.Columns[0].HeaderText = "Mã nguyên liệu";
            dgvNguyenLieu.Columns[1].HeaderText = "Tên nguyên liệu";
            dgvNguyenLieu.Columns[2].HeaderText = "Mã loại nguyên liệu";
            dgvNguyenLieu.Columns[3].HeaderText = "Mã nhà cung cấp";
            dgvNguyenLieu.Columns[4].HeaderText = "Giá tiền";
        }

        private void dgvNguyenLieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNguyenLieu.CurrentRow.Index;
            txtMaNL.Text = dgvNguyenLieu.Rows[i].Cells[0].Value.ToString();
            txtTenNL.Text = dgvNguyenLieu.Rows[i].Cells[1].Value.ToString();
            txtMaLoaiNL.Text = dgvNguyenLieu.Rows[i].Cells[2].Value.ToString();
            txtNCC.Text = dgvNguyenLieu.Rows[i].Cells[3].Value.ToString();
            txtGiaTien.Text = dgvNguyenLieu.Rows[i].Cells[4].Value.ToString();
        }
        private void macDinh()
        {
            txtTenNL.Text = "";
            txtMaNL.Text = "";
            txtMaLoaiNL.Text = "";
            txtNCC.Text = "";
            txtGiaTien.Text = "";
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            int i;
            i = dgvNguyenLieu.CurrentRow.Index;
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string id = dgvNguyenLieu.Rows[i].Cells[0].Value.ToString();
                if (nguyenLieuControl.xoa_NguyenLieu(id))
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

        private void btThem_Click_1(object sender, EventArgs e)
        {
            if (txtMaNL.Text == "" || txtTenNL.Text == "" || txtMaLoaiNL.Text == "" || txtNCC.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if (nguyenLieuControl.them_NguyenLieu(txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNCC.Text, Int32.Parse(txtGiaTien.Text)))
                {
                    MessageBox.Show("Nguyên liệu đã được thêm");
                }
                else
                {
                    MessageBox.Show("Nguyên liệu không được thêm");
                }
            }
            frm_NguyenLieu_Load(sender, e);
            macDinh();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void btMacDinh_Click(object sender, EventArgs e)
        {
            macDinh();
            frm_NguyenLieu_Load(sender, e);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text == "" || txtTenNL.Text == "" || txtMaLoaiNL.Text == "" || txtNCC.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (nguyenLieuControl.sua_NguyenLieu(txtMaNL.Text, txtTenNL.Text, txtMaLoaiNL.Text, txtNCC.Text, Int32.Parse( txtGiaTien.Text)))
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
    }
}
