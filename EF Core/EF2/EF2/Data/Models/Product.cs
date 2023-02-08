using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data.Models
{
    public class Product
    {
        [Key] // Primary key
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime ProdDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
