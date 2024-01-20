using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace DIS
{
    public partial class frmThongKeBaoCao : Form
    {
        public frmThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
                frmTrangChu f = new frmTrangChu();
                f.Show();
            }
        }

        private void frmThongKeBaoCao_Load(object sender, EventArgs e)
        {
            dgvThongKeNhap.DataSource = HoaDonNhapBUS.GetAllHoaDonNhap();
            dgvThongKeXuat.DataSource = HoaDonXuatBUS.GetAllHoaDonXuat();
        }

        private void TongDoanhThuNhap()
        {
            double sum = 0;
            for (int i = 0; i < dgvThongKeNhap.Rows.Count; i++)
            {
                if (dgvThongKeNhap.Rows[i].Cells[6].Value != null)
                {
                    double cellValue;
                    if (double.TryParse(dgvThongKeNhap.Rows[i].Cells[6].Value.ToString(), out cellValue))
                    {
                        sum += cellValue;
                    }
                }
            }
            txtTongDoanhThuNhap.Text = sum.ToString();
        }

        private void btnTongDoanhThuNhap_Click(object sender, EventArgs e)
        {
            TongDoanhThuNhap();
        }

        private void btnTimKiemNhap_Click(object sender, EventArgs e)
        {
            (dgvThongKeNhap.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("MaKho like '%" + txtTimKiemNhap.Text + "%'");
        }

        private void TongDoanhThuXuat()
        {
            double sum = 0;
            for (int i = 0; i < dgvThongKeXuat.Rows.Count; i++)
            {
                if (dgvThongKeXuat.Rows[i].Cells[6].Value != null)
                {
                    double cellValue;
                    if (double.TryParse(dgvThongKeXuat.Rows[i].Cells[6].Value.ToString(), out cellValue))
                    {
                        sum += cellValue;
                    }
                }
            }
            txtTongDoanhThuXuat.Text = sum.ToString();
        }

        private void btnTongDoanhThuXuat_Click(object sender, EventArgs e)
        {
            TongDoanhThuXuat();
        }

        private void btnTimKiemXuat_Click(object sender, EventArgs e)
        {
            (dgvThongKeXuat.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("MaKho like '%" + txtTimKiemXuat.Text + "%'");
        }
    }
}
