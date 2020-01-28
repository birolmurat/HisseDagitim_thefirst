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
    public class KarPayiPulu : EntityBase,IEntity
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int Yil { get; set; }

        public bool isDagitildi { get; set; }

        public decimal Carpan { get; set; }//hisse_değeri * çarpan = dağıtılan değer

        //Mapping

        public int HisseSenediID { get; set; }

        public virtual HisseSenedi HisseSenedi { get; set; }
    }
}
