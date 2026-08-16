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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int so = int.Parse(tbNhapSo.Text);
            int ketqua;
            if (rdTong.Checked)
            {

                 XuLy.TinhTongN(so,out ketqua);
                lbKetQua.Text = ketqua.ToString();
            }
            else
            {
                XuLy.TinhGiaiThuaN(so, out ketqua);
                lbKetQua.Text = ketqua.ToString() ;
            }
               
               
        }
    }
}
