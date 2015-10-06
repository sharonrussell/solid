namespace BreakingInterfaceSegregationPrinciple
{
    public class LuxuryCar : IVehicle, IHasRadio, IHasSunroof
    {
        private readonly IHeatedSeats _heatedSeats;

        private bool _radioOn;

        public LuxuryCar(IHeatedSeats heatedSeats)
        {
            _heatedSeats = heatedSeats;
        }

        public void Accelerate(){ 
            // do something to make car go faster
        }

        public void Brake(){
            //do something to make car slow down
        }

        public void ChangeGear(int gear){
            // change to selected gear
        }

        public void TurnOnRadio(){
            _radioOn = true;
        }
        public void TurnOffRadio(){
            _radioOn = false;
        }

        public void OpenSunRoof(int percentOpen){
            //Open sunroof to requested amount
        }

        public void CloseSunRoof(){
            //Make sunroof 100% shut (0% open)
        }

        public void HeatSeats()
        {
            _heatedSeats.HeatSeats();
        }

        public void CoolSeats()
        {
            _heatedSeats.CoolSeats();
        }
    }
}