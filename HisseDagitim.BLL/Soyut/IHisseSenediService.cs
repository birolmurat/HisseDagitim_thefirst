using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.Soyut
{
    public interface IHisseSenediService
    {
        List<HisseSenedi> GetAll();

        List<HisseSenedi> GetHisseSenediByTertipNo(int tertip);

        List<HisseSenedi> GetHisseSenediByHisseNo(int hNo);

        List<HisseSenedi> GetHisseSenediHisseYili(int hYili);

        List<HisseSenedi> GetGecerliHisseSenetleri(bool gecerliMi);

        HisseSenedi Get(int hSenetID);

        HisseSenedi GetHisse(int yil, int hisseSahibiId, int tertip, int hisseNo);

        HisseSenedi GetLastHisse();

        void Add(HisseSenedi hSenedi);

        void Update(HisseSenedi hSenedi);

        void Delete(HisseSenedi hSenedi);
    }
}
