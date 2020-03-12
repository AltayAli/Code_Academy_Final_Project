using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class Category:BaseEntity
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100,MinimumLength =3)]
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public Category()
        {
            SubCategories =new  HashSet<SubCategory>();
        }
    }
}
