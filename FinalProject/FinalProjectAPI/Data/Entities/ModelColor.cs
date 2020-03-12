using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data.Entities
{
    public class ModelColor
    {
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int ColorID { get; set; }
        public Color Color { get; set; }
    }
}
