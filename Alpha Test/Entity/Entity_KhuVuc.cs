using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_KhuVuc
    {
        private string MaKV;
        private string TenKV;
        private string DiaChi;

        public Entity_KhuVuc(string maKV, string tenKV, string diaChi)
        {
            MaKV = maKV;
            TenKV = tenKV;
            DiaChi = diaChi;
        }

        public string MaKV1 { get => MaKV; set => MaKV = value; }
        public string TenKV1 { get => TenKV; set => TenKV = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    }
}
