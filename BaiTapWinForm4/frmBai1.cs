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
    public partial class frmBai1 : Form
    {
        public SanPham sanPham;
        public frmBai1()
        {
            InitializeComponent();
            sanPham = new SanPham();

            dgvHienThi.Columns.Add("MaSanPham", "Mã Sản Phẩm");
            dgvHienThi.Columns.Add("TenSanPham", "Tên Sản Phẩm");
            dgvHienThi.Columns.Add("LoaiSanPham", "Loại Sản Phẩm");
            dgvHienThi.Columns.Add("NgaySanXuat", "Ngày Sản Xuất");
            dgvHienThi.Columns.Add("NamHetHan", "Năm Hết Hạn");
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string loai = txtLoai.Text;
            DateTime ngay = dtpNgay.Value;
            
            sanPham.SetSanPham(ma, ten, loai, ngay);

            dgvHienThi.Rows.Add(sanPham.MaSanPham, sanPham.TenSanPham, sanPham.LoaiSanPham, sanPham.NgaySanXuat.ToShortDateString(), sanPham.NamHetHan());
            string kq = sanPham.HienThi();

            MessageBox.Show(kq, "Thông tin sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
