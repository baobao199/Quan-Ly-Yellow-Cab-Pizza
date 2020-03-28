namespace Quản_Lý_Yellow_Cab_Pizza.MVC_View
{
    partial class frm_GioLamViec
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btMacDinh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNV = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btMacDinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNamSinh);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(407, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 32;
            // 
            // btMacDinh
            // 
            this.btMacDinh.BackColor = System.Drawing.Color.Transparent;
            this.btMacDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMacDinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMacDinh.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources._default;
            this.btMacDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMacDinh.Location = new System.Drawing.Point(372, 75);
            this.btMacDinh.Margin = new System.Windows.Forms.Padding(6);
            this.btMacDinh.Name = "btMacDinh";
            this.btMacDinh.Size = new System.Drawing.Size(95, 45);
            this.btMacDinh.TabIndex = 42;
            this.btMacDinh.Text = "Mặc Định";
            this.btMacDinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMacDinh.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số Giờ Làm Việc:";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNamSinh.Location = new System.Drawing.Point(109, 100);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(164, 20);
            this.txtNamSinh.TabIndex = 28;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.save;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(479, 76);
            this.btSave.Margin = new System.Windows.Forms.Padding(6);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(71, 44);
            this.btSave.TabIndex = 41;
            this.btSave.Text = "Lưu";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ngày Làm Việc:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenNV.Location = new System.Drawing.Point(109, 62);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(164, 20);
            this.txtTenNV.TabIndex = 26;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(109, 26);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(164, 20);
            this.txtMaNV.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên nhân viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachNV);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 246);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSachNV
            // 
            this.dgvDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNV.Location = new System.Drawing.Point(0, 19);
            this.dgvDanhSachNV.Name = "dgvDanhSachNV";
            this.dgvDanhSachNV.Size = new System.Drawing.Size(617, 221);
            this.dgvDanhSachNV.TabIndex = 0;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Gold;
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSua.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(486, 171);
            this.btSua.Margin = new System.Windows.Forms.Padding(6);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 52);
            this.btSua.TabIndex = 40;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Gold;
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(384, 171);
            this.btThem.Margin = new System.Windows.Forms.Padding(6);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 52);
            this.btThem.TabIndex = 39;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // frm_GioLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 483);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(657, 522);
            this.Name = "frm_GioLamViec";
            this.ShowInTaskbar = false;
            this.Text = "Giờ Làm Việc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachNV;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btMacDinh;
        private System.Windows.Forms.Button btSave;
    }
}