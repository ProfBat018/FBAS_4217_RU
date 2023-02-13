using System;
using System.Collections.Generic;

namespace Eager;

public partial class Coord
{
    public int CoordId { get; set; }

    public float Lon { get; set; }

    public float Lat { get; set; }

    public virtual ICollection<Forecast> Forecasts { get; } = new List<Forecast>();
}
