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
    public class HisseSahibiManager : IHisseSahibiService
    {
        private IHisseSahibiDal _hisseSahibiDal;

        public HisseSahibiManager(IHisseSahibiDal hisseSahibiDal)
        {
            _hisseSahibiDal = hisseSahibiDal;
        }

        public void Add(HisseSahibi hSahip)
        {
            _hisseSahibiDal.Add(hSahip);
        }

        public void Delete(HisseSahibi hSahip)
        {
            try
            {
                _hisseSahibiDal.Delete(hSahip);
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Silme Gerçekleşmedi");
            }
        }

        public List<HisseSahibi> GetAll()
        {
            return _hisseSahibiDal.GetAll();
        }

        public List<HisseSahibi> GetHisseSahibiByName(string hsName)
        {
            if (!string.IsNullOrEmpty(hsName))
            {
                return _hisseSahibiDal.GetAll(p => p.HSahipAdi.ToLower().Contains(hsName.ToLower()));
            }
            else
            {
                return  GetAll();
            }
        }

        public List<HisseSahibi> GetHisseSahibiByTCKN_VergiNo(string hsTC_VN)
        {
            if (!string.IsNullOrEmpty(hsTC_VN))
            {
                return _hisseSahibiDal.GetAll(p => p.TCKN_VergiNo.ToLower().Contains(hsTC_VN.ToLower()));
            }
            else
            {
                return GetAll();
            }
        }

        public HisseSahibi GetSahibi(string hsName)
        {
            return _hisseSahibiDal.Get(p => p.HSahipAdi == hsName);
        }

        public void Update(HisseSahibi hSahip)
        {
            _hisseSahibiDal.Update(hSahip);
        }
    }
}
