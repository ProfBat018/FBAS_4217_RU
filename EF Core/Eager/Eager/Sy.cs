using System;
using System.Collections.Generic;

namespace Eager;

public partial class Sy
{
    public int SysId { get; set; }

    public int Type { get; set; }

    public int Id { get; set; }

    public string Country { get; set; } = null!;

    public int Sunrise { get; set; }

    public int Sunset { get; set; }

    public virtual ICollection<Forecast> Forecasts { get; } = new List<Forecast>();
}
