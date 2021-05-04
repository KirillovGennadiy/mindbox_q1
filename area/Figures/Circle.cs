using System;

namespace Area.Models
{
    public class Circle : IFigure
    {
        public readonly double Radius;

        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0");
            }

            Radius = r;
        }

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
