using System;
using System.Collections.Generic;

namespace Lazy;

public partial class Main
{
    public int MainId { get; set; }

    public float Temp { get; set; }

    public float FeelsLike { get; set; }

    public float TempMin { get; set; }

    public float TempMax { get; set; }

    public int Pressure { get; set; }

    public int Humidity { get; set; }

    public virtual ICollection<Forecast> Forecasts { get; } = new List<Forecast>();
}
