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

namespace DIS
{
    public partial class frmDangNhap : Form
    {

        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBUS TKBUS = new TaiKhoanBUS();
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {   
            taikhoan.sTaiKhoan = txtTaiKhoan.Text;
            taikhoan.sMatKhau = txtMatKhau.Text;

            string getuser = TKBUS.CheckLogin(taikhoan);

            switch (getuser) //trả lại kết quả nếu nghiệp vụ không đúng
            {
                case "requied_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                case "requied_password":
                    MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            frmTrangChu f = new frmTrangChu();
            f.Show();
            this.Hide();
            
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
