using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_HDX
    {
        private string MaHDX;
        private DateTime NgayXuat;
        private DateTime NgayNhan;
        private string MaNV;
        private string MaKho;
        private string TrangThai;
        private string TongTien;

        public Entity_HDX(string maHDX, DateTime ngayXuat, DateTime ngayNhan, string maNV, string maKho, string trangThai, string tongTien)
        {
            MaHDX = maHDX;
            NgayXuat = ngayXuat;
            NgayNhan = ngayNhan;
            MaNV = maNV;
            MaKho = maKho;
            TrangThai = trangThai;
            TongTien = tongTien;
        }

        public string MaHDX1 { get => MaHDX; set => MaHDX = value; }
        public DateTime NgayXuat1 { get => NgayXuat; set => NgayXuat = value; }
        public DateTime NgayNhan1 { get => NgayNhan; set => NgayNhan = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaKho1 { get => MaKho; set => MaKho = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
        public string TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
