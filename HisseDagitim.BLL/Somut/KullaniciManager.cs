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
    public class KullaniciManager : IKullaniciService
    {
        private IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }
        public void Add(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);
        }

        public void Delete(Kullanici kullanici)
        {
            try
            {
                _kullaniciDal.Delete(kullanici);
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Silme Gerçekleşmedi");
            }
        }

        public List<Kullanici> GetAll()
        {
            return _kullaniciDal.GetAll();
        }

        public Kullanici GetKullanici(string kAdi, string kPassword)
        {
            return _kullaniciDal.Get(p => p.KullaniciAdi == kAdi && p.Password == kPassword);
        }

        public Kullanici GetKullaniciByID(int kID)
        {
            return _kullaniciDal.Get(p=>p.ID == kID);
        }

        public Kullanici GetKullaniciByName(string kAdi)
        {
            return _kullaniciDal.Get(p => p.KullaniciAdi == kAdi);
        }

        public void Update(Kullanici kullanici)
        {
            _kullaniciDal.Update(kullanici);
        }
    }
}
