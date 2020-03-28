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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
        }
    }
}
