using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Weather.Data.DbContexts;
using Weather.Data.Models;

namespace Weather.Services
{
    class LoadService
    {
        public static IEnumerable<ForecastHistory> LoadData()
        {
            using WeatherDbContext weatherDbContext = new();

            try
            {
                var res = weatherDbContext.ForecastHistories.Include("Forecast").ToList();
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
