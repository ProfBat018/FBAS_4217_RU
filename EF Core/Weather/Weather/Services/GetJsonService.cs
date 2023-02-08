using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.Data.Models;

namespace Weather.Services
{
    public class GetJsonService
    {
        private WebClient webClient = new();
        private WeatherSearchModel searchModel;


        public string? GetWeatherJson(string? cityName)
        {
            if (cityName != null)
            {
                searchModel = new(cityName);
                try
                {
                    string? json = webClient.DownloadString(searchModel.ToString());
                    return json; 
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            throw new NullReferenceException("City is null");
        }
    }
}
