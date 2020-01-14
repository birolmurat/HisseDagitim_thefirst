using HisseDagitim.Model.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Somut
{
    public class Log : EntityBase,IEntity
    {
        public int ID { get; set; }

        public string Aciklama { get; set; }


        //Mapping
        public Kullanici Kullanici { get; set; }
    }
}
