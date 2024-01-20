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
    public class HoaDonXuatBUS
    {
        public static DataTable GetAllHoaDonXuat()
        {
            return DAL_HDX.getData();
        }

        public static void InsertHDX(Entity_HDX hdx)
        {
            DAL_HDX.InsertHDX(hdx);
        }

        public static void UpdateHDX(Entity_HDX hdx)
        {
            DAL_HDX.UpdateHDX(hdx);
        }

        public static void DeleteHDX(string mahdx)
        {
            DAL_HDX.DeleteHDX(mahdx);
        }
    }
}
