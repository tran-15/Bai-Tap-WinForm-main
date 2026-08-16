namespace BaiTapThietKe1
{
    partial class frmBai4
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.listBoxHienThi = new System.Windows.Forms.ListBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số cần tìm: ";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(585, 57);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(116, 22);
            this.txtSo.TabIndex = 1;
            // 
            // listBoxHienThi
            // 
            this.listBoxHienThi.FormattingEnabled = true;
            this.listBoxHienThi.ItemHeight = 16;
            this.listBoxHienThi.Location = new System.Drawing.Point(74, 63);
            this.listBoxHienThi.Name = "listBoxHienThi";
            this.listBoxHienThi.Size = new System.Drawing.Size(289, 292);
            this.listBoxHienThi.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(585, 117);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(118, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm số";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.ForeColor = System.Drawing.Color.Red;
            this.lbKetQua.Location = new System.Drawing.Point(592, 214);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(14, 20);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = ".";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.listBoxHienThi);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai4";
            this.Text = "Tìm số trong danh sách";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ListBox listBoxHienThi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKetQua;
    }
}