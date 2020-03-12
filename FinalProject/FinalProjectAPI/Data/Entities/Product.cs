using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class Product:BaseEntity
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<ProductMarka> ProductMarkas { get; set; }
        public Product()
        {
            ProductMarkas = new HashSet<ProductMarka>();
        }
    }
}
