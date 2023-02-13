using System;
using System.Collections.Generic;

namespace Lazy;

public partial class Weather
{
    public int WeatherId { get; set; }

    public int Id { get; set; }

    public string Main { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public int ForecastId { get; set; }

    public virtual Forecast Forecast { get; set; } = null!;
}
