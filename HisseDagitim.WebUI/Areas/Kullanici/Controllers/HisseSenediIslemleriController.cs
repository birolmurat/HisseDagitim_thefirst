using HisseDagitim.WebUI.AuthFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HisseDagitim.WebUI.Areas.Kullanici.Controllers
{
    [KullaniciAuthentication]
    public class HisseSenediIslemleriController : Controller
    {
        // GET: Kullanici/HisseSenediIslemleri
        public ActionResult Index()
        {
            return View();
        }
    }
}