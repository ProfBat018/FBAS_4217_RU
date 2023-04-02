using System;
using System.Collections.Generic;

namespace EfAsync
{
    public partial class Customer
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }

        public virtual Person? Person { get; set; }
    }
}
