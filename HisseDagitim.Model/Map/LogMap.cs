using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Map
{
    public class LogMap:BaseMap<Log>
    {
        public LogMap()
        {
            ToTable("Logs");

            Property(p => p.Aciklama).HasColumnName("Açıklama");
        }
    }
}
