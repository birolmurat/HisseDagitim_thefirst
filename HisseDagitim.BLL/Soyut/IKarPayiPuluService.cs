using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.Soyut
{
    public interface IKarPayiPuluService
    {
        List<KarPayiPulu> GetAll();

        KarPayiPulu GetKarPayi(int id);

        void Add(KarPayiPulu karPayiPulu);

        void Update(KarPayiPulu karPayiPulu);

        void Delete(KarPayiPulu karPayiPulu);
    }
}
