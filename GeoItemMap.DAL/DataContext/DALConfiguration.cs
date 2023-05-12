using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.DataContext
{
    /// <summary>
    /// Класс нужен для того чтобы взять строку подключения из  conString.json
    /// </summary>
    public class DALConfiguration
    {
        public DALConfiguration() 
        {
            var configBulder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBulder.AddJsonFile(path, false);
            var root = configBulder.Build();
            var appSetings = root.GetSection("ConnectionString:DefaultConnection");
            sqlConnectionString = appSetings.Value;
        }

        public string sqlConnectionString { get; set; } 
    }
}
