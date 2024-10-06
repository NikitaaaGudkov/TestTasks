using MyLibrary;

namespace MyLibraryTests
{
    public class CircleTests
    {
        [TestCase(10, ExpectedResult = 314.16)]
        public double GetSquare_WithValidRadius(double radius)
        {
            Circle circle = new(radius);
            return circle.GetSquare();
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void CreateCircle_WithIncorrectRadius(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}