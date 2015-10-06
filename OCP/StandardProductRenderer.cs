using System;

namespace BreakingOpenClosedPrinciple
{
    public class StandardProductRenderer : IProductRenderer
    {
        public void Render(decimal price)
        {
            Console.WriteLine("Hi, I am a standard product that costs £{0}", price);
        }
    }
}