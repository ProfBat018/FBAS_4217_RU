using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class GroupsCurator
{
    public int Id { get; set; }

    public int? CuratorId { get; set; }

    public int? GroupId { get; set; }

    public virtual Curator? Curator { get; set; }

    public virtual Group? Group { get; set; }
}
