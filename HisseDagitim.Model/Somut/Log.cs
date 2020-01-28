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
    public class Log : EntityBase,IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Aciklama { get; set; }


        //Mapping

        public int KullaniciID { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
