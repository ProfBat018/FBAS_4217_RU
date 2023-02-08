using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Year { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<GroupsCurator> GroupsCurators { get; } = new List<GroupsCurator>();

    public virtual ICollection<GroupsLecture> GroupsLectures { get; } = new List<GroupsLecture>();
}
