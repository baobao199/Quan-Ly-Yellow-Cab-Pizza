namespace Quản_Lý_Yellow_Cab_Pizza.MVC_View
{
    partial class frm_NguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NguyenLieu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btMacDinh = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLoaiNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNCC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btMacDinh);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaLoaiNL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nguyên liệu";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(413, 31);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(146, 20);
            this.txtNCC.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nhà cung cấp: ";
            // 
            // btMacDinh
            // 
            this.btMacDinh.BackColor = System.Drawing.Color.Transparent;
            this.btMacDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMacDinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMacDinh.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources._default;
            this.btMacDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMacDinh.Location = new System.Drawing.Point(379, 100);
            this.btMacDinh.Margin = new System.Windows.Forms.Padding(6);
            this.btMacDinh.Name = "btMacDinh";
            this.btMacDinh.Size = new System.Drawing.Size(95, 45);
            this.btMacDinh.TabIndex = 38;
            this.btMacDinh.Text = "Mặc Định";
            this.btMacDinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMacDinh.UseVisualStyleBackColor = false;
            this.btMacDinh.Click += new System.EventHandler(this.btMacDinh_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.save;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(486, 101);
            this.btSave.Margin = new System.Windows.Forms.Padding(6);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(95, 44);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Lưu";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(413, 62);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(146, 20);
            this.txtGiaTien.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Giá tiền:";
            // 
            // txtMaLoaiNL
            // 
            this.txtMaLoaiNL.Location = new System.Drawing.Point(132, 114);
            this.txtMaLoaiNL.Name = "txtMaLoaiNL";
            this.txtMaLoaiNL.Size = new System.Drawing.Size(146, 20);
            this.txtMaLoaiNL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã loại NL:";
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(132, 70);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(146, 20);
            this.txtTenNL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên nguyên liệu:";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(132, 31);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(146, 20);
            this.txtMaNL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã nguyên liệu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tìm kiếm nhà cung cấp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(268, 261);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(145, 20);
            this.txtTimKiem.TabIndex = 30;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Gold;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThoat.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(434, 189);
            this.btThoat.Margin = new System.Windows.Forms.Padding(6);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(90, 52);
            this.btThoat.TabIndex = 33;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Gold;
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.delete1;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(332, 189);
            this.btXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 52);
            this.btXoa.TabIndex = 32;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Gold;
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSua.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(230, 189);
            this.btSua.Margin = new System.Windows.Forms.Padding(6);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 52);
            this.btSua.TabIndex = 34;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Gold;
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(128, 189);
            this.btThem.Margin = new System.Windows.Forms.Padding(6);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 52);
            this.btThem.TabIndex = 29;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNguyenLieu);
            this.groupBox2.Location = new System.Drawing.Point(11, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 246);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nguyên liệu";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(0, 19);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.Size = new System.Drawing.Size(632, 221);
            this.dgvNguyenLieu.TabIndex = 50;
            this.dgvNguyenLieu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNguyenLieu_CellMouseClick);
            // 
            // frm_NguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(671, 600);
            this.Name = "frm_NguyenLieu";
            this.Text = "Nguyên liệu";
            this.Load += new System.EventHandler(this.frm_NguyenLieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btMacDinh;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLoaiNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
    }
}