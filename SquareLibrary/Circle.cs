using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SquareLibrary
{
    /// <summary>
    /// Calculating the area of circle.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Calculating the area of the circle through the radius.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public double CalculateArea()
        {
            Console.WriteLine("Enter a radius");
            double radius;

            if (!Double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Radius is not number");
                return -1;
            }

            if (radius > 0)
            {
                double square = Math.Pow(radius, 2) * Math.PI;
                Console.WriteLine("Square of circle = " + square);
                return square;
            }

            Console.WriteLine("Radius is negative");
            return -1;

        }
    }
}