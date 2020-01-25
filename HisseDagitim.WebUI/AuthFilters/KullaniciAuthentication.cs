using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HisseDagitim.WebUI.AuthFilters
{
    public class KullaniciAuthentication:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["kullanici"] != null)
                return true;
            httpContext.Response.Redirect("/Home/Login");
            return false;
        }
    }
}