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
    public partial class frmTheLoaiSach : Form
    {

        public frmTheLoaiSach()
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
            export2Excel(dgvTheLoaiSach, @"D:\1. Document for Year 2\Đồ Án 1\", "xuatfileExcelTLSach");
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string matl = txtMaTL.Text;
                string tentl = txtTenTL.Text;
                Entity_TLSach tlsach = new Entity_TLSach(matl,tentl);
                TheLoaiSachBUS.InsertTheLoaiSach(tlsach);
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTheLoaiSach.DataSource = TheLoaiSachBUS.GetAllTheLoaiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTheLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTheLoaiSach.Rows[e.RowIndex];
                txtMaTL.Text = row.Cells[0].Value.ToString();
                txtTenTL.Text = row.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void frmTheLoaiSach_Load(object sender, EventArgs e)
        {
            dgvTheLoaiSach.DataSource = TheLoaiSachBUS.GetAllTheLoaiSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string matl = txtMaTL.Text;
                string tentl = txtTenTL.Text;
                Entity_TLSach tlsach = new Entity_TLSach(matl, tentl);
                TheLoaiSachBUS.UpdateTheLoaiSach(tlsach);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTheLoaiSach.DataSource = TheLoaiSachBUS.GetAllTheLoaiSach();
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
                string matl = txtMaTL.Text;
                string tentl = txtTenTL.Text;
                Entity_TLSach tlsach = new Entity_TLSach(matl, tentl);
                TheLoaiSachBUS.DeleteTheLoaiSach(matl);
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTheLoaiSach.DataSource = TheLoaiSachBUS.GetAllTheLoaiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            (dgvTheLoaiSach.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("MaTL like '%" + txtTimKiem.Text + "%'");
        }
    }
}
