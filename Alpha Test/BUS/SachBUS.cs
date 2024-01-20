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
    public class SachBUS
    {
        public static DataTable GetAllSach()
        {
            return DAL_Sach.getData();
        }

        public static void InsertSach(Entity_QLSach sach)
        {
            DAL_Sach.InsertSach(sach);
        }

        public static void UpdateSach(Entity_QLSach sach)
        {
            DAL_Sach.UpdateSach(sach);
        }

        public static void DeleteSach(string masach)
        {
            DAL_Sach.DeleteSach(masach);
        }
    }
}
