using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public decimal Salary { get; set; }

    public virtual ICollection<Lecture> Lectures { get; } = new List<Lecture>();
}
