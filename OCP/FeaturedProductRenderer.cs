using System;

namespace BreakingOpenClosedPrinciple
{
    public class FeaturedProductRenderer : IProductRenderer
    {
        public void Render(decimal price)
        {
            Console.WriteLine("******* WOO HOOO *******");
            Console.WriteLine("******* FEATURED PRODUCT HERE **********");
            Console.WriteLine("******* I COST £{0} **********", price);
        }
    }
}
