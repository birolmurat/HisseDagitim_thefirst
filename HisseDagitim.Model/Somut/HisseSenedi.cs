using HisseDagitim.Model.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Somut
{
    public class HisseSenedi : EntityBase, IEntity
    {

        public HisseSenedi(decimal hisse_degeri ,int hisse_yili)
        {
            for (int i = 0; i < 10; i++) //SPK'ya göre 10 senelik Kar PayI Dağıtım Pulu Bulunması Gereklidir
            {
                KarDagitimPulu[i] = hisse_yili + i;
            }


            for (int j = 1; j < 16; j++) //SPK'ya göre 15 adet Yeni Pay Dağıtım Pulu bulunması gereklidir
            {
                YeniPayPulu[j] = j;
            }

        }


        public int ID { get; set; }
        
        public decimal HisseDegeri { get; set; }

        public int HisseYili { get; set; }

        public int[] KarDagitimPulu { get; set; }

        public int[] YeniPayPulu { get; set; }

        public bool isGecerli { get; set; } //Hisse senedinin geçerliliği



        //Mapping
        public HisseSahibi HisseSahibi { get; set; }
    }
}
