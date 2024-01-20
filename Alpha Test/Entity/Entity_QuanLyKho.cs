using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_QuanLyKho
    {
        private string MaKho;
        private string TenKho;
        private string DiaChi;
        private string MaNV;
        private string TrangThai;

        public Entity_QuanLyKho(string maKho, string tenKho, string diaChi, string maNV, string trangThai)
        {
            MaKho = maKho;
            TenKho = tenKho;
            DiaChi = diaChi;
            MaNV = maNV;
            TrangThai = trangThai;
        }

        public string MaKho1 { get => MaKho; set => MaKho = value; }
        public string TenKho1 { get => TenKho; set => TenKho = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
    }
}
