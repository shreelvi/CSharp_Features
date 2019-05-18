using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Language_Features.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports"; //Using auto-implemented property initializer
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; } = true; // Creating read-Only automatically implemented properties

        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            kayak.Related = lifejacket;
            return new Product[] { kayak, lifejacket, null };
        }
    }
}
