using HisseDagitim.DAL.Contexts.EfContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.DAL.FakeData_Strategy
{
    public class FakeData:DropCreateDatabaseIfModelChanges<HisseDagitimContext>
    {
        protected override void Seed(HisseDagitimContext context)
        {
            base.Seed(context); //fake data buraya girilecek
        }
    }
}
