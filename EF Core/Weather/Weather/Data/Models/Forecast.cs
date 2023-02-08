using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Weather.Data.Models
{
    public class Forecast
    {
        [JsonIgnore]
        [Key]
        public int ForecastId { get; set; }


        [ForeignKey("coord")]
        [JsonIgnore]
        public int CoordId { get; set; }
        public Coord coord { get; set; }



        [JsonPropertyName("weather")]
        [NotMapped]
        public Weather[] Weather { get; set; }

        [JsonIgnore]
        public virtual ICollection<Weather> Weathers { get; set; }


        public string _base { get; set; }



        [ForeignKey("main")]
        [JsonIgnore]
        public int MainId { get; set; }
        public Main main { get; set; }

        public int visibility { get; set; }



        [ForeignKey("wind")]
        [JsonIgnore]
        public int WindId { get; set; }
        public Wind wind { get; set; }



        [ForeignKey("clouds")]
        [JsonIgnore]
        public int CloudsId { get; set; }
        public Clouds clouds { get; set; }


        public int dt { get; set; }


        [ForeignKey("sys")]
        [JsonIgnore]
        public int SysId { get; set; }
        public Sys sys { get; set; }


        public int timezone { get; set; }
        public int id { get; set; }

        [Required]
        public string name { get; set; } = null!;
        public int cod { get; set; }
    }

    public class Coord
    {
        [JsonIgnore]
        [Key]
        public int CoordId { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
    }

    public class Main
    {
        [JsonIgnore]
        [Key]
        public int MainId { get; set; }
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }
    public class Wind
    {
        [JsonIgnore]
        [Key]
        public int WindId { get; set; }
        public float speed { get; set; }
        public int deg { get; set; }
    }
    public class Clouds
    {
        [JsonIgnore]
        [Key]
        public int CloudsId { get; set; }
        public int all { get; set; }
    }
    public class Sys
    {
        [JsonIgnore]
        [Key]
        public int SysId { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
    public class Weather
    {
        [JsonIgnore]
        [ForeignKey("Forecasts")]
        public int ForecastId { get; set; }
        public Forecast Forecast { get; set; }

        [JsonIgnore]
        [Key]
        public int WeatherId { get; set; }
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
