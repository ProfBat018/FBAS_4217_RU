using System;
using System.Collections.Generic;

namespace EfAsync
{
    public partial class Sale
    {
        public int Id { get; set; }
        public int SalesmanId { get; set; }
        public int CarId { get; set; }
        public int PersonId { get; set; }

        public virtual Car Car { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
        public virtual Salesman Salesman { get; set; } = null!;
    }
}
