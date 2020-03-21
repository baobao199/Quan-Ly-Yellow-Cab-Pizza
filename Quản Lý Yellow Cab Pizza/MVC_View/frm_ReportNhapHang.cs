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
    public partial class frm_ReportNhapHang : Form
    {
        public frm_ReportNhapHang()
        {
            InitializeComponent();
        }

        reportNhapHang_Model reportNhapHangModel = new reportNhapHang_Model();

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhapExel.DataSource = reportNhapHangModel.load_ReportNhapHang(dpTuNgay.Value.ToString("yyyy-MM-dd"), dpDenNgay.Value.ToString("yyyy-MM-dd"));
        }

        private void frm_ReportNhapHang_Load(object sender, EventArgs e)
        {
            dpDenNgay.Value = DateTime.Now;
            dpTuNgay.Value = DateTime.Now;
        }
    }
}
