using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinForm2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

   

          
  

        private void lbHienThi_TextChanged(object sender, EventArgs e)
        {
            //string ten = tbTen.Text;
            //string ho = tbHo.Text;
            //string s;
            //HamXuLy.NoiChuoi(ho, ten, out s);
            //lbHienThi.Text = "Họ và tên: " + s;
        }

        private void lbHienThi_Click(object sender, EventArgs e)
        {
            string ten = tbTen.Text;
            string ho = tbHo.Text;
            string s;
            XuLy.NoiChuoi(ho, ten, out s);
            lbHienThi.Text = "Họ và tên: " + s;
        }


        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbSoN.Text);

            long kq = XuLy.GiaThua(n);
            lbKetQua.Text = kq.ToString();

        }
    }
}
