using NUnit.Framework;

namespace BreakingLiskovSubtitutionPrinciple
{
    [TestFixture]
    public class TestShapes
    {
        [Test]
        public void ShouldCalculateAreaOfRectangle()
        {
            IShape rectangle = new Rectangle {Height = 5, Width = 4};

            Assert.That(rectangle.Area(), Is.EqualTo(20));
        }
        
        [Test]
        public void ShouldCalculateAreaOfSquare()
        {
            IShape shape = new Square {Height = 4};

            Assert.That(shape.Area(), Is.EqualTo(16));
        }
    }
}
