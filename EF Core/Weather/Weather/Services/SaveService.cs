
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Data.DbContexts;
using Weather.Data.Models;

namespace Weather.Services
{
    /*
     
      History = new()
                {
                    Forecast = ForecastResult,
                    SearchTime = DateTime.Now
                };

                context.Forecasts.Add(ForecastResult);
                context.ForecastHistories.Add(History);

                context.SaveChanges();
    */

    public static class SaveService
    {
        public static void Save(Forecast forecast)
        {
            ForecastHistory history = new()
            { 
                Forecast = forecast,
                SearchTime = DateTime.Now
            };

            using WeatherDbContext context = new();

            context.Forecasts.Add(forecast);
            context.ForecastHistories.Add(history);

            context.SaveChanges();
        }
    }
}
