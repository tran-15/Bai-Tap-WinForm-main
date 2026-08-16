namespace BaiTapWinForm
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
            this.lbThongTinHangHoa = new System.Windows.Forms.Label();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbThongTinHangHoa
            // 
            this.lbThongTinHangHoa.AutoSize = true;
            this.lbThongTinHangHoa.Location = new System.Drawing.Point(235, 102);
            this.lbThongTinHangHoa.Name = "lbThongTinHangHoa";
            this.lbThongTinHangHoa.Size = new System.Drawing.Size(121, 16);
            this.lbThongTinHangHoa.TabIndex = 0;
            this.lbThongTinHangHoa.Text = "Thông tin hàng hóa";
            this.lbThongTinHangHoa.Click += new System.EventHandler(this.lbThongTinHangHoa_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Location = new System.Drawing.Point(141, 180);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(10, 16);
            this.lbThongBao.TabIndex = 1;
            this.lbThongBao.Text = ".";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.lbThongTinHangHoa);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongTinHangHoa;
        private System.Windows.Forms.Label lbThongBao;
    }
}