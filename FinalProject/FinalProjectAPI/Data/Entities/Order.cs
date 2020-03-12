using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class Order:BaseEntity
    {
        public int Id { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public int ModelID { get; set; }
        public string Color { get; set; }
        public byte Count { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsCanceled { get; set; }
        public decimal Price { get; set; }
        public int DeliveryInformationID { get; set; }
        public DeliveryInformation DeliveryInformation { get; set; }
    }
}
