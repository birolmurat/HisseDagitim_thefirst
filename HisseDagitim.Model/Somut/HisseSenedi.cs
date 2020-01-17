using HisseDagitim.Model.Soyut;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Somut
{
    public class HisseSenedi : EntityBase, IEntity
    {
        //SPK'ya göre 10 senelik Kar PayI Dağıtım Pulu Bulunması Gereklidir
        //SPK'ya göre 15 adet Yeni Pay Dağıtım Pulu bulunması gereklidir


        //public HisseSenedi(decimal hisse_degeri ,int hisse_yili)
        //{
        //    for (int i = 0; i < 10; i++) //SPK'ya göre 10 senelik Kar PayI Dağıtım Pulu Bulunması Gereklidir
        //    {
        //        KarDagitimPulu.Add(new KeyValuePair<int, decimal>(i + hisse_yili, 0));
        //    }


        //    for (int j = 1; j < 16; j++) //SPK'ya göre 15 adet Yeni Pay Dağıtım Pulu bulunması gereklidir
        //    {
        //        YeniPayPulu.Add(new KeyValuePair<int, decimal>(j, 0));
        //    }

        //}

        //public HisseSenedi()
        //{

        //}
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }//database için ID
        
        public decimal HisseDegeri { get; set; }

        public int HisseTertipNo { get; set; }//hissenin tertip numarası

        public int HisseNo { get; set; }//tertip içi seri no

        public int HisseYili { get; set; }

        //public List<KeyValuePair<int,decimal>> KarDagitimPulu { get; set; }//10 adet kar dağıtım senesi; key-value pair ====>>> <Sene, Dağıtılma çarpanı>

        //public List<KeyValuePair<int, decimal>> DagitilanKar { get; set; } // <Sene, Dağıtılan para değeri> parası dağıtılan kar payı pulları için 

        //public List<KeyValuePair<int, decimal>> YeniPayPulu { get; set; }//15 adet yeni pay numarası

        //public List<KeyValuePair<int,decimal>> DagitilanYeniPay { get; set; } //<pul numarası, Dağıtılan para değeri> parası dağıtılan yeni pay pulları için 

        public bool isGecerli { get; set; } //Hisse senedinin geçerliliği



        //Mapping
        public virtual HisseSahibi HisseSahibi { get; set; }

        public virtual List<KarPayiPulu> KarPayiPullari { get; set; }

        public virtual List<YeniPayPulu> YeniPayPullari { get; set; }

    }
}
