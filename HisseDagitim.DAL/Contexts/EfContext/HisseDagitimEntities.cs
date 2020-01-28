using HisseDagitim.DAL.FakeData_Strategy;
using HisseDagitim.Model.Map;
using HisseDagitim.Model.Somut;
using System;
using System.Data.Entity;
using System.Linq;

namespace HisseDagitim.DAL.Contexts.EfContext
{
    

    public class HisseDagitimEntities : DbContext
    {
      
        public HisseDagitimEntities():base("name=HisseDagitimEntities")
        {
             //Database.Connection.ConnectionString = "server=.;database=HisseDB;uid=sa;pwd=123";
        }

        public DbSet<HisseSahibi> HisseSahipleri { get; set; }

        public DbSet<HisseSenedi> HisseSenetleri { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Log> Log { get; set; }

        public DbSet<KarPayiPulu> KarPayiPullari { get; set; }

        public DbSet<YeniPayPulu> YeniPayPullari { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<HisseDagitimEntities>(new FakeData());


            modelBuilder.Configurations.Add(new HisseSahibiMap());

            modelBuilder.Configurations.Add(new HisseSenediMap());

            modelBuilder.Configurations.Add(new KullaniciMap());

            modelBuilder.Configurations.Add(new LogMap());

            modelBuilder.Configurations.Add(new YeniPayPuluMap());

            modelBuilder.Configurations.Add(new KarPayiPuluMap());




            base.OnModelCreating(modelBuilder);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

  
}