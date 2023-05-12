using GeoItemMap.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GeoItemMap.DAL.DataContext
{
    public class AppDbContext : DbContext
    {


        public class OptionsBuild
        {
            public DbContextOptionsBuilder<AppDbContext> opsBuilder { get; set; }
            public DbContextOptions<AppDbContext> dbOptins { get; set; }
            private DALConfiguration _appConfiguration { get; set; }

            public OptionsBuild()
            {
                _appConfiguration = new DALConfiguration();
                opsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                opsBuilder.UseSqlServer(_appConfiguration.sqlConnectionString);
                dbOptins = opsBuilder.Options;
            }
        }
        public static OptionsBuild ops = new OptionsBuild();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbContextOptions<AppDbContext> ConnectionString { get; }

        public DbSet<GeoItem>? geoItems { get; set; }

        public DbSet <GNTPandRNTP>? gNTPandRNTPs { get; set; }
        public DbSet <InnProject>? innProjects { get; set; }  
        public DbSet <Technopark>? technoparks { get; set;}

        public DbSet <TechTransferCenter>? techtransfercenters { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GeoItem>().ToTable("GeoItems");
            modelBuilder.Entity<GNTPandRNTP>().ToTable("GNTPandRNTPs");
            modelBuilder.Entity<InnProject>().ToTable("InnProjects");
            modelBuilder.Entity<Technopark>().ToTable("Technoparks");
            modelBuilder.Entity<TechTransferCenter>().ToTable("TechTransferCenters");
           

            modelBuilder.Entity<Technopark>().HasData( new Predefined.PredefinedTechnoparkList().Technoparks);


        }
    }
}
