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
    public partial class frm_ReportNhapHang : Form
    {
        public frm_ReportNhapHang()
        {
            InitializeComponent();
        }

        reportNhapHang_Model reportNhapHangModel = new reportNhapHang_Model();
        reportNhapHang_Control reportNhapHangControl = new reportNhapHang_Control();

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhapExel.DataSource = reportNhapHangModel.load_ReportNhapHang(dpTuNgay.Value.ToString("yyyy-MM-dd"), dpDenNgay.Value.ToString("yyyy-MM-dd"));
            
        }

        private void frm_ReportNhapHang_Load(object sender, EventArgs e)
        {
            dpDenNgay.Value = DateTime.Now;
            dpTuNgay.Value = DateTime.Now;
        }

        private void btXuatExel_Click(object sender, EventArgs e)
        {
            //khởi tạo exel
            Microsoft.Office.Interop.Excel._Application exApp = new Microsoft.Office.Interop.Excel.Application();
            //khởi tạo workbool
            Microsoft.Office.Interop.Excel._Workbook workBook = exApp.Workbooks.Add(Type.Missing);
            //khởi tạo worksheet
            Microsoft.Office.Interop.Excel._Worksheet workSheet = null;
            workSheet = workBook.Sheets["Sheet1"];
            workSheet = workBook.ActiveSheet;
            exApp.Visible = true;
            //đổ dữ liệu vào sheet
            exApp.Range["D1:D1"].Font.Bold = true;
            exApp.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exApp.Range["D1:D1"].Font.Size = 16;
            

            exApp.Range["A3:I3"].ColumnWidth = 16;//kích thướt dòng
            exApp.Range["A3:I3"].Font.Bold = true;


            workSheet.Cells[1, 4] = "BẢNG BÁO CÁO NHẬP HÀNG";
            workSheet.Cells[3, 1] = "Số Hóa Đơn";
            workSheet.Cells[3, 2] = "Mã Nguyên Liệu";
            workSheet.Cells[3, 3] = "Tên Nguyên Liệu";
            workSheet.Cells[3, 4] = "Mã Loại NL";
            workSheet.Cells[3, 5] = "Nhà Cung Cấp";
            workSheet.Cells[3, 6] = "Ngày Nhập";
            workSheet.Cells[3, 7] = "Số Lượng";
            workSheet.Cells[3, 8] = "Giá Tiền";
            workSheet.Cells[3, 9] = "Thành Tiền";
            
            for (int i = 0; i< dgvNhapExel.RowCount ; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    workSheet.Cells[i + 4, j+1] = dgvNhapExel.Rows[i].Cells[j].Value;
                }
            }


        }
    }
}
