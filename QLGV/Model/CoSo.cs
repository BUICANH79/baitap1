using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Model
{
    public class CoSo
    {
        public CoSo()
        {

        }
        public string MaCoSo { get; set; }
        public string TenCoSo { get; set; }
        public CoSo(string maCoSo, string tenCoSo)
        {
            MaCoSo = maCoSo;
            TenCoSo = tenCoSo;
        }
    }
}
