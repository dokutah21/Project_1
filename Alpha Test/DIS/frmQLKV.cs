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
    public partial class frmQuanLyKhuVuc : Form
    {
        public frmQuanLyKhuVuc()
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            export2Excel(dgvKhuVuc, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelQLKhuVuc");
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

        private void dgvKhuVuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKhuVuc.Rows[e.RowIndex];
                txtMaKV.Text = row.Cells[0].Value.ToString();
                txtTenKV.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void frmQuanLyKhuVuc_Load(object sender, EventArgs e)
        {
            dgvKhuVuc.DataSource = KhuVucBUS.GetAllKhuVuc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string makv = txtMaKV.Text;
                string tenkv = txtTenKV.Text;
                string diachi = txtDiaChi.Text;
                Entity_KhuVuc khuvuc = new Entity_KhuVuc(makv, tenkv, diachi);
                KhuVucBUS.InsertKV(khuvuc);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvKhuVuc.DataSource = KhuVucBUS.GetAllKhuVuc();
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
                string makv = txtMaKV.Text;
                string tenkv = txtTenKV.Text;
                string diachi = txtDiaChi.Text;
                Entity_KhuVuc khuvuc = new Entity_KhuVuc(makv, tenkv, diachi);
                KhuVucBUS.UpdateKV(khuvuc);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvKhuVuc.DataSource = KhuVucBUS.GetAllKhuVuc();
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
                string makv = txtMaKV.Text;
                string tenkv = txtTenKV.Text;
                string diachi = txtDiaChi.Text;
                Entity_KhuVuc khuvuc = new Entity_KhuVuc(makv, tenkv, diachi);
                KhuVucBUS.DeleteKV(makv);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvKhuVuc.DataSource = KhuVucBUS.GetAllKhuVuc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            (dgvKhuVuc.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("MaKV like '%" + txtTimKiem.Text + "%'");
        }
    }
}
