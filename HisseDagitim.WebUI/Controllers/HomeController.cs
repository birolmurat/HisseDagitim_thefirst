using HisseDagitim.BLL.DependencyResolvers.Ninject;
using HisseDagitim.BLL.Soyut;
using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HisseDagitim.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IHisseSahibiService _hsahipService;
        private IKullaniciService _kullaniciService;
        //[Authorize]
        public ActionResult Index()
        {
            _hsahipService = InstanceFactory.GetInstance<IHisseSahibiService>();
            var model = _hsahipService.GetAll();

            return View(model);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            var model = _kullaniciService.GetAll();
            if (_kullaniciService.GetAll().Any(x => x.KullaniciAdi == kullanici.KullaniciAdi && x.Password == kullanici.Password))
            {
                Kullanici girisYapan = _kullaniciService.GetAll().FirstOrDefault(x => x.KullaniciAdi == kullanici.KullaniciAdi);
                Session["kullanici"] = girisYapan;
                return RedirectToAction("Index", "Home", new { area = "Kullanici" });
            }
            else
            {
                ViewBag.Message = "Kullanıcı Bulunamadı";
                return View();
            }
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}