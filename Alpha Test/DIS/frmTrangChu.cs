using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIS
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
                frmDangNhap f = new frmDangNhap();
                f.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            frm.ShowDialog();
            this.Hide();
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySach frm = new frmQuanLySach();
            frm.ShowDialog();
            this.Hide();
        }

        private void theLoaiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLoaiSach frm = new frmTheLoaiSach();
            frm.ShowDialog();
            this.Hide();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKho frm = new frmQuanLyKho();
            frm.ShowDialog();
            this.Hide();
        }

        private void khuVucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhuVuc frm = new frmQuanLyKhuVuc();
            frm.ShowDialog();
            this.Hide();
        }

        private void hoaDonToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap frm = new frmHoaDonNhap();
            frm.ShowDialog();
            this.Hide();
        }

        private void hoaĐonXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonXuat frm = new frmHoaDonXuat();
            frm.ShowDialog();
            this.Hide();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemSach frm = new frmTimKiemSach();
            frm.ShowDialog();
            this.Hide();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeBaoCao frm = new frmThongKeBaoCao();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
