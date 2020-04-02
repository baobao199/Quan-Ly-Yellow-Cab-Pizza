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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        quanLyNhanVien_Model quanLyNguyenLieuModel = new quanLyNhanVien_Model();
        quanLyNhanVien_Control quanLyNguyenLieuControl = new quanLyNhanVien_Control();

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            dgvDanhSachNV.DataSource = quanLyNguyenLieuModel.load_Data();
            dgvDanhSachNV.Columns["MaNhanVien"].Width = 120;
            dgvDanhSachNV.Columns["TenNhanVien"].Width = 150;

            dgvDanhSachNV.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvDanhSachNV.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvDanhSachNV.Columns[2].HeaderText = "Năm Sinh";
            dgvDanhSachNV.Columns[3].HeaderText = "Địa Chỉ";
            dgvDanhSachNV.Columns[4].HeaderText = "Số Điện Thoại";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtNamSinh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if (quanLyNguyenLieuControl.them_NhanVien(txtMaNV.Text, txtTenNV.Text, Int32.Parse(txtNamSinh.Text), txtDiaChi.Text, txtSDT.Text))
                {
                    MessageBox.Show("Nhân viên đã được thêm");
                }
                else
                {
                    MessageBox.Show("Nhân viên không được thêm");
                }
            }
            frm_NhanVien_Load(sender, e);
            macDinh();
        }
        private void macDinh()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTimKiem.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtMaNV.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || txtNamSinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (quanLyNguyenLieuControl.sua_NhanVien(txtMaNV.Text, txtTenNV.Text, Int32.Parse(txtNamSinh.Text), txtDiaChi.Text, txtSDT.Text))
                {
                    MessageBox.Show("Nhân viên đã được cập nhật");
                    btSave.Enabled = false;
                    frm_NhanVien_Load(sender, e);
                    macDinh();
                }
                else
                {
                    MessageBox.Show("Nhân viên chưa được cập nhật");
                }
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                frm_NhanVien_Load(sender, e);
            }
            else
            {
                dgvDanhSachNV.DataSource = quanLyNguyenLieuModel.timKiem_Load(txtTimKiem.Text.Trim());
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvDanhSachNV.CurrentRow.Index;
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string id = dgvDanhSachNV.Rows[i].Cells[0].Value.ToString();
                if (quanLyNguyenLieuControl.xoa_NhanVien(id))
                {
                    MessageBox.Show("Nhân viên đã được xóa");
                }
                else
                {
                    MessageBox.Show("Nhân viên chưa được xóa");
                }
                frm_NhanVien_Load(sender, e);
                macDinh();
            }
        }

        private void btMacDinh_Click(object sender, EventArgs e)
        {
            macDinh();
        }

        private void dgvDanhSachNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvDanhSachNV.CurrentRow.Index;
            txtMaNV.Text = dgvDanhSachNV.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvDanhSachNV.Rows[i].Cells[1].Value.ToString();
            txtNamSinh.Text = dgvDanhSachNV.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDanhSachNV.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvDanhSachNV.Rows[i].Cells[4].Value.ToString();
        }
    }
}
