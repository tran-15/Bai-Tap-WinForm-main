namespace BaiTapWinForm
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
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.btnTongDay = new System.Windows.Forms.Button();
            this.lbTongDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(375, 81);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(113, 22);
            this.txtSoB.TabIndex = 1;
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSoB_TextChanged);
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoB_KeyPress);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(534, 80);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "=";
            this.btnKetQua.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cộng 2 số:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(648, 81);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(13, 20);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = ".";
            this.lbKetQua.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(534, 80);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "=";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click_1);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(179, 85);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(113, 22);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cộng số n: ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(202, 205);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(113, 22);
            this.txtSoN.TabIndex = 1;
            this.txtSoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoN_KeyPress);
            // 
            // btnTongDay
            // 
            this.btnTongDay.Location = new System.Drawing.Point(354, 204);
            this.btnTongDay.Name = "btnTongDay";
            this.btnTongDay.Size = new System.Drawing.Size(75, 23);
            this.btnTongDay.TabIndex = 2;
            this.btnTongDay.Text = "=";
            this.btnTongDay.UseVisualStyleBackColor = true;
            this.btnTongDay.Click += new System.EventHandler(this.btnTongDay_Click);
            // 
            // lbTongDay
            // 
            this.lbTongDay.AutoSize = true;
            this.lbTongDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDay.Location = new System.Drawing.Point(484, 204);
            this.lbTongDay.Name = "lbTongDay";
            this.lbTongDay.Size = new System.Drawing.Size(13, 20);
            this.lbTongDay.TabIndex = 0;
            this.lbTongDay.Text = ".";
            this.lbTongDay.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTongDay);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.lbTongDay);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.Button btnTongDay;
        private System.Windows.Forms.Label lbTongDay;
    }
}