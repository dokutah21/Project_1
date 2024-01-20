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
    public class KhoBUS
    {
        public static DataTable GetAllKho()
        {
            return DAL_Kho.getData();
        }

        public static void InsertKho (Entity_QuanLyKho kho)
        {
            DAL_Kho.InsertKho(kho);
        }

        public static void UpdateKho (Entity_QuanLyKho kho)
        {
            DAL_Kho.UpdateKho(kho);
        }

        public static void DeleteKho (string makho)
        {
            DAL_Kho.DeleteKho(makho);
        }
    }
}
