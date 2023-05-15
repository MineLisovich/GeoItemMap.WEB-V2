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

        public DbSet<GeoItem>? GeoItems { get; set; }

        public DbSet <NtpProject>? NtpProjects { get; set; }
        public DbSet <InnProject>? InnProjects { get; set; }  
        public DbSet <Technopark>? Technoparks { get; set;}

        public DbSet <TechTransferCenter>? Techtransfercenters { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GeoItem>().ToTable("GeoItems");
            modelBuilder.Entity<NtpProject>().ToTable("NtpProject");
            modelBuilder.Entity<InnProject>().ToTable("InnProjects");
            modelBuilder.Entity<Technopark>().ToTable("Technoparks");
            modelBuilder.Entity<TechTransferCenter>().ToTable("TechTransferCenters");
           

            modelBuilder.Entity<Technopark>().HasData( new Predefined.PredefinedTechnoparkList().Technoparks);
            modelBuilder.Entity<TechTransferCenter>().HasData(new Predefined.PredefinedTechTransferCenterList().TechTransferCenters);
            modelBuilder.Entity<InnProject>().HasData(new Predefined.PredefinedInnProjectList().innProjects);
            modelBuilder.Entity<NtpProject>().HasData(new Predefined.PredefinedGNTPadnRNTPList().gNTPandRNTPs);



        }
    }
}
