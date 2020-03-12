using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class Comment:BaseEntity
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100,MinimumLength =3)]
        public string UserName { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 3)]
        public string Description { get; set; }
        public byte StarCount { get; set; }
        public int ModelID { get; set; }
        public Model Model { get; set; }
    }
}
