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
    public class NhanVienBUS
    {
        public static DataTable GetAllNhanVien()
        {
            return DAL_NhanVien.getData();
        }

        public static void InsertNhanVien(Entity_QLNV nv)
        {
            DAL_NhanVien.InsertNV(nv);
        }

        public static void UpdateNhanVien(Entity_QLNV nv)
        {
            DAL_NhanVien.UpdateNV(nv);
        }

        public static void DeleteNhanVien(string manv)
        {
            DAL_NhanVien.DeleteNV(manv);
        }
    }
}
