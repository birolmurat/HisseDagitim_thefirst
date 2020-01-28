using HisseDagitim.BLL.Soyut;
using HisseDagitim.DAL.Soyut;
using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.Somut
{
    public class YeniPayPuluManager : IYeniPayPuluService
    {
        private IYeniPayPuluDal _yeniPayPuluDal;

        public YeniPayPuluManager(IYeniPayPuluDal yeniPayPuluDal)
        {
            _yeniPayPuluDal = yeniPayPuluDal;
        }

        public void Add(YeniPayPulu yeniPayPulu)
        {
            _yeniPayPuluDal.Add(yeniPayPulu);
        }

        public void Delete(YeniPayPulu yeniPayPulu)
        {
            try
            {
                _yeniPayPuluDal.Delete(yeniPayPulu);
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Silme Gerçekleşmedi");
            }
        }

        public List<YeniPayPulu> GetAll()
        {
            return _yeniPayPuluDal.GetAll();
        }

        public YeniPayPulu GetYeniPay(int id)
        {
            return _yeniPayPuluDal.Get(p => p.ID == id);
        }

        public void Update(YeniPayPulu yeniPayPulu)
        {
            _yeniPayPuluDal.Update(yeniPayPulu);
        }
    }
}
