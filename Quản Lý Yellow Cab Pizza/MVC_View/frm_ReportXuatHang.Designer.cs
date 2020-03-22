namespace Quản_Lý_Yellow_Cab_Pizza
{
    partial class frm_ReportXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportXuatHang));
            this.dpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXuatExel = new System.Windows.Forms.Button();
            this.dpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvXuatExel = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatExel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpTuNgay
            // 
            this.dpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTuNgay.Location = new System.Drawing.Point(308, 39);
            this.dpTuNgay.Margin = new System.Windows.Forms.Padding(6);
            this.dpTuNgay.Name = "dpTuNgay";
            this.dpTuNgay.Size = new System.Drawing.Size(139, 20);
            this.dpTuNgay.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXuatExel);
            this.groupBox1.Controls.Add(this.dpDenNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.dpTuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 192);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btXuatExel
            // 
            this.btXuatExel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btXuatExel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXuatExel.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.exel;
            this.btXuatExel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXuatExel.Location = new System.Drawing.Point(526, 99);
            this.btXuatExel.Margin = new System.Windows.Forms.Padding(6);
            this.btXuatExel.Name = "btXuatExel";
            this.btXuatExel.Size = new System.Drawing.Size(129, 64);
            this.btXuatExel.TabIndex = 13;
            this.btXuatExel.Text = "Xuất Exel";
            this.btXuatExel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXuatExel.UseVisualStyleBackColor = false;
            // 
            // dpDenNgay
            // 
            this.dpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDenNgay.Location = new System.Drawing.Point(592, 40);
            this.dpDenNgay.Margin = new System.Windows.Forms.Padding(6);
            this.dpDenNgay.Name = "dpDenNgay";
            this.dpDenNgay.Size = new System.Drawing.Size(139, 20);
            this.dpDenNgay.TabIndex = 11;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Image = global::Quản_Lý_Yellow_Cab_Pizza.Properties.Resources.find;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(355, 99);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(129, 64);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvXuatExel
            // 
            this.dgvXuatExel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuatExel.Location = new System.Drawing.Point(6, 19);
            this.dgvXuatExel.Name = "dgvXuatExel";
            this.dgvXuatExel.Size = new System.Drawing.Size(949, 296);
            this.dgvXuatExel.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvXuatExel);
            this.groupBox2.Location = new System.Drawing.Point(6, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 321);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xuất";
            // 
            // frm_ReportXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(979, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(995, 600);
            this.Name = "frm_ReportXuatHang";
            this.Text = "frm_ReportXuatHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatExel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpDenNgay;
        private System.Windows.Forms.DataGridView dgvXuatExel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXuatExel;
    }
}