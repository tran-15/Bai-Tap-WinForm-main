namespace BaiThucHanh2
{
    partial class MainForm
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
            this.grbChonGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.grbChonMau = new System.Windows.Forms.GroupBox();
            this.rdMauXanh = new System.Windows.Forms.RadioButton();
            this.rdMauDo = new System.Windows.Forms.RadioButton();
            this.btnToMau = new System.Windows.Forms.Button();
            this.txtHopMau = new System.Windows.Forms.TextBox();
            this.grbChonGioiTinh.SuspendLayout();
            this.grbChonMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChonGioiTinh
            // 
            this.grbChonGioiTinh.Controls.Add(this.rdNu);
            this.grbChonGioiTinh.Controls.Add(this.rdNam);
            this.grbChonGioiTinh.Location = new System.Drawing.Point(283, 86);
            this.grbChonGioiTinh.Name = "grbChonGioiTinh";
            this.grbChonGioiTinh.Size = new System.Drawing.Size(200, 100);
            this.grbChonGioiTinh.TabIndex = 0;
            this.grbChonGioiTinh.TabStop = false;
            this.grbChonGioiTinh.Text = "Chọn giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(44, 22);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(44, 57);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // grbChonMau
            // 
            this.grbChonMau.Controls.Add(this.rdMauXanh);
            this.grbChonMau.Controls.Add(this.btnToMau);
            this.grbChonMau.Controls.Add(this.rdMauDo);
            this.grbChonMau.Location = new System.Drawing.Point(283, 240);
            this.grbChonMau.Name = "grbChonMau";
            this.grbChonMau.Size = new System.Drawing.Size(280, 100);
            this.grbChonMau.TabIndex = 0;
            this.grbChonMau.TabStop = false;
            this.grbChonMau.Text = "Chọn màu";
            // 
            // rdMauXanh
            // 
            this.rdMauXanh.AutoSize = true;
            this.rdMauXanh.Location = new System.Drawing.Point(44, 57);
            this.rdMauXanh.Name = "rdMauXanh";
            this.rdMauXanh.Size = new System.Drawing.Size(85, 20);
            this.rdMauXanh.TabIndex = 1;
            this.rdMauXanh.Text = "Màu xanh";
            this.rdMauXanh.UseVisualStyleBackColor = true;
            // 
            // rdMauDo
            // 
            this.rdMauDo.AutoSize = true;
            this.rdMauDo.Checked = true;
            this.rdMauDo.Location = new System.Drawing.Point(44, 22);
            this.rdMauDo.Name = "rdMauDo";
            this.rdMauDo.Size = new System.Drawing.Size(73, 20);
            this.rdMauDo.TabIndex = 0;
            this.rdMauDo.TabStop = true;
            this.rdMauDo.Text = "Màu đỏ";
            this.rdMauDo.UseVisualStyleBackColor = true;
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(182, 45);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(75, 23);
            this.btnToMau.TabIndex = 2;
            this.btnToMau.Text = "Tô màu";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // txtHopMau
            // 
            this.txtHopMau.Location = new System.Drawing.Point(630, 240);
            this.txtHopMau.Multiline = true;
            this.txtHopMau.Name = "txtHopMau";
            this.txtHopMau.ReadOnly = true;
            this.txtHopMau.Size = new System.Drawing.Size(158, 100);
            this.txtHopMau.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHopMau);
            this.Controls.Add(this.grbChonMau);
            this.Controls.Add(this.grbChonGioiTinh);
            this.Name = "MainForm";
            this.Text = "Bài 2";
            this.grbChonGioiTinh.ResumeLayout(false);
            this.grbChonGioiTinh.PerformLayout();
            this.grbChonMau.ResumeLayout(false);
            this.grbChonMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChonGioiTinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.GroupBox grbChonMau;
        private System.Windows.Forms.Button btnToMau;
        private System.Windows.Forms.RadioButton rdMauXanh;
        private System.Windows.Forms.RadioButton rdMauDo;
        private System.Windows.Forms.TextBox txtHopMau;
    }
}

