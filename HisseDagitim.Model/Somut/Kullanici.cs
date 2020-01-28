using HisseDagitim.Model.Enums;
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
    public class Kullanici : EntityBase,IEntity
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string KullaniciAdi { get; set; }

        public string Password { get; set; }

        public Roles Role { get; set; }

        public bool isGecerli { get; set; }


        //Mapping
        public virtual List<Log> Logs { get; set; }
    }
}
