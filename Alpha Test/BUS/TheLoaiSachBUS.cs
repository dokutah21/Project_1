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
    public class TheLoaiSachBUS
    {
        public static DataTable GetAllTheLoaiSach()
        {
            return DAL_TheLoaiSach.getData();
        }

        public static void InsertTheLoaiSach(Entity_TLSach tlsach)
        {
            DAL_TheLoaiSach.InsertTheLoaiSach(tlsach);
        }

        public static void UpdateTheLoaiSach(Entity_TLSach tlsach)
        {
            DAL_TheLoaiSach.UpdateTheLoaiSach(tlsach);
        }

        public static void DeleteTheLoaiSach(string matl)
        {
            DAL_TheLoaiSach.DeleteTheLoaiSach(matl);
        }
    }
}
