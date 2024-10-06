namespace MyLibrary
{
    public class Triangle : Figure
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Ни одна из сторон треугольника не может иметь отрицательную длину!");
            }
            if (firstSide >= secondSide + thirdSide || secondSide >= firstSide + thirdSide || thirdSide >= firstSide + secondSide)
            {
                throw new ArgumentException("Каждая сторона треугольника должна быть меньше суммы двух других сторон!");
            }
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public override double GetSquare()
        {
            double halfMeter = (FirstSide + SecondSide + ThirdSide) / 2;
            double square = Math.Sqrt(halfMeter * (halfMeter - FirstSide) *
                (halfMeter - SecondSide) * (halfMeter - ThirdSide));
            return Math.Round(square, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True, если треугольник - прямоугольный. Иначе - false.</returns>
        public bool IsRightTriangle()
        {
            double squareFirstSide = Math.Pow(FirstSide, 2);
            double squareSecondSide = Math.Pow(SecondSide, 2);
            double squareThirdSide = Math.Pow(ThirdSide, 2);
            return squareFirstSide == squareSecondSide + squareThirdSide
                || squareSecondSide == squareFirstSide + squareThirdSide
                || squareThirdSide == squareFirstSide + squareSecondSide;
        }
    }
}
