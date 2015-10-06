namespace BreakingLiskovSubtitutionPrinciple
{
    public class Square : IShape
    {
        public int Height { get; set; }

        public int Area()
        {
            return Height*Height;
        }
    }
}