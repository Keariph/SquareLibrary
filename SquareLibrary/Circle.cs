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
    public class Circle : IShape
    {
        public double Area()
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