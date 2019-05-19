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

        // filter products so that Product objects whose Price property matches or exceeds 
        // the parameter are returned in the result.
        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach (Product prod in productEnum)
            {
                if ((prod?.Price ?? 0) >= minimumPrice)
                {
                    yield return prod;
                }
            }
        }
    }
}
