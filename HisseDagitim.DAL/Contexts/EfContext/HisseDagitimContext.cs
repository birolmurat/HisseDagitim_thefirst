namespace HisseDagitim.DAL.Contexts.EfContext
{
    using HisseDagitim.DAL.FakeData_Strategy;
    using HisseDagitim.Model.Map;
    using HisseDagitim.Model.Somut;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HisseDagitimContext : DbContext
    {
        // Your context has been configured to use a 'HisseDagitimContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'HisseDagitim.DAL.Contexts.EfContext.HisseDagitimContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HisseDagitimContext' 
        // connection string in the application configuration file.
        public HisseDagitimContext()
            : base("name=HisseDagitimContext")
        {
        }

        public DbSet<HisseSahibi> HisseSahipleri { get; set; }

        public DbSet<HisseSenedi> HisseSenetleri { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Log> Log { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<HisseDagitimContext>(new FakeData());


            modelBuilder.Configurations.Add(new HisseSahibiMap());

            modelBuilder.Configurations.Add(new HisseSenediMap());

            modelBuilder.Configurations.Add(new KullaniciMap());

            modelBuilder.Configurations.Add(new LogMap());


            base.OnModelCreating(modelBuilder);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}