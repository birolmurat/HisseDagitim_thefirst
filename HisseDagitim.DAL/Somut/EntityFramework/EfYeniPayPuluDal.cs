using HisseDagitim.DAL.Contexts.EfContext;
using HisseDagitim.DAL.Soyut;
using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.DAL.Somut.EntityFramework
{
    public class EfYeniPayPuluDal:EfEntityDal<YeniPayPulu, HisseDagitimEntities>,IYeniPayPuluDal
    {
    }
}
