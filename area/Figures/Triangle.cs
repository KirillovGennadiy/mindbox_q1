using System;
using System.Collections.Generic;
using System.Linq;

namespace Area.Models
{
    public class Triangle : IFigure
    {
        public readonly double A, B, C;
        public readonly bool IsSquare;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be greater than 0");
            }

            double[] sidesArr = new double[] { a, b, c };
            Array.Sort(sidesArr);
            
            if (sidesArr[0] + sidesArr[1] < sidesArr[2])
            {
                throw new ArgumentException("Triangle doesn't exist");
            }

            A = sidesArr[0];
            B = sidesArr[1];
            C = sidesArr[2];

            IsSquare = Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
        }

        public double GetArea()
        {
            if (IsSquare)
            {
                return (A * B) / 2;
            } 
            else
            {
                double semiPerimetr = (A + B + C) / 2;
                return Math.Sqrt(semiPerimetr * (semiPerimetr - A) * (semiPerimetr - B) * (semiPerimetr - C));
            }
        }
    }
}
