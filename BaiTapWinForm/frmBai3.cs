using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinForm
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


        private void btnCong_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            double s;
            XuLy.CongHaiSo(a, b,out s);
            lbKetQua.Text = s.ToString();

        }

        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) 
            {
                e.Handled = true;
            }
        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnTongDay_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int tong = XuLy.TongDaySo(n);
            lbTongDay.Text = tong.ToString();
        }

        private void txtSoN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
