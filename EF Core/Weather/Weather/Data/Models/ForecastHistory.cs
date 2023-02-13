using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Data.Models
{
    public class ForecastHistory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Forecasts")]
        public int ForecastId { get; set; }

        public Forecast Forecast { get; set; }

        public DateTime SearchTime { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Forecast.name}";

            //return $"{Id}. {Forecast?.name} - {Forecast?.main.temp}℃";
        }
    }
}
