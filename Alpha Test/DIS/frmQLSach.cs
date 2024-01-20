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
    public partial class frmQuanLySach : Form
    {
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtMaTL.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                txtTrangThai.Text = row.Cells[4].Value.ToString();
                dtpNgayTao.Text = row.Cells[5].Value.ToString();
            }
            catch { }
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = SachBUS.GetAllSach();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string masach = txtMaSach.Text;
                string tensach = txtTenSach.Text;
                string matl = txtMaTL.Text;
                string dongia = txtDonGia.Text;
                string trangthai = txtTrangThai.Text;
                DateTime ngaytao = dtpNgayTao.Value;
                Entity_QLSach sach = new Entity_QLSach(masach, tensach, matl, dongia, trangthai, ngaytao);
                SachBUS.InsertSach(sach);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSach.DataSource = SachBUS.GetAllSach();
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
                string masach = txtMaSach.Text;
                string tensach = txtTenSach.Text;
                string matl = txtMaTL.Text;
                string dongia = txtDonGia.Text;
                string trangthai = txtTrangThai.Text;
                DateTime ngaytao = dtpNgayTao.Value;
                Entity_QLSach sach = new Entity_QLSach(masach, tensach, matl, dongia, trangthai, ngaytao);
                SachBUS.UpdateSach(sach);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSach.DataSource = SachBUS.GetAllSach();
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
                string masach = txtMaSach.Text;
                string tensach = txtTenSach.Text;
                string matl = txtMaTL.Text;
                string dongia = txtDonGia.Text;
                string trangthai = txtTrangThai.Text;
                DateTime ngaytao = dtpNgayTao.Value;
                Entity_QLSach sach = new Entity_QLSach(masach, tensach, matl, dongia, trangthai, ngaytao);
                SachBUS.DeleteSach(masach);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSach.DataSource = SachBUS.GetAllSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvSach, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelQLSach");
            DialogResult dg = MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK) { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            (dgvSach.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("TenSach like '%" + txtTimKiem.Text + "%'");
        }
    }
}
