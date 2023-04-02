using System;
using System.Collections.Generic;

namespace EfAsync
{
    public partial class Person
    {
        public Person()
        {
            Customers = new HashSet<Customer>();
            Sales = new HashSet<Sale>();
            Salesmen = new HashSet<Salesman>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int? Age { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Salesman> Salesmen { get; set; }
    }
}
