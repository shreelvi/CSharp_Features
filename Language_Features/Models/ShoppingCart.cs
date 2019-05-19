using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Features.Models
{
    // represents a collection of Product objects
    // Implementing an Interface in the ShoppingCart.cs File
    public class ShoppingCart: IEnumerable<Product>
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();        }
    }
}
