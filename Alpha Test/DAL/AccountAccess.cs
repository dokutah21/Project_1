using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class AccountAccess : DatabaseAccess
    {
        public string CheckLogin(TaiKhoan taikhoan)
        {
            string info = CheckLoginEntity(taikhoan);
            return info;
        }
    }
}
