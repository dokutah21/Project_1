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
    public class KhuVucBUS
    {
        public static DataTable GetAllKhuVuc()
        {
            return DAL_KhuVuc.getData();
        }

        public static void InsertKV(Entity_KhuVuc kv)
        {
            DAL_KhuVuc.InsertKV(kv);
        }

        public static void UpdateKV(Entity_KhuVuc kv)
        {
            DAL_KhuVuc.UpdateKV(kv);
        }

        public static void DeleteKV(string makv)
        {
            DAL_KhuVuc.DeleteKV(makv);
        }
    }
}
