using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class Marka:BaseEntity
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        public string Name { get; set; }
        public ICollection<ProductMarka> ProductMarkas { get; set; }
        public ICollection<Model> Models { get; set; }
        public Marka()
        {
            ProductMarkas = new HashSet<ProductMarka>();
            Models = new HashSet<Model>();
        }
    }
}
