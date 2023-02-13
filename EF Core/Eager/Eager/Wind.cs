using System;
using System.Collections.Generic;

namespace Eager;

public partial class Wind
{
    public int WindId { get; set; }

    public float Speed { get; set; }

    public int Deg { get; set; }

    public virtual ICollection<Forecast> Forecasts { get; } = new List<Forecast>();
}
