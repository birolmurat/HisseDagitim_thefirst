using HisseDagitim.BLL.DependencyResolvers.Ninject;
using HisseDagitim.BLL.Soyut;
using HisseDagitim.Model.Somut;
using HisseDagitim.WebUI.AuthFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HisseDagitim.WebUI.Areas.Kullanici.Controllers
{
    [KullaniciAuthentication]
    public class HisseSahibiIslemleriController : Controller
    {

        private IHisseSahibiService _hSahipService;
        public HisseSahibiIslemleriController()
        {
            _hSahipService = InstanceFactory.GetInstance<IHisseSahibiService>();
        }
        // GET: Kullanici/Home
        // GET: Kullanici/HisseSahibiIslemleri
        public ActionResult HSahipIslemleri()
        {
            var model = _hSahipService.GetAll();
            return View(model);
        }

        public ActionResult Listele()
        {
            var model = _hSahipService.GetAll();
            return View(model);
        }

        public ActionResult Duzenle(HisseSahibi hsahip)
        {
            var model = hsahip;
            return View(model);
        }

        [HttpPost]
        public JsonResult autofillhere(string afill_t)
        {

            var autoFill_t = (from hSahipTekil in _hSahipService.GetAll() where hSahipTekil.HSahipAdi.ToLower().Contains(afill_t.ToLower()) select new { label = hSahipTekil.HSahipAdi }).ToList();

            return Json(autoFill_t, JsonRequestBehavior.AllowGet);

        }

    }
}