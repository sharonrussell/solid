namespace BreakingInterfaceSegregationPrinciple
{
    public class MotorCycle : IVehicle
    {
        public void Accelerate()
        {
            // do something to make Bike go faster 
        }

        public void Brake()
        {
            // do something to make Bike slow down 
        }

        public void ChangeGear(int gear)
        {
            //change to selected gear...remember that bikes have a sequential gear box!
        }
    }
}