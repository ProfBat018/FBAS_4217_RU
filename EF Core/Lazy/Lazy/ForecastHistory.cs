using System;
using System.Collections.Generic;

namespace Lazy;

public partial class ForecastHistory
{
    public int Id { get; set; }

    public int ForecastId { get; set; }

    public DateTime SearchTime { get; set; }

    public virtual Forecast Forecast { get; set; } = null!;
}
