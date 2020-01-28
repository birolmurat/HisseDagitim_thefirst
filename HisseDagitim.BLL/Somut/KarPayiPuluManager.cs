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
    public class KarPayiPuluManager : IKarPayiPuluService
    {
        private IKarPayiPuluDal _karPayiPuluDal;

        public KarPayiPuluManager(IKarPayiPuluDal karPayiPuluDal)
        {
            _karPayiPuluDal = karPayiPuluDal;
        }
        public void Add(KarPayiPulu karPayiPulu)
        {
            _karPayiPuluDal.Add(karPayiPulu);
        }

        public void Delete(KarPayiPulu karPayiPulu)
        {
            try
            {
                _karPayiPuluDal.Delete(karPayiPulu);
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Silme Gerçekleşmedi");
            }
        }

        public List<KarPayiPulu> GetAll()
        {
            return _karPayiPuluDal.GetAll();
        }

        public KarPayiPulu GetKarPayi(int id)
        {
            return _karPayiPuluDal.Get(p => p.ID == id);

        }

        public void Update(KarPayiPulu karPayiPulu)
        {
            _karPayiPuluDal.Update(karPayiPulu);
        }
    }
}
