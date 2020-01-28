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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
