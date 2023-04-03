using System;
using System.Collections.Generic;

namespace EfAsync
{
    public partial class Car
    {
        public Car()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int? Year { get; set; }
        public string? ImageUrl { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public override string ToString()
        {
            return $"{Id} {Make} {Model}";
        }
    }
}
