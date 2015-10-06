using System;
using System.Collections.Generic;

namespace BreakingOpenClosedPrinciple
{
    class ProductConsole
    {
        public static void Main()
        {
            var product1 = new Product(4.52m, new StandardProductRenderer());
            var product2 = new Product(3.99m, new FeaturedProductRenderer());
            var product3 = new Product(1000000m, new SecretProductRenderer());

            var products = new List<Product> {product1, product2, product3};

            foreach (Product product in products)
            {
                product.Render();
            }

            Console.WriteLine("FINISHED......press any key");
            Console.ReadKey();
        }
    }
}
