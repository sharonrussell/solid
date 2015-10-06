using System;

namespace BreakingOpenClosedPrinciple
{
    public class SecretProductRenderer : IProductRenderer
    {
        public void Render(decimal price)
        {
            Console.WriteLine("SHHHH, This is a secret product costing: £{0}", price);
        }
    }
}