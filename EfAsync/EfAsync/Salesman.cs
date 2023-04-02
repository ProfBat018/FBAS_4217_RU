using System;
using System.Collections.Generic;

namespace EfAsync
{
    public partial class Salesman
    {
        public Salesman()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? SalesCount { get; set; }

        public virtual Person? Person { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
