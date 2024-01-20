using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_HDN
    {
        private string MaHDN;
        private DateTime NgayNhap;
        private DateTime NgayNhan;
        private string MaNV;
        private string MaKho;
        private string TrangThai;
        private string TongTien;

        public Entity_HDN(string maHDN, DateTime ngayNhap, DateTime ngayNhan, string maNV, string maKho, string trangThai, string tongTien)
        {
            MaHDN = maHDN;
            NgayNhap = ngayNhap;
            NgayNhan = ngayNhan;
            MaNV = maNV;
            MaKho = maKho;
            TrangThai = trangThai;
            TongTien = tongTien;
        }

        public string MaHDN1 { get => MaHDN; set => MaHDN = value; }
        public DateTime NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public DateTime NgayNhan1 { get => NgayNhan; set => NgayNhan = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaKho1 { get => MaKho; set => MaKho = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
        public string TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
