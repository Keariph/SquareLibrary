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
        public void Square()
        {
            Console.WriteLine("Enter a radius");
            double radius = Double.Parse(Console.ReadLine());
            double square = radius * Math.PI;
            Console.WriteLine("Square of circle = " + square);
        }  
    }
}