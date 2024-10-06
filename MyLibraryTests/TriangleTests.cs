using MyLibrary;
using System.Drawing;

namespace MyLibraryTests
{
    public class TriangleTests
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        public void CreateTriangle_WithNegativeOrZeroSides(double firstSide, double secondSide, double thirdSide)
        {
            var exception = Assert.Catch<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
            Assert.That(exception.Message, Is.EqualTo("Ни одна из сторон треугольника не может иметь отрицательную длину!"));
        }

        [TestCase(10, 5, 5)]
        [TestCase(5, 10, 5)]
        [TestCase(5, 5, 10)]
        [TestCase(10, 1, 1)]
        [TestCase(1, 10, 1)]
        [TestCase(1, 1, 10)]
        public void CreateTriangle_WithIncorrectSideLengthRatios(double firstSide, double secondSide, double thirdSide)
        {
            var exception = Assert.Catch<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
            Assert.That(exception.Message, Is.EqualTo("Каждая сторона треугольника должна быть меньше суммы двух других сторон!"));
        }

        [TestCase(3, 4, 5, ExpectedResult = 6)]
        public double GetSquare_WithValidSides(double firstSide, double secondSide, double thirdSide)
        {
            Triangle triangle = new(firstSide, secondSide, thirdSide);
            return triangle.GetSquare();
        }


        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(1, 1, 1, ExpectedResult = false)]
        public bool IsRightTriangle(double firstSide, double secondSide, double thirdSide)
        {
            Triangle triangle = new(firstSide, secondSide, thirdSide);
            return triangle.IsRightTriangle();
        }
    }
}
