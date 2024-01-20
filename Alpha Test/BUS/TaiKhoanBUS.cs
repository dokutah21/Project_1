using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class TaiKhoanBUS
    {
        AccountAccess accountAccess = new AccountAccess();
        public string CheckLogin(TaiKhoan taikhoan)
        {
            if (taikhoan.sTaiKhoan == "")
            {
                return "requied_taikhoan";
            }
            if (taikhoan.sMatKhau == "")
            {
                return "requied_password";
            }

            string info = accountAccess.CheckLogin(taikhoan);
            return info;
        }
    }
}