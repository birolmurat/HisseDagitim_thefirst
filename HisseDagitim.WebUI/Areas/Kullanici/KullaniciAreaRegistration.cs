using System.Web.Mvc;

namespace HisseDagitim.WebUI.Areas.Kullanici
{
    public class KullaniciAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Kullanici";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Kullanici_default",
                "Kullanici/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}