namespace BaiTapThietKe1
{
    partial class frmBai2
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
            this.panelDSHangHoa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.lbDSHangHoa = new System.Windows.Forms.ListBox();
            this.lbHangKhachMua = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.panelDSHangHoa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDSHangHoa
            // 
            this.panelDSHangHoa.Controls.Add(this.lbDSHangHoa);
            this.panelDSHangHoa.Controls.Add(this.label1);
            this.panelDSHangHoa.Controls.Add(this.btnChonHang);
            this.panelDSHangHoa.Location = new System.Drawing.Point(2, 1);
            this.panelDSHangHoa.Name = "panelDSHangHoa";
            this.panelDSHangHoa.Size = new System.Drawing.Size(388, 391);
            this.panelDSHangHoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hóa:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTongTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbHangKhachMua);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Location = new System.Drawing.Point(396, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 391);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các mặt hàng khách mua:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(203, 272);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(109, 23);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(265, 106);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(105, 23);
            this.btnChonHang.TabIndex = 0;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // lbDSHangHoa
            // 
            this.lbDSHangHoa.FormattingEnabled = true;
            this.lbDSHangHoa.ItemHeight = 16;
            this.lbDSHangHoa.Items.AddRange(new object[] {
            "Chuột ",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.lbDSHangHoa.Location = new System.Drawing.Point(40, 38);
            this.lbDSHangHoa.Name = "lbDSHangHoa";
            this.lbDSHangHoa.Size = new System.Drawing.Size(219, 212);
            this.lbDSHangHoa.TabIndex = 1;
            // 
            // lbHangKhachMua
            // 
            this.lbHangKhachMua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHangKhachMua.FormattingEnabled = true;
            this.lbHangKhachMua.ItemHeight = 16;
            this.lbHangKhachMua.Location = new System.Drawing.Point(134, 38);
            this.lbHangKhachMua.Name = "lbHangKhachMua";
            this.lbHangKhachMua.Size = new System.Drawing.Size(244, 210);
            this.lbHangKhachMua.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền thanh toán:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTongTien.Location = new System.Drawing.Point(259, 351);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(24, 25);
            this.lbTongTien.TabIndex = 2;
            this.lbTongTien.Text = "0";
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(19, 106);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(109, 23);
            this.btnBoHang.TabIndex = 0;
            this.btnBoHang.Text = "<Bỏ hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDSHangHoa);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panelDSHangHoa.ResumeLayout(false);
            this.panelDSHangHoa.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDSHangHoa;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDSHangHoa;
        private System.Windows.Forms.ListBox lbHangKhachMua;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBoHang;
    }
}