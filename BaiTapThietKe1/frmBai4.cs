using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKe1
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int so;
            for (int i = 1; i <= 10; i++)
            {
                so = random.Next(1, 100);
                listBoxHienThi.Items.Add(so);
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);

            foreach (int so in listBoxHienThi.Items)
            {
                if (so == soCanTim)
                {
                    lbKetQua.Text = "Tìm thấy";
                    break;
                }
                lbKetQua.Text = " Không tìm thấy!";
            }
             
                
        }
    }
}
