namespace BreakingLiskovSubtitutionPrinciple
{
    public class Rectangle : IShape
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int Area()
        {
            return Height*Width;
        }
    }

    #region What's wrong with the above?
// Square is a sub class of Rectangle, but the Square object sets both the height 
// & width to the same value when either property is changed.
// While this makes sense in the real world, it does mean that the Square does not behave in the 
// same way as it’s parent class. 
//
// Real World Example: Filling your car up. Petrol & Diesel are both Types of Fuel, derived from Oil.
// However, substituting one for the other has a dramatic side affect on the system in which it is used.
#endregion
}
