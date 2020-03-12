using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class ProductMarka
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int MarkaID { get; set; }
        public Marka Marka { get; set; }
    }
}
