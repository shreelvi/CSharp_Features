using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Features.Models
{
    // Extension methods are a convenient way of adding methods to classes 
    // that you do not own and cannot modify directly
    public static class MyExtensionMethods
    {
        // Applying Extension Methods to an Interface 
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;            }
            return total;
        }
    }
}
