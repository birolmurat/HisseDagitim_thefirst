using HisseDagitim.WebUI.AuthFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HisseDagitim.Model.Somut;
using HisseDagitim.BLL.Soyut;
using HisseDagitim.BLL.DependencyResolvers.Ninject;

namespace HisseDagitim.WebUI.Areas.Kullanici.Controllers
{
    [KullaniciAuthentication]
    public class HomeController : Controller
    {
        private IHisseSahibiService _hSahipService;
        public HomeController()
        {
            _hSahipService = InstanceFactory.GetInstance<IHisseSahibiService>();
        }
        // GET: Kullanici/Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult autofillhere(string afill_t)
        {

            var getHSahipList = _hSahipService.GetAll();
            var autoFill_t = (from hSahipTekil in _hSahipService.GetAll() where hSahipTekil.HSahipAdi.ToLower().Contains(afill_t.ToLower()) select new { label = hSahipTekil.HSahipAdi }).ToList();

            return Json(autoFill_t, JsonRequestBehavior.AllowGet);

        }
       
    }
}
