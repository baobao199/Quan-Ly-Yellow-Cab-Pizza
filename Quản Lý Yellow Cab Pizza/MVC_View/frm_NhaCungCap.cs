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
using System.Data;
using System.Data.SqlClient;
using Quản_Lý_Yellow_Cab_Pizza.MVC_Control;

namespace Quản_Lý_Yellow_Cab_Pizza
{
    public partial class frm_NhaCungCap : Form
    {
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }

        nhaCungCap_Model nhaCungCapModel = new nhaCungCap_Model();
        nhaCungCap_Control nhaCungCapControl = new nhaCungCap_Control();
        int i;

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvDanhSachNCC.DataSource = nhaCungCapModel.load_Data();
            dgvDanhSachNCC.Columns["MaNhaCungCap"].Width = 110;
            dgvDanhSachNCC.Columns["TenNhaCungCap"].Width = 110;

            dgvDanhSachNCC.Columns[0].HeaderText = "Mã NCC";
            dgvDanhSachNCC.Columns[1].HeaderText = "Tên NCC";
            dgvDanhSachNCC.Columns[2].HeaderText = "Địa Chỉ";
            dgvDanhSachNCC.Columns[3].HeaderText = "Email";
            dgvDanhSachNCC.Columns[4].HeaderText = "Số Điện Thoại";
        }

        private void dgvDanhSachNCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgvDanhSachNCC.CurrentRow.Index;
            txtMaNCC.Text = dgvDanhSachNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvDanhSachNCC.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDanhSachNCC.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dgvDanhSachNCC.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvDanhSachNCC.Rows[i].Cells[4].Value.ToString();
        }
        private void macDinh()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string id = dgvDanhSachNCC.Rows[i].Cells[0].Value.ToString();
                if (nhaCungCapControl.xoa_NhaCungCap(id))
                {
                    MessageBox.Show("Nhà cung cấp đã được xóa");
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp chưa được xóa");
                }
                frm_NhaCungCap_Load(sender, e);
                macDinh();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if (nhaCungCapControl.them_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text))
                {
                    MessageBox.Show("Nhà cung cấp đã được thêm");
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp không được thêm");
                }
            }
            frm_NhaCungCap_Load(sender, e);
            macDinh();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (nhaCungCapControl.sua_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text))
                {
                    MessageBox.Show("Nhà cung cấp đã được cập nhật");
                    btSave.Enabled = false;
                    frm_NhaCungCap_Load(sender, e);
                    macDinh();
                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp không được sửa");
                }
            }
        }

        private void btMacDinh_Click(object sender, EventArgs e)
        {
            macDinh();
            frm_NhaCungCap_Load(sender, e);
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                frm_NhaCungCap_Load(sender, e);
            }
            else
            {
                dgvDanhSachNCC.DataSource = nhaCungCapModel.timKiem_Load(txtTimKiem.Text.Trim());
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            int i;
            i = dgvDanhSachNCC.CurrentRow.Index;
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string id = dgvDanhSachNCC.Rows[i].Cells[0].Value.ToString();
                if (nhaCungCapControl.xoa_NhaCungCap(id) == true)
                {
                    MessageBox.Show("Nhà cung cấp đã được xóa");
                }
                else if (nhaCungCapControl.xoa_NhaCungCap(id) == false)
                {
                    MessageBox.Show("Nhà cung cấp đang được dùng");
                    MessageBox.Show("Nhà cung cấp chưa được xóa");
                }
                frm_NhaCungCap_Load(sender, e);
                macDinh();
            }
        }
    }
}
