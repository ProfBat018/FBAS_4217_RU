using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class Curator
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public virtual ICollection<GroupsCurator> GroupsCurators { get; } = new List<GroupsCurator>();
}
