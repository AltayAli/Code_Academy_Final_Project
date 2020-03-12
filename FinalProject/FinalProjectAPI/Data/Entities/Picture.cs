using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class Picture:BaseEntity
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string PhotoUrl { get; set; }
        public int ModelID { get; set; }
        public Model Model { get; set; }
    }
}
