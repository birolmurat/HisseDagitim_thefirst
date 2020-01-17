using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Map
{
    public class YeniPayPuluMap:BaseMap<YeniPayPulu>
    {
        public YeniPayPuluMap()
        {
            ToTable("YeniPayPullari");
        }
    }
}
