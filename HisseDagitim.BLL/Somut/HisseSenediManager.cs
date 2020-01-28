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
    public class HisseSenediManager : IHisseSenediService
    {
        private IHisseSenediDal _hisseSenediDal;

        public HisseSenediManager(IHisseSenediDal hisseSenediDal)
        {
            _hisseSenediDal = hisseSenediDal;
        }


        public void Add(HisseSenedi hSenedi)  
        {
            _hisseSenediDal.Add(hSenedi);
        }

        public void Delete(HisseSenedi hSenedi)
        {
            try
            {
                _hisseSenediDal.Delete(hSenedi);
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Silme Gerçekleşmedi");
            }
        }

        public HisseSenedi Get(int hSenetID)
        {
            return _hisseSenediDal.Get(p => p.ID == hSenetID);
        }

        public List<HisseSenedi> GetAll()
        {
            return _hisseSenediDal.GetAll();
        }

        public List<HisseSenedi> GetGecerliHisseSenetleri(bool gecerliMi)
        {
            return _hisseSenediDal.GetAll(p=>p.isGecerli == true) ;
        }

        public HisseSenedi GetHisse(int yil, int hisseSahibiId, int tertip, int hisseNo)
        {
            return _hisseSenediDal.Get(p=>p.HisseYili == yil && p.HisseSahibiID == hisseSahibiId && p.HisseTertipNo == tertip && p.HisseNo == hisseNo);
        }

        public List<HisseSenedi> GetHisseSenediByHisseNo(int hNo)
        {
            if (!string.IsNullOrEmpty(hNo.ToString()))
            {
                return _hisseSenediDal.GetAll(p => p.HisseNo.ToString().Contains(hNo.ToString()));
            }
            else
            {
                return GetAll();
            }
        }

        public List<HisseSenedi> GetHisseSenediByTertipNo(int tertip)
        {
            return _hisseSenediDal.GetAll(p=>p.HisseTertipNo == tertip);
        }

        public List<HisseSenedi> GetHisseSenediHisseYili(int hYili)
        {
            if (!string.IsNullOrEmpty(hYili.ToString()))
            {
                return _hisseSenediDal.GetAll(p => p.HisseNo.ToString().Contains(hYili.ToString()));
            }
            else
            {
                return GetAll();
            }
        }

        public HisseSenedi GetLastHisse()
        {
            return _hisseSenediDal.GetAll().Last();
        }

        public void Update(HisseSenedi hSenedi)
        {
            _hisseSenediDal.Update(hSenedi);
        }
    }
}
