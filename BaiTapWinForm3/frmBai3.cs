using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinForm3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            XuLy.TachChuoi(hoTen, out string ho, out string ten);

            txtHo.Text = ho;
            txtTen.Text = ten;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbKetQua_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);

            bool kq = XuLy.ThuTu(so1, so2);
            if (kq)
                lbKetQua.Text = "Đây là 2 số nguyên liên tiếp";
            else
                lbKetQua.Text = "Không phải 2 số nguyên liên tiếp";
        }
    }
    
}
