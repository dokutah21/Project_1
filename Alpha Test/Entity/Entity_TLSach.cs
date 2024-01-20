using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_TLSach
    {
        private string MaTL;
        private string TenTL;

        public Entity_TLSach(string maTL, string tenTL)
        {
            MaTL = maTL;
            TenTL = tenTL;
        }

        public string MaTL1 { get => MaTL; set => MaTL = value; }
        public string TenTL1 { get => TenTL; set => TenTL = value; }
    }
}
