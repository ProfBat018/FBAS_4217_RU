using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class NewPerson
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronimic { get; set; } = null!;
}
