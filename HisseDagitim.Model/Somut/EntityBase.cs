using HisseDagitim.Model.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Somut
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            OlusturmaTarihi = DateTime.Now;
        }
        public DateTime OlusturmaTarihi { get; set; }

    }
}
