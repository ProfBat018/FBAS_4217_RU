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

        [Required]
        public Forecast Forecast { get; set; } = null!;

        public DateTime SearchTime { get; set; }
    }
}
