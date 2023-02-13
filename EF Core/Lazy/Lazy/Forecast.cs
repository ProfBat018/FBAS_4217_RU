using System;
using System.Collections.Generic;

namespace Lazy;

public partial class Forecast
{
    public int ForecastId { get; set; }

    public int CoordId { get; set; }

    public string? Base { get; set; }

    public int MainId { get; set; }

    public int Visibility { get; set; }

    public int WindId { get; set; }

    public int CloudsId { get; set; }

    public int Dt { get; set; }

    public int SysId { get; set; }

    public int Timezone { get; set; }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Cod { get; set; }

    public virtual Cloud Clouds { get; set; } = null!;

    public virtual Coord Coord { get; set; } = null!;

    public virtual ICollection<ForecastHistory> ForecastHistories { get; } = new List<ForecastHistory>();

    public virtual Main Main { get; set; } = null!;

    public virtual Sy Sys { get; set; } = null!;

    public virtual ICollection<Weather> Weathers { get; } = new List<Weather>();

    public virtual Wind Wind { get; set; } = null!;
}
