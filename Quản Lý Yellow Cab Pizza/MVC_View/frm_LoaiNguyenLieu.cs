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
using System.Data.SqlClient;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Control;

namespace Quản_Lý_Yellow_Cab_Pizza
{
    public partial class frm_LoaiNguyenLieu : Form
    {
        public frm_LoaiNguyenLieu()
        {
            InitializeComponent();
        }

        int i;
        loaiNguyenLieu_Model loaiNguyenLieuModel = new loaiNguyenLieu_Model();
        loaiNguyenLieu_Control loaiNguyenLieuControl = new loaiNguyenLieu_Control();

        private void frm_LoaiNguyenLieu_Load(object sender, EventArgs e)
        {
            dgvLoaiNL.DataSource = loaiNguyenLieuModel.load_Data();
            dgvLoaiNL.Columns["MaLoaiNguyenLieu"].Width = 187;
            dgvLoaiNL.Columns["TenLoaiNguyenLieu"].Width = 187;
            dgvLoaiNL.Columns[0].HeaderText = "Mã Loại Nguyên Liệu";
            dgvLoaiNL.Columns[1].HeaderText = "Tên Loại Nguyên Liệu";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void macDinh()
        {
            txtMaLoaiNL.Text = "";
            txtTenLoaiNL.Text = "";
            txtTimKiem.Text = "";
        }

        private void dgvLoaiNL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgvLoaiNL.CurrentRow.Index;
            txtMaLoaiNL.Text = dgvLoaiNL.Rows[i].Cells[0].Value.ToString();
            txtTenLoaiNL.Text = dgvLoaiNL.Rows[i].Cells[1].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (loaiNguyenLieuControl.xoa_LoaiNguyenLieu(txtMaLoaiNL.Text))
                {
                    MessageBox.Show("Nguyên liệu đã được xóa");
                }
                else
                {
                    MessageBox.Show("Nguyên liệu chưa được xóa");
                }
                frm_LoaiNguyenLieu_Load(sender, e);
                macDinh();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(txtTenLoaiNL.Text == "" || txtMaLoaiNL.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if(loaiNguyenLieuControl.them_LoaiNguyenLieu(txtMaLoaiNL.Text, txtTenLoaiNL.Text))
                {
                    MessageBox.Show("Loại nguyên liệu đã được thêm");
                }
                else
                {
                    MessageBox.Show("Loại nguyên liệu không được thêm");
                }
            }
           
            frm_LoaiNguyenLieu_Load(sender, e);
            macDinh();

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiNL.Text == "" || txtTenLoaiNL.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (loaiNguyenLieuControl.sua_LoaiNguyenLieu(txtMaLoaiNL.Text, txtTenLoaiNL.Text))
                {
                    MessageBox.Show("Nguyên liệu đã được cập nhật");
                    btSave.Enabled = false;
                    frm_LoaiNguyenLieu_Load(sender, e);
                    macDinh();
                }
                else
                {
                    MessageBox.Show("Nguyên liệu chưa được cập nhật");
                }
            }
        }

        private void btMacDinh_Click(object sender, EventArgs e)
        {
            frm_LoaiNguyenLieu_Load(sender, e);
            macDinh();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                frm_LoaiNguyenLieu_Load(sender, e);
            }
            else
            {
                dgvLoaiNL.DataSource = loaiNguyenLieuModel.timKiem_Load(txtTimKiem.Text.Trim());
            }
        }
    }
}
