using HisseDagitim.Model.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Somut
{
    public class Kullanici : EntityBase,IEntity
    {
        public int ID { get; set; }

        public string KullaniciAdi { get; set; }

        public string Password { get; set; }


        //Mapping
        public virtual List<Log> Logs { get; set; }
    }
}
