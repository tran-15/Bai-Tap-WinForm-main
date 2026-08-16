namespace BaiTapWinForm2
{
    partial class frmBai3
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
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.lbHienThi = new System.Windows.Forms.Label();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoN = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(113, 60);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(100, 22);
            this.tbTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập họ:";
            // 
            // tbHo
            // 
            this.tbHo.Location = new System.Drawing.Point(113, 93);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(100, 22);
            this.tbHo.TabIndex = 1;
            // 
            // lbHienThi
            // 
            this.lbHienThi.AutoSize = true;
            this.lbHienThi.Location = new System.Drawing.Point(277, 93);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(67, 16);
            this.lbHienThi.TabIndex = 0;
            this.lbHienThi.Text = "Họ và tên:";
            this.lbHienThi.TextChanged += new System.EventHandler(this.lbHienThi_TextChanged);
            this.lbHienThi.Click += new System.EventHandler(this.lbHienThi_Click);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(315, 293);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(93, 22);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "=";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tính giai thừa n:";
            // 
            // tbSoN
            // 
            this.tbSoN.Location = new System.Drawing.Point(168, 293);
            this.tbSoN.Name = "tbSoN";
            this.tbSoN.Size = new System.Drawing.Size(100, 22);
            this.tbSoN.TabIndex = 1;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(447, 299);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(10, 16);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = " ";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.tbSoN);
            this.Controls.Add(this.tbHo);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.Label lbHienThi;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoN;
        private System.Windows.Forms.Label lbKetQua;
    }
}