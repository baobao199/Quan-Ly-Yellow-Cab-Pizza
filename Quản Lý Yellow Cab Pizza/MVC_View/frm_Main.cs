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

namespace Quản_Lý_Yellow_Cab_Pizza
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            
        }
        private void quảnLýNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_QuanLyNguyenLieu"))
            {
                frm_QuanLyNguyenLieu frm_QLNL = new frm_QuanLyNguyenLieu();
                frm_QLNL.MdiParent = this;
                frm_QLNL.Show();
            }
            else
            {
                ActiveChildForm("frm_QuanLyNguyenLieu");
            }
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void quảnLýLoạiNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_LoaiNguyenLieu"))
            {
                frm_LoaiNguyenLieu frm_LNL = new frm_LoaiNguyenLieu();
                frm_LNL.MdiParent = this;
                frm_LNL.Show();
            }
            else
            {
                ActiveChildForm("frm_LoaiNguyenLieu");
            }
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_NhaCungCap"))
            {
                frm_NhaCungCap frm_NCC = new frm_NhaCungCap();
                frm_NCC.MdiParent = this;
                frm_NCC.Show();
            }
            else
            {
                ActiveChildForm("frm_NhaCungCap");
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_NhanVien"))
            {
                frm_NhanVien frm_NV = new frm_NhanVien();
                frm_NV.MdiParent = this;
                frm_NV.Show();
            }
            else
            {
                ActiveChildForm("frm_NhanVien");
            }
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_NhapHang"))
            {
                frm_NhapHang frm_NH = new frm_NhapHang();
                frm_NH.MdiParent = this;
                frm_NH.Show();
            }
            else
            {
                ActiveChildForm("frm_NhapHang");
            }
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_XuatHang"))
            {
                frm_XuatHang frm_XH = new frm_XuatHang();
                frm_XH.MdiParent = this;
                frm_XH.Show();
            }
            else
            {
                ActiveChildForm("frm_XuatHang");
            }
        }

        private void báoCáoXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_ReportXuatHang"))
            {
                frm_ReportXuatHang frm_RXH = new frm_ReportXuatHang();
                frm_RXH.MdiParent = this;
                frm_RXH.Show();
            }
            else
            {
                ActiveChildForm("frm_ReportXuatHang");
            }
        }
        private void báoCáoNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_ReportNhapHang"))
            {
                frm_ReportNhapHang frm_RNH = new frm_ReportNhapHang();
                frm_RNH.MdiParent = this;
                frm_RNH.Show();
            }
            else
            {
                ActiveChildForm("frm_ReportNhapHang");
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_TaiKhoan"))
            {
                frm_TaiKhoan frm_TK = new frm_TaiKhoan();
                frm_TK.MdiParent = this;
                frm_TK.Show();
            }
            else
            {
                ActiveChildForm("frm_TaiKhoan");
            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_DangNhap frm_dangNhap = new frm_DangNhap();
            frm_dangNhap.Show();
        }

        private void nguyênLiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_NguyenLieu"))
            {
                frm_NguyenLieu frm_NL = new frm_NguyenLieu();
                frm_NL.MdiParent = this;
                frm_NL.Show();
            }
            else
            {
                ActiveChildForm("frm_NguyenLieu");
            }
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
