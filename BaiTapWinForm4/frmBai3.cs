using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinForm4
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

        private void rdXacNhan_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            bool gioitinh = rdNam.Checked;
            XuLy.ChaoHoi(hoten, gioitinh);  
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);

            int uscln = XuLy.TimUSCLN(so1, so2);
            lbKetQua.Text = uscln.ToString();

        }
    }
}
