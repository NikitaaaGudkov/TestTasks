namespace MyLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Значение радиуса должно быть больше нуля!");
            }
            Radius = radius;
        }
        public override double GetSquare()
        {
            double square = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(square, 2, MidpointRounding.AwayFromZero);
        }
    }
}
