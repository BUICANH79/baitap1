using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Model
{
   public class DonVi
    {
        public string MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public string MaCoSo { get; set; }
        public DonVi()
        {

        }
        public DonVi(string maDonVi, string tenDonVi, string maCoSo)
        {
            MaDonVi = maDonVi;
            TenDonVi = tenDonVi;
            MaCoSo = maCoSo;
        }
    }
}
