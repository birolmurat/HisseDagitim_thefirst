using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.Soyut
{
    public interface IKullaniciService
    {
        List<Kullanici> GetAll();

        Kullanici GetKullanici(string kAdi, string kPassword);

        Kullanici GetKullaniciByName(string kAdi);

        Kullanici GetKullaniciByID(int kID);
        
        void Add(Kullanici kullanici);

        void Update(Kullanici kullanici);

        void Delete(Kullanici kullanici);
    }
}
