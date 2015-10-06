namespace BreakingInterfaceSegregationPrinciple
{
    public class BudgetCar : IVehicle, IHasRadio
    {
        private bool _radioOn;

        public void Accelerate()
        {
            // do something to make car go faster
        }

        public void Brake()
        {
            //do something to make car slow down
        }

        public void ChangeGear(int gear)
        {
            // change to selected gear
        }

        public void TurnOnRadio()
        {
            _radioOn = true;
        }
        public void TurnOffRadio()
        {
            _radioOn = false;
        }
    }
}