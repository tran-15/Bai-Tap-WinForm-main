namespace BaiTapWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.rdChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTienMat = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbTienThanhToan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn giá:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(200, 300);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(111, 23);
            this.btnTinhTien.TabIndex = 1;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // rdChuyenKhoan
            // 
            this.rdChuyenKhoan.AutoSize = true;
            this.rdChuyenKhoan.Location = new System.Drawing.Point(31, 33);
            this.rdChuyenKhoan.Name = "rdChuyenKhoan";
            this.rdChuyenKhoan.Size = new System.Drawing.Size(113, 20);
            this.rdChuyenKhoan.TabIndex = 2;
            this.rdChuyenKhoan.TabStop = true;
            this.rdChuyenKhoan.Text = "Chuyển khoản";
            this.rdChuyenKhoan.UseVisualStyleBackColor = true;
            this.rdChuyenKhoan.UseWaitCursor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(200, 90);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 22);
            this.txtSoLuong.TabIndex = 3;
            // 
            // cbTenHang
            // 
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Items.AddRange(new object[] {
            "Chuột ",
            "Máy in ",
            "Bàn phím "});
            this.cbTenHang.Location = new System.Drawing.Point(200, 52);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(121, 24);
            this.cbTenHang.TabIndex = 4;
            this.cbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbTenHang_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTienMat);
            this.groupBox1.Controls.Add(this.rdChuyenKhoan);
            this.groupBox1.Location = new System.Drawing.Point(200, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức thanh toán";
            this.groupBox1.UseWaitCursor = true;
            // 
            // rdTienMat
            // 
            this.rdTienMat.AutoSize = true;
            this.rdTienMat.Location = new System.Drawing.Point(31, 59);
            this.rdTienMat.Name = "rdTienMat";
            this.rdTienMat.Size = new System.Drawing.Size(80, 20);
            this.rdTienMat.TabIndex = 2;
            this.rdTienMat.TabStop = true;
            this.rdTienMat.Text = "Tiền mặt";
            this.rdTienMat.UseVisualStyleBackColor = true;
            this.rdTienMat.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số tiền thanh toán: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(200, 126);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // lbTienThanhToan
            // 
            this.lbTienThanhToan.AutoSize = true;
            this.lbTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienThanhToan.Location = new System.Drawing.Point(204, 397);
            this.lbTienThanhToan.Name = "lbTienThanhToan";
            this.lbTienThanhToan.Size = new System.Drawing.Size(14, 20);
            this.lbTienThanhToan.TabIndex = 0;
            this.lbTienThanhToan.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTenHang);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.lbTienThanhToan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.RadioButton rdChuyenKhoan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdTienMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbTienThanhToan;
    }
}