using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DataTable = System.Data.DataTable;

namespace DIS
{
    public partial class frmTimKiemSach : Form
    {
        public frmTimKiemSach()
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

        private void dgvTimKiemSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTimKiemSach.Rows[e.RowIndex];
            }
            catch { }
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            dgvTimKiemSach.DataSource = TimKiemSachBUS.GetAllTimKiemSach();
        }

        

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            (dgvTimKiemSach.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("TenSach like '%" + txtTimKiem.Text + "%'");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
