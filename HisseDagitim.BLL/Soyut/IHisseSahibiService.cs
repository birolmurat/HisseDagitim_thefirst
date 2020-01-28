using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.Soyut
{
    public interface IHisseSahibiService
    {
        List<HisseSahibi> GetAll();

        List<HisseSahibi> GetHisseSahibiByName(string hsName);

        List<HisseSahibi> GetHisseSahibiByTCKN_VergiNo(string hsTC_VN);

        void Add(HisseSahibi hSahip);

        void Update(HisseSahibi hSahip);

        void Delete(HisseSahibi hSahip);

        HisseSahibi GetSahibi(string hsName);
    }
}
