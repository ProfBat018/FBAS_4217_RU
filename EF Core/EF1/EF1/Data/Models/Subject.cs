using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lecture> Lectures { get; } = new List<Lecture>();
}
