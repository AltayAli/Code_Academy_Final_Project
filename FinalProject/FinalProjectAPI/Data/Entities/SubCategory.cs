using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class SubCategory:BaseEntity
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }
        public SubCategory()
        {
            Products = new HashSet<Product>();
        }
    }
}
