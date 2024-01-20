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
    public class HoaDonNhapBUS
    {
        public static DataTable GetAllHoaDonNhap()
        {
            return DAL_HDN.getData();
        }

        public static void InsertHDN(Entity_HDN hdn)
        {
            DAL_HDN.InsertHDN(hdn);
        }
        public static void UpdateHDN(Entity_HDN hdn)
        {
            DAL_HDN.UpdateHDN(hdn);
        }
        public static void DeleteHDN(string mahdn)
        {
            DAL_HDN.DeleteHDN(mahdn);
        }  
    }
}
