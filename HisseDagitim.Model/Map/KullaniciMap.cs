using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Map
{
    public class KullaniciMap:BaseMap<Kullanici>
    {
        public KullaniciMap()
        {
            Property(p => p.KullaniciAdi).HasColumnName("Kullanıcı Adı").HasMaxLength(50).IsRequired();

            Property(p => p.Password).HasColumnName("Tüzel Kişi Durumu").HasMaxLength(100).IsRequired();
        }
    }
}
