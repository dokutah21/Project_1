using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_QLNV
    {
        private string MaNV;
        private string HoTen;
        private string QuocTich;
        private string DanToc;
        private string GioiTinh;
        private DateTime NgaySinh;
        private string ChucVu;
        private string QueQuan;
        private string SoDienThoai;
        private string CCCD;
        private string Email;
        private string DiaChiHienTai;
        private string MaKV;

        public Entity_QLNV(string manv, string hoten, string quoctich, string dantoc, string gioitinh, DateTime ngaysinh, string chucvu, string quequan, string sodienthoai, string cccd, string email, string diachi, string makv)
        {
            MaNV = manv;
            HoTen = hoten;
            QuocTich = quoctich;
            DanToc = dantoc;
            GioiTinh = gioitinh;
            NgaySinh = ngaysinh;
            ChucVu = chucvu;
            QueQuan = quequan;
            SoDienThoai = sodienthoai;
            CCCD = cccd;
            Email = email;
            MaKV = makv;
        }

        public Entity_QLNV(string maNV, string hoTen, string quocTich, string danToc, string gioiTinh, string gtnu, DateTime ngaySinh, string chucVu, string queQuan, string soDienThoai, string cCCD, string email, string diaChiHienTai, string maKV)
        {
            MaNV = maNV;
            HoTen = hoTen;
            QuocTich = quocTich;
            DanToc = danToc;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            ChucVu = chucVu;
            QueQuan = queQuan;
            SoDienThoai = soDienThoai;
            CCCD = cCCD;
            Email = email;
            DiaChiHienTai = diaChiHienTai;
            MaKV = maKV;
        }

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string QuocTich1 { get => QuocTich; set => QuocTich = value; }
        public string DanToc1 { get => DanToc; set => DanToc = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string SoDienThoai1 { get => SoDienThoai; set => SoDienThoai = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string DiaChiHienTai1 { get => DiaChiHienTai; set => DiaChiHienTai = value; }
        public string MaKV1 { get => MaKV; set => MaKV = value; }
    }
}
