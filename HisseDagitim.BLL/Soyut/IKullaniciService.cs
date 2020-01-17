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
        
        void Add(Kullanici kullanici);

        void Update(Kullanici kullanici);

        void Delete(Kullanici kullanici);
    }
}
