using HisseDagitim.BLL.DependencyResolvers.Ninject;
using HisseDagitim.BLL.Soyut;
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
        //[Authorize]
        public ActionResult Index()
        {
            _hsahipService = InstanceFactory.GetInstance<IHisseSahibiService>();
            var model = _hsahipService.GetAll();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}