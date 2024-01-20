using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace BUS
{
    public class TimKiemSachBUS
    {
        public static DataTable GetAllTimKiemSach()
        {
            return DAL_TimKiemSach.getData();
        }
    }
}
