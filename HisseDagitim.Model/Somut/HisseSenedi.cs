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

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }//database için ID
        
        public decimal HisseDegeri { get; set; }

        public int HisseTertipNo { get; set; }//hissenin tertip numarası

        public int HisseNo { get; set; }//tertip içi seri no

        public int HisseYili { get; set; }


        public bool isGecerli { get; set; } //Hisse senedinin geçerliliği



        //Mapping

        public int HisseSahibiID { get; set; }


        public virtual HisseSahibi HisseSahibi { get; set; }

        public virtual List<KarPayiPulu> KarPayiPullari { get; set; }

        public virtual List<YeniPayPulu> YeniPayPullari { get; set; }

    }
}
