using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class Model:BaseEntity
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public byte Count { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 3)]
        public string Details { get; set; }
        public ICollection<ModelColor> ModelColors { get; set; }
       

        public Model()
        {
            Comments = new List<Comment>();
            Pictures = new HashSet<Picture>();
            ModelColors = new HashSet<ModelColor>();
        }
    }
}
