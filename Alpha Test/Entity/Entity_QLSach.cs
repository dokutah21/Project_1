using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_QLSach
    {
        private string MaSach;
        private string TenSach;
        private string MaTL;
        private string DonGia;
        private string TrangThai;
        private DateTime NgayTao;

        public Entity_QLSach(string maSach, string tenSach, string maTL, string donGia, string trangThai, DateTime ngayTao)
        {
            MaSach = maSach;
            TenSach = tenSach;
            MaTL = maTL;
            DonGia = donGia;
            TrangThai = trangThai;
            NgayTao = ngayTao;
        }

        public string MaSach1 { get => MaSach; set => MaSach = value; }
        public string TenSach1 { get => TenSach; set => TenSach = value; }
        public string MaTL1 { get => MaTL; set => MaTL = value; }
        public string DonGia1 { get => DonGia; set => DonGia = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
        public DateTime NgayTao1 { get => NgayTao; set => NgayTao = value; }
    }
}
