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
    public class ChiTietXuatBUS
    {
        public static DataTable GetAllChiTietXuat()
        {
            return DAL_ChiTietXuat.getData();
        }

        public static void InsertChiTietXuat(Entity_ChiTietHDX ctx)
        {
            DAL_ChiTietXuat.InsertChiTietHDX(ctx);
        }
        public static void UpdateChiTietXuat(Entity_ChiTietHDX ctx)
        {
            DAL_ChiTietXuat.UpdateChiTietHDX(ctx);
        }
        public static void DeleteChiTietXuat(string mahdx)
        {
            DAL_ChiTietXuat.DeleteChiTietHDX(mahdx);
        }
    }
}
