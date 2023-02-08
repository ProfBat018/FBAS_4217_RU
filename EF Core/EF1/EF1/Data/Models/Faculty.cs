using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class Faculty
{
    public int Id { get; set; }

    public decimal Financing { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; } = new List<Department>();
}
