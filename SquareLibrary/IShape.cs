using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    /// <summary>
    /// Calculating the area of different shapes.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Calculating the area of the shape.
        /// </summary>
        /// <returns>The area of the shape.</returns>
        double CalculateArea();
    }
}
