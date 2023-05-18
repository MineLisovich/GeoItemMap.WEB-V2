using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.DataContext
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            DALConfiguration configuration = new DALConfiguration();
            var opsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            opsBuilder.UseSqlServer(configuration.sqlConnectionString);
            return new AppDbContext(opsBuilder.Options);
        }
    }
}
