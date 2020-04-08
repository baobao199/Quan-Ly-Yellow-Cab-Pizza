namespace Quản_Lý_Yellow_Cab_Pizza.MVC_View
{
    partial class frm_inHoaDonXuat
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btTroVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1005, 394);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // btTroVe
            // 
            this.btTroVe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btTroVe.Location = new System.Drawing.Point(889, 406);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(96, 37);
            this.btTroVe.TabIndex = 2;
            this.btTroVe.Text = "Trở về";
            this.btTroVe.UseVisualStyleBackColor = false;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // inHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.crystalReportViewer1);
            this.MinimumSize = new System.Drawing.Size(1022, 489);
            this.Name = "inHoaDonXuat";
            this.Text = "inHoaDonXuat";
            this.Load += new System.EventHandler(this.inHoaDonXuat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btTroVe;
    }
}