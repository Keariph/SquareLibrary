using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public class Triangle : IShape
    {
        public void Square()
        {
            Console.WriteLine("Enter three sides(a b c)");
            string[] sides = Console.ReadLine().Split(' ');
            double[] doubleSides = new double[sides.Length];
            double aSide = doubleSides[0];
            double bSide = doubleSides[1];
            double cSide = doubleSides[2];

            for (int i = 0; i < doubleSides.Length; i++)
            {
                doubleSides[i] = Double.Parse(sides[i]);

            }

            double[] sortedSides = doubleSides.Select(x => x).OrderBy(x => x).ToArray();

            if (sortedSides[0] + sortedSides[1] <= sortedSides[2])
            {
                Console.WriteLine("This triangle is not exist");
            }
            if (sortedSides[0] + sortedSides[1] > sortedSides[2])
            {
                if (IsRectangular(aSide, bSide, cSide))
                {
                    Console.WriteLine("This triangle is rectangular");
                }

                double halfPerimeter = (aSide + bSide + cSide) / 2;
                double squareS = halfPerimeter * (halfPerimeter - aSide) * (halfPerimeter - bSide) * (halfPerimeter - cSide);
                Console.WriteLine("Square of triangle = " + Math.Sqrt(squareS));
            }
        }

        public bool IsRectangular(double aSide, double bSide, double cSide) 
        {
            if (Math.Pow(aSide, 2) + Math.Pow(bSide, 2) == Math.Pow(cSide, 2))
            {
                return true;
            }
            return false;
        }
    }
}
