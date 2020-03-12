using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class BaseEntity
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? CreatedID { get; set; }
        public int? ModifiedID { get; set; }
        public int? DeletedID { get; set; }
    }
}
