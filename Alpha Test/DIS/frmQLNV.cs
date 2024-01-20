using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
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

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            export2Excel(dgvNhanVien, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelQLNV");
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
                string manv = txtMaNV.Text;
                string hoten = txtHoTen.Text;
                string quoctich = txtQuocTich.Text;
                string dantoc = txtDanToc.Text;
                string gtnam = rbtNam.Text;
                string gtnu = rbtNu.Text;
                DateTime ngaysinh = dtpNgaySinh.Value;
                string chucvu = txtChucVu.Text;
                string quequan = txtQueQuan.Text;
                string sodienthoai = txtSDT.Text;
                string cccd = txtCCCD.Text;
                string email = txtEmail.Text;
                string diachi = txtDiaChi.Text;
                string makv = txtMaKV.Text;
                Entity_QLNV nhanvien = new Entity_QLNV(manv, hoten, quoctich, dantoc, gtnam, gtnu, ngaysinh, chucvu, quequan, sodienthoai, cccd, email, diachi, makv);
                NhanVienBUS.InsertNhanVien(nhanvien);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtQuocTich.Text = row.Cells[2].Value.ToString();
                txtDanToc.Text = row.Cells[3].Value.ToString();
                rbtNu.Text = row.Cells[4].Value.ToString();
                dtpNgaySinh.Text = row.Cells[5].Value.ToString();
                txtChucVu.Text = row.Cells[6].Value.ToString();
                txtQueQuan.Text = row.Cells[7].Value.ToString();
                txtSDT.Text = row.Cells[8].Value.ToString();
                txtCCCD.Text = row.Cells[9].Value.ToString();
                txtEmail.Text = row.Cells[10].Value.ToString();
                txtDiaChi.Text = row.Cells[11].Value.ToString();
                txtMaKV.Text = row.Cells[12].Value.ToString();
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = txtMaNV.Text;
                string hoten = txtHoTen.Text;
                string quoctich = txtQuocTich.Text;
                string dantoc = txtDanToc.Text;
                string gtnam = rbtNam.Text;
                string gtnu = rbtNu.Text;
                DateTime ngaysinh = dtpNgaySinh.Value;
                string chucvu = txtChucVu.Text;
                string quequan = txtQueQuan.Text;
                string sodienthoai = txtSDT.Text;
                string cccd = txtCCCD.Text;
                string email = txtEmail.Text;
                string diachi = txtDiaChi.Text;
                string makv = txtMaKV.Text;
                Entity_QLNV nhanvien = new Entity_QLNV(manv, hoten, quoctich, dantoc, gtnam, gtnu, ngaysinh, chucvu, quequan, sodienthoai, cccd, email, diachi, makv);
                NhanVienBUS.UpdateNhanVien(nhanvien);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
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
                string manv = txtMaNV.Text;
                string hoten = txtHoTen.Text;
                string quoctich = txtQuocTich.Text;
                string dantoc = txtDanToc.Text;
                string gtnam = rbtNam.Text;
                string gtnu = rbtNu.Text;
                DateTime ngaysinh = dtpNgaySinh.Value;
                string chucvu = txtChucVu.Text;
                string quequan = txtQueQuan.Text;
                string sodienthoai = txtSDT.Text;
                string cccd = txtCCCD.Text;
                string email = txtEmail.Text;
                string diachi = txtDiaChi.Text;
                string makv = txtMaKV.Text;
                Entity_QLNV nhanvien = new Entity_QLNV(manv, hoten, quoctich, dantoc, gtnam, gtnu, ngaysinh, chucvu, quequan, sodienthoai, cccd, email, diachi, makv);
                NhanVienBUS.DeleteNhanVien(manv);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("HoTen like '%" + txtTimKiem.Text + "%'");
        }

        private void lbNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
