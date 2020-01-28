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
    public class HisseSahibi : EntityBase,IEntity
    {
        [Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string HSahipAdi { get; set; }

        public string TCKN_VergiNo { get; set; }

        public string Adres { get; set; }
        
        public string Telefon { get; set; }

        public string Email { get; set; }

        public bool isTuzel { get; set; } //Tüzel Kişi

        public decimal ToplamHisseDegeri { get; set; }



        //Mapping



        public virtual List<HisseSenedi> Hisseler { get; set; }

        public override string ToString()
        {
            return HSahipAdi;
        }

    }
}
