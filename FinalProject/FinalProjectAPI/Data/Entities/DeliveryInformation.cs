using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class DeliveryInformation
    {
        public int ID { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string BaseAddress { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string AddressDetail { get; set; }
        public int AddressPosX { get; set; }
        public int AddressPosY { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
