using GeoItemMap.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GeoItemMap.DAL.DataContext
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PC11-1203-3N\\SQLEXPRESS;  Database=GeoItemDB_v2;  Persist Security Info =false; User='sa'; Password='sa'; MultipleActiveResultSets=True; Trusted_Connection=False;");
            //"Server=localhost;  Database=GeoItemDB;  User Id='sa'; Password='DeeDanZel_1';"
        }

        // ПРИ МИГРАЦИИ БД, ЗАКОНМЕНТИТЬ НИЖЕ (А НА РЕЛИЗЕ РАСКОМЕНТИТЬ)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

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

            modelBuilder.Entity<Technopark>().HasData(new Predefined.PredefinedTechnoparkList().Technoparks);
            modelBuilder.Entity<TechTransferCenter>().HasData(new Predefined.PredefinedTechTransferCenterList().TechTransferCenters);
            modelBuilder.Entity<InnProject>().HasData(new Predefined.PredefinedInnProjectList().innProjects);
            modelBuilder.Entity<NtpProject>().HasData(new Predefined.PredefinedNtpProjectList().ntpProjects);
        }
    }
}
