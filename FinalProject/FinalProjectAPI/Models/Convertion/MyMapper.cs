using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Models.Convertion
{
    public class MyMapper<T> where T:class
    {
        public static void Map(T from,T to)
        {
            if (!from.Equals(to)) {
                var properties = from.GetType().GetProperties();
                foreach(var property in properties)
                {
                    property.SetValue(to, from.GetType().GetProperty(property.Name).GetValue(property));
                }
            }
        }
    }
}
