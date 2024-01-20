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
using Entity;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace DIS
{
    public partial class frmHoaDonXuat : Form
    {
        public frmHoaDonXuat()
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

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            dgvHoaDonXuat.DataSource = HoaDonXuatBUS.GetAllHoaDonXuat();
            dgvChiTietHDX.DataSource = ChiTietXuatBUS.GetAllChiTietXuat();
        }

        private void dgvHoaDonXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHoaDonXuat.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells[0].Value.ToString();
                dtpNgayXuat.Text = row.Cells[1].Value.ToString();
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
            export2Excel(dgvHoaDonXuat, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelHDX");
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
                string mahdx = txtMaHoaDon.Text;
                DateTime ngayxuat = dtpNgayXuat.Value;
                DateTime ngaynhan = dtpNgayNhan.Value;
                string manv = txtMaNV.Text;
                string makho = txtMaKho.Text;
                string trangthai = txtTrangThai.Text;
                string tongtien = txtTongTien.Text;
                Entity_HDX hdx = new Entity_HDX(mahdx, ngayxuat, ngaynhan, manv, makho, trangthai, tongtien);
                HoaDonXuatBUS.InsertHDX(hdx);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHoaDonXuat.DataSource = HoaDonXuatBUS.GetAllHoaDonXuat();
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
                string mahdx = txtMaHoaDon.Text;
                DateTime ngayxuat = dtpNgayXuat.Value;
                DateTime ngaynhan = dtpNgayNhan.Value;
                string manv = txtMaNV.Text;
                string makho = txtMaKho.Text;
                string trangthai = txtTrangThai.Text;
                string tongtien = txtTongTien.Text;
                Entity_HDX hdx = new Entity_HDX(mahdx, ngayxuat, ngaynhan, manv, makho, trangthai, tongtien);
                HoaDonXuatBUS.DeleteHDX(mahdx);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHoaDonXuat.DataSource = HoaDonXuatBUS.GetAllHoaDonXuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdx = txtMaHoaDon.Text;
                DateTime ngayxuat = dtpNgayXuat.Value;
                DateTime ngaynhan = dtpNgayNhan.Value;
                string manv = txtMaNV.Text;
                string makho = txtMaKho.Text;
                string trangthai = txtTrangThai.Text;
                string tongtien = txtTongTien.Text;
                Entity_HDX hdx = new Entity_HDX(mahdx, ngayxuat, ngaynhan, manv, makho, trangthai, tongtien);
                HoaDonXuatBUS.UpdateHDX(hdx);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHoaDonXuat.DataSource = HoaDonXuatBUS.GetAllHoaDonXuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdx = txtMHD.Text;
                string masach = txtMaSach.Text;
                string soluong = txtSoLuong.Text;
                string dongia = txtDonGia.Text;
                Entity_ChiTietHDX ctx = new Entity_ChiTietHDX(mahdx, masach, soluong, dongia);
                ChiTietXuatBUS.InsertChiTietXuat(ctx);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietHDX.DataSource = ChiTietXuatBUS.GetAllChiTietXuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvChiTietHDX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvChiTietHDX.Rows[e.RowIndex];
                txtMHD.Text = row.Cells[0].Value.ToString(); ;
                txtMaSach.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdx = txtMHD.Text;
                string masach = txtMaSach.Text;
                string soluong = txtSoLuong.Text;
                string dongia = txtDonGia.Text;
                Entity_ChiTietHDX ctx = new Entity_ChiTietHDX(mahdx, masach, soluong, dongia);
                ChiTietXuatBUS.DeleteChiTietXuat(mahdx);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietHDX.DataSource = ChiTietXuatBUS.GetAllChiTietXuat();
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
                string mahdx = txtMHD.Text;
                string masach = txtMaSach.Text;
                string soluong = txtSoLuong.Text;
                string dongia = txtDonGia.Text;
                Entity_ChiTietHDX ctx = new Entity_ChiTietHDX(mahdx, masach, soluong, dongia);
                ChiTietXuatBUS.UpdateChiTietXuat(ctx);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietHDX.DataSource = ChiTietXuatBUS.GetAllChiTietXuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvChiTietHDX, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelChiTietHDX");
            DialogResult dg = MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK) { }
        }
    }
}
