using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.Soyut
{
    public interface IYeniPayPuluService
    {
        List<YeniPayPulu> GetAll();

        YeniPayPulu GetYeniPay(int id);

        void Add(YeniPayPulu yeniPayPulu);

        void Update(YeniPayPulu yeniPayPulu);

        void Delete(YeniPayPulu yeniPayPulu);
    }
}
