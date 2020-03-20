namespace Quản_Lý_Yellow_Cab_Pizza
{
    partial class frm_XuatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_XuatHang));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSLXuat = new System.Windows.Forms.TextBox();
            this.txtSLCon = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtLoaiNL = new System.Windows.Forms.TextBox();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btTaoHD = new System.Windows.Forms.Button();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNguyenLieuXuat = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSLXuat);
            this.groupBox2.Controls.Add(this.txtSLCon);
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtGiaTien);
            this.groupBox2.Controls.Add(this.txtLoaiNL);
            this.groupBox2.Controls.Add(this.txtNhaCC);
            this.groupBox2.Controls.Add(this.txtTenNL);
            this.groupBox2.Controls.Add(this.txtMaNL);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(264, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 179);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nguyên liệu";
            // 
            // txtSLXuat
            // 
            this.txtSLXuat.Location = new System.Drawing.Point(410, 61);
            this.txtSLXuat.Name = "txtSLXuat";
            this.txtSLXuat.Size = new System.Drawing.Size(164, 20);
            this.txtSLXuat.TabIndex = 37;
            // 
            // txtSLCon
            // 
            this.txtSLCon.Location = new System.Drawing.Point(410, 96);
            this.txtSLCon.Name = "txtSLCon";
            this.txtSLCon.Size = new System.Drawing.Size(164, 20);
            this.txtSLCon.TabIndex = 36;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Gold;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThoat.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(685, 96);
            this.btThoat.Margin = new System.Windows.Forms.Padding(6);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(90, 52);
            this.btThoat.TabIndex = 34;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Gold;
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(583, 22);
            this.btThem.Margin = new System.Windows.Forms.Padding(6);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 52);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Gold;
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.delete1;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(685, 22);
            this.btXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 52);
            this.btXoa.TabIndex = 33;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Số lượng còn";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(410, 25);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(164, 20);
            this.txtGiaTien.TabIndex = 25;
            // 
            // txtLoaiNL
            // 
            this.txtLoaiNL.Location = new System.Drawing.Point(144, 136);
            this.txtLoaiNL.Name = "txtLoaiNL";
            this.txtLoaiNL.Size = new System.Drawing.Size(164, 20);
            this.txtLoaiNL.TabIndex = 24;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(144, 96);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(164, 20);
            this.txtNhaCC.TabIndex = 23;
            // 
            // txtTenNL
            // 
            this.txtTenNL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenNL.Location = new System.Drawing.Point(144, 61);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(164, 20);
            this.txtTenNL.TabIndex = 22;
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(144, 25);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(164, 20);
            this.txtMaNL.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số lượng xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã nguyên liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên nguyên liệu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giá tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Loại nguyên liệu";
            // 
            // btTaoHD
            // 
            this.btTaoHD.BackColor = System.Drawing.Color.Gold;
            this.btTaoHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTaoHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTaoHD.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.nhap;
            this.btTaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaoHD.Location = new System.Drawing.Point(71, 95);
            this.btTaoHD.Margin = new System.Windows.Forms.Padding(6);
            this.btTaoHD.Name = "btTaoHD";
            this.btTaoHD.Size = new System.Drawing.Size(132, 52);
            this.btTaoHD.TabIndex = 31;
            this.btTaoHD.Text = "Tạo hóa đơn mới";
            this.btTaoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaoHD.UseVisualStyleBackColor = false;
            this.btTaoHD.Click += new System.EventHandler(this.btTaoHoaDon_Click);
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Location = new System.Drawing.Point(134, 41);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(116, 20);
            this.txtSoHoaDon.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Số hóa đơn xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvNguyenLieuXuat);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 332);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nguyên liệu nhập";
            // 
            // dgvNguyenLieuXuat
            // 
            this.dgvNguyenLieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNguyenLieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieuXuat.Location = new System.Drawing.Point(6, 19);
            this.dgvNguyenLieuXuat.Name = "dgvNguyenLieuXuat";
            this.dgvNguyenLieuXuat.Size = new System.Drawing.Size(1028, 307);
            this.dgvNguyenLieuXuat.TabIndex = 0;
            // 
            // frm_XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1064, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btTaoHD);
            this.Controls.Add(this.txtSoHoaDon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1080, 580);
            this.Name = "frm_XuatHang";
            this.Text = "Xuất hàng";
            this.Load += new System.EventHandler(this.frm_XuatHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtLoaiNL;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTaoHD;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSLXuat;
        private System.Windows.Forms.TextBox txtSLCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNguyenLieuXuat;
    }
}