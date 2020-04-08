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
    public partial class frm_inHoaDonXuat : Form
    {
        public frm_inHoaDonXuat()
        {
            InitializeComponent();
        }
        inHoaDon_Control inHoaDonControl = new inHoaDon_Control();
        inHoaDon_Model inHoaDonModel = new inHoaDon_Model();
        private void inHoaDonXuat_Load(object sender, EventArgs e)
        {
            DataTable dt;
            dt = inHoaDonModel.load_ChiTietXuatHang();
            inHoaDonXuat nl = new inHoaDonXuat();
            nl.SetDataSource(dt);
            crystalReportViewer1.ReportSource = nl;
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = inHoaDonModel.load_ChiTietXuatHang();
            inHoaDonControl.xoa_ChiTietXuatHang(dt.Rows[0][0].ToString());
            frm_XuatHang xuatHang = new frm_XuatHang();
            xuatHang.Show();
            this.Close();
        }
    }
}
