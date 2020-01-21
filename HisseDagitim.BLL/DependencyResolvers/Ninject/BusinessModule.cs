using HisseDagitim.BLL.Somut;
using HisseDagitim.BLL.Soyut;
using HisseDagitim.DAL.Somut.EntityFramework;
using HisseDagitim.DAL.Soyut;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IHisseSahibiService>().To<HisseSahibiManager>().InSingletonScope();
            Bind<IHisseSahibiDal>().To<EfHisseSahibiDal>().InSingletonScope();

            Bind<IHisseSenediService>().To<HisseSenediManager>().InSingletonScope();
            Bind<IHisseSenediDal>().To<EfHisseSenediDal>().InSingletonScope();

            Bind<IKarPayiPuluService>().To<KarPayiPuluManager>().InSingletonScope();
            Bind<IKarPayiPuluDal>().To<EfKarPayiPuluDal>().InSingletonScope();

            Bind<IKullaniciService>().To<KullaniciManager>().InSingletonScope();
            Bind<IKullaniciDal>().To<EfKullaniciDal>().InSingletonScope();

            Bind<ILogService>().To<LogManager>().InSingletonScope();
            Bind<ILogDal>().To<EfLogDal>().InSingletonScope();

            Bind<IYeniPayPuluService>().To<YeniPayPuluManager>().InSingletonScope();
            Bind<IYeniPayPuluDal>().To<EfYeniPayPuluDal>().InSingletonScope();
        }
    }
}
