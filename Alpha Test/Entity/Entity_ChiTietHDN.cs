using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_ChiTietHDN
    {
        private string MaHDN;
        private string MaSach;
        private string SoLuong;
        private string DonGia;

        public Entity_ChiTietHDN(string maHDN, string maSach, string soLuong, string donGia)
        {
            MaHDN1 = maHDN;
            MaSach1 = maSach;
            SoLuong1 = soLuong;
            DonGia1 = donGia;
        }

        public string MaHDN1 { get => MaHDN; set => MaHDN = value; }
        public string MaSach1 { get => MaSach; set => MaSach = value; }
        public string SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public string DonGia1 { get => DonGia; set => DonGia = value; }
    }
}
