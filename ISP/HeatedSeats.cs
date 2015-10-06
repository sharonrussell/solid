using System;

namespace BreakingInterfaceSegregationPrinciple
{
    public class HeatedSeats : IHeatedSeats
    {
        public void HeatSeats()
        {
            Console.WriteLine("HEATING");
        }

        public void CoolSeats()
        {
            Console.WriteLine("COOLING");
        }
    }
}