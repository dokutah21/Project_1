using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using Entity;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace DIS
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
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

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvHoaDonNhap.DataSource = HoaDonNhapBUS.GetAllHoaDonNhap();
            dgvChiTietHDN.DataSource = ChiTietNhapBUS.GetAllChiTietNhap();
        }

        private void dgvHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHoaDonNhap.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells[0].Value.ToString(); 
                dtpNgayNhap.Text = row.Cells[1].Value.ToString();
                dtpNgayNhan.Text = row.Cells[2].Value.ToString();
                txtMaNV.Text = row.Cells[3].Value.ToString();
                txtMaKho.Text = row.Cells[4].Value.ToString();
                txtTrangThai.Text = row.Cells[5].Value.ToString();
                txtTongTien.Text = row.Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            export2Excel(dgvHoaDonNhap, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelHDN");
            DialogResult dg = MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK) { }
        }

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdn = txtMaHoaDon.Text;
                DateTime ngaynhap = dtpNgayNhap.Value;
                DateTime ngaynhan = dtpNgayNhan.Value;
                string manv = txtMaNV.Text;
                string makho = txtMaKho.Text;
                string trangthai = txtTrangThai.Text;
                string tongtien = txtTongTien.Text;
                Entity_HDN hdn = new Entity_HDN(mahdn, ngaynhap, ngaynhan, manv, makho, trangthai, tongtien);
                HoaDonNhapBUS.InsertHDN(hdn);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHoaDonNhap.DataSource = HoaDonNhapBUS.GetAllHoaDonNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdn = txtMaHoaDon.Text;
                DateTime ngaynhap = dtpNgayNhap.Value;
                DateTime ngaynhan = dtpNgayNhan.Value;
                string manv = txtMaNV.Text;
                string makho = txtMaKho.Text;
                string trangthai = txtTrangThai.Text;
                string tongtien = txtTongTien.Text;
                Entity_HDN hdn = new Entity_HDN(mahdn, ngaynhap, ngaynhan, manv, makho, trangthai, tongtien);
                HoaDonNhapBUS.DeleteHDN(mahdn);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdn = txtMaHoaDon.Text;
                DateTime ngaynhap = dtpNgayNhap.Value;
                DateTime ngaynhan = dtpNgayNhan.Value;
                string manv = txtMaNV.Text;
                string makho = txtMaKho.Text;
                string trangthai = txtTrangThai.Text;
                string tongtien = txtTongTien.Text;
                Entity_HDN hdn = new Entity_HDN(mahdn, ngaynhap, ngaynhan, manv, makho, trangthai, tongtien);
                HoaDonNhapBUS.UpdateHDN(hdn);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHoaDonNhap.DataSource = HoaDonNhapBUS.GetAllHoaDonNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvChiTietHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvChiTietHDN.Rows[e.RowIndex];
                txtMHD.Text = row.Cells[0].Value.ToString(); ;
                txtMaSach.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdn = txtMHD.Text;
                string masach = txtMaSach.Text;
                string soluong = txtSoLuong.Text;
                string dongia = txtDonGia.Text;
                Entity_ChiTietHDN ctn = new Entity_ChiTietHDN(mahdn, masach, soluong, dongia);
                ChiTietNhapBUS.InsertChiTietNhap(ctn);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietHDN.DataSource = ChiTietNhapBUS.GetAllChiTietNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdn = txtMaHoaDon.Text;
                string masach = txtMaSach.Text;
                string soluong = txtSoLuong.Text;
                string dongia = txtDonGia.Text;
                Entity_ChiTietHDN ctn = new Entity_ChiTietHDN(mahdn, masach, soluong, dongia);
                ChiTietNhapBUS.DeleteChiTietNhap(mahdn);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietHDN.DataSource = ChiTietNhapBUS.GetAllChiTietNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdn = txtMaHoaDon.Text;
                string masach = txtMaSach.Text;
                string soluong = txtSoLuong.Text;
                string dongia = txtDonGia.Text;
                Entity_ChiTietHDN ctn = new Entity_ChiTietHDN(mahdn, masach, soluong, dongia);
                ChiTietNhapBUS.UpdateChiTietNhap(ctn);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietHDN.DataSource = ChiTietNhapBUS.GetAllChiTietNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvChiTietHDN, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelChiTietHDN");
            DialogResult dg = MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK) { }
        }

        private void dgvHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvHoaDonNhap.SelectedRows)
            {
                
            }
        }
    }
}
