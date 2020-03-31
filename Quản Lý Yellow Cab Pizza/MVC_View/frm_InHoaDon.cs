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
    public partial class frm_InHoaDon : Form
    {
        public frm_InHoaDon()
        {
            InitializeComponent();
        }
        inHoaDon_Model inHoaDonModel = new inHoaDon_Model();
        inHoaDon_Control inHoaDonControl = new inHoaDon_Control();

        private void frm_InHoaDon_Load(object sender, EventArgs e)
        {
                DataTable dt;
                dt = inHoaDonModel.load_ChiTietNhapHang();
                inHoaDon nl = new inHoaDon();
                nl.SetDataSource(dt);
                crystalReportViewer1.ReportSource = nl;
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = inHoaDonModel.load_ChiTietNhapHang();
            inHoaDonControl.xoa_ChiTietNguyenLieu(dt.Rows[0][0].ToString());
            frm_NhapHang nhapHang = new frm_NhapHang();
            nhapHang.Show();
            this.Close();
        }
    }
}
