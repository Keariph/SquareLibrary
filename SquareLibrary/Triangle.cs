using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    /// <summary>
    /// Calculating the area of triangle.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Calculating the area of the shape through the three sides.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public double CalculateArea()
        {
            Console.WriteLine("Enter three sides(a b c)");
            string[] sides = Console.ReadLine().Split(' ');
            double[] doubleSides = new double[sides.Length];


            for (int i = 0; i < doubleSides.Length; i++)
            {
                if (!Double.TryParse(sides[i], out doubleSides[i]))
                {
                    Console.WriteLine($"The {i + 1}th side of triangle is not number");
                    return -1;
                }
            }

            double aSide = doubleSides[0];
            double bSide = doubleSides[1];
            double cSide = doubleSides[2];
            double[] sortedSides = doubleSides.Select(x => x).OrderBy(x => x).ToArray();

            if (sortedSides[0] + sortedSides[1] <= sortedSides[2])
            {
                Console.WriteLine("This triangle is not exist");
                return -1;
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
                return Math.Sqrt(squareS);
            }
            return -1;
        }

        /// <summary>
        /// Define that the triangle is rectangular.
        /// </summary>
        /// <param name="aSide">The A side</param>
        /// <param name="bSide">The B side</param>
        /// <param name="cSide">The C side</param>
        /// <returns>True or false</returns>
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
