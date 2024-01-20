using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_ChiTietHDX
    {
        private string MaHDX;
        private string MaSach;
        private string SoLuong;
        private string DonGia;

        public Entity_ChiTietHDX(string maHDX, string maSach, string soLuong, string donGia)
        {
            MaHDX = maHDX;
            MaSach = maSach;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public string MaHDX1 { get => MaHDX; set => MaHDX = value; }
        public string MaSach1 { get => MaSach; set => MaSach = value; }
        public string SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public string DonGia1 { get => DonGia; set => DonGia = value; }
    }
}
