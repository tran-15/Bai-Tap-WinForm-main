namespace BaiTapThietKe1
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbChonMauXe = new System.Windows.Forms.GroupBox();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lbDonViTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbChonMauXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 259);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grbChonMauXe
            // 
            this.grbChonMauXe.Controls.Add(this.rdDo);
            this.grbChonMauXe.Controls.Add(this.rdTrang);
            this.grbChonMauXe.Controls.Add(this.rdXanh);
            this.grbChonMauXe.Location = new System.Drawing.Point(374, 34);
            this.grbChonMauXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbChonMauXe.Name = "grbChonMauXe";
            this.grbChonMauXe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbChonMauXe.Size = new System.Drawing.Size(150, 161);
            this.grbChonMauXe.TabIndex = 1;
            this.grbChonMauXe.TabStop = false;
            this.grbChonMauXe.Text = "Chọn màu xe";
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.Location = new System.Drawing.Point(28, 75);
            this.rdDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(39, 17);
            this.rdDo.TabIndex = 0;
            this.rdDo.TabStop = true;
            this.rdDo.Text = "Đỏ";
            this.rdDo.UseVisualStyleBackColor = true;
            this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
            // 
            // rdTrang
            // 
            this.rdTrang.AutoSize = true;
            this.rdTrang.Location = new System.Drawing.Point(28, 112);
            this.rdTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.Size = new System.Drawing.Size(53, 17);
            this.rdTrang.TabIndex = 0;
            this.rdTrang.TabStop = true;
            this.rdTrang.Text = "Trắng";
            this.rdTrang.UseVisualStyleBackColor = true;
            this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Location = new System.Drawing.Point(28, 38);
            this.rdXanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(50, 17);
            this.rdXanh.TabIndex = 0;
            this.rdXanh.TabStop = true;
            this.rdXanh.Text = "Xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(342, 208);
            this.lbDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(47, 13);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(388, 203);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(110, 20);
            this.txtDonGia.TabIndex = 3;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(337, 235);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(52, 13);
            this.lbSoLuong.TabIndex = 2;
            this.lbSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(388, 235);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(76, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(388, 266);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(93, 27);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lbDonViTien
            // 
            this.lbDonViTien.AutoSize = true;
            this.lbDonViTien.Location = new System.Drawing.Point(502, 208);
            this.lbDonViTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDonViTien.Name = "lbDonViTien";
            this.lbDonViTien.Size = new System.Drawing.Size(13, 13);
            this.lbDonViTien.TabIndex = 2;
            this.lbDonViTien.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng tiền thanh toán:";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(418, 323);
            this.lbSoTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(19, 20);
            this.lbSoTien.TabIndex = 2;
            this.lbSoTien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "$";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbDonViTien);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.grbChonMauXe);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBai1";
            this.Text = "Mua bán xe";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbChonMauXe.ResumeLayout(false);
            this.grbChonMauXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbChonMauXe;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.RadioButton rdTrang;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lbDonViTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label label1;
    }
}