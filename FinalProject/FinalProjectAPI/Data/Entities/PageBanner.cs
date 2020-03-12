using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class PageBanner
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string PhotoUrl { get; set; }
    }
}
