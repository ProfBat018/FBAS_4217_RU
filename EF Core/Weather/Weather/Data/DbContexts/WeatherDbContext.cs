using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Data.Models;

namespace Weather.Data.DbContexts
{
    public class WeatherDbContext : DbContext
    {
        // DbSet - таблица, то есть аналог таблицы из SQL в формате класса.
        public DbSet<Forecast> Forecasts { get; set; }
        public DbSet<ForecastHistory> ForecastHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder builder = new();

            builder.AddJsonFile("appsettings.json");

            IConfigurationRoot config = builder.Build();

            var connectionString = config.GetConnectionString("Weather");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
