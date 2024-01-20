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
    public partial class frmQuanLyKho : Form
    {
        public frmQuanLyKho()
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

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            dgvQuanLyKho.DataSource = KhoBUS.GetAllKho();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            export2Excel(dgvQuanLyKho, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelQLKho");
            DialogResult dg = MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK){ }
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

        private void dgvQuanLyKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvQuanLyKho.Rows[e.RowIndex];
                txtMaKho.Text = row.Cells[0].Value.ToString();
                txtTenKho.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtMaNV.Text = row.Cells[3].Value.ToString();
                txtTrangThai.Text = row.Cells[4].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string makho = txtMaKho.Text;
                string tenkho = txtTenKho.Text;
                string diachi = txtDiaChi.Text;
                string manv = txtMaNV.Text;
                string trangthai = txtTrangThai.Text;
                Entity_QuanLyKho kho = new Entity_QuanLyKho(makho, tenkho, diachi, manv, trangthai);
                KhoBUS.InsertKho(kho);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvQuanLyKho.DataSource = KhoBUS.GetAllKho();
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
                string makho = txtMaKho.Text;
                string tenkho = txtTenKho.Text;
                string diachi = txtDiaChi.Text;
                string manv = txtMaNV.Text;
                string trangthai = txtTrangThai.Text;
                Entity_QuanLyKho kho = new Entity_QuanLyKho(makho, tenkho, diachi, manv, trangthai);
                KhoBUS.UpdateKho(kho);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvQuanLyKho.DataSource = KhoBUS.GetAllKho();
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
                string makho = txtMaKho.Text;
                string tenkho = txtTenKho.Text;
                string diachi = txtDiaChi.Text;
                string manv = txtMaNV.Text;
                string trangthai = txtTrangThai.Text;
                Entity_QuanLyKho kho = new Entity_QuanLyKho(makho, tenkho, diachi, manv, trangthai);
                KhoBUS.DeleteKho(makho);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvQuanLyKho.DataSource = KhoBUS.GetAllKho();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            (dgvQuanLyKho.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("MaKho like '%" + txtTimKiem.Text + "%'");
        }
    }
}
