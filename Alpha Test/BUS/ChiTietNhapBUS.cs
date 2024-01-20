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
    public class ChiTietNhapBUS
    {
        public static DataTable GetAllChiTietNhap()
        {
            return DAL_ChiTietNhap.getData();
        }

        public static void InsertChiTietNhap(Entity_ChiTietHDN ctn)
        {
            DAL_ChiTietNhap.InsertChiTietHDN(ctn);
        }
        public static void UpdateChiTietNhap(Entity_ChiTietHDN ctn)
        {
            DAL_ChiTietNhap.UpdateChiTietHDN(ctn);
        }
        public static void DeleteChiTietNhap(string mahdn)
        {
            DAL_ChiTietNhap.DeleteChiTietHDN(mahdn);
        }
    }
}
