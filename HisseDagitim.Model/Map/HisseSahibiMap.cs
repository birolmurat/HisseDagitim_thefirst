using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Map
{
    public class HisseSahibiMap:BaseMap<HisseSahibi>
    {
        public HisseSahibiMap()
        {
            ToTable("HisseSahipleri");

            Property(p => p.HSahipAdi).HasColumnName("Hisse Sahibi Adı").HasMaxLength(100);

            Property(p => p.isTuzel).HasColumnName("Tüzel Kişi Durumu");

            Property(p => p.TCKN_VergiNo).HasColumnName("TCKN - Vergi No").HasMaxLength(100);

            Property(p => p.Telefon).HasColumnName("Telefon").HasMaxLength(100);
            
            Property(p => p.Adres).HasColumnName("Adres").HasMaxLength(500);

            Property(p => p.Email).HasColumnName("E-Mail").HasMaxLength(100);
        }
    }
}
