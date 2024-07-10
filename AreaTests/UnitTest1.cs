using NUnit.Framework.Internal.Execution;
using SquareLibrary;
using static System.Net.WebRequestMethods;

namespace AreaTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CurcleArea()
        {
            double radius = 5;
            double expect = 78.539816339744831d;
            IShape circle = new Circle();
            Console.SetIn(new StringReader(radius.ToString()));
            double result = circle.CalculateArea();
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void NegativeRadius()
        {
            double radius = -5;
            double expect = -1;
            IShape circle = new Circle();
            Console.SetIn(new StringReader(radius.ToString()));
            double result = circle.CalculateArea();
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void StringRadius()
        {
            string radius = " radius";
            double expect = -1;
            IShape circle = new Circle();
            Console.SetIn(new StringReader(radius.ToString()));
            double result = circle.CalculateArea();
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void TriangleArea()
        {
            double aSide = 3;
            double bSide = 3;
            double cSide = 3;
            double expect = 3.897114317029974;
            IShape triangle = new Triangle();
            string triangleString = aSide.ToString() + " " + bSide.ToString() + " " + cSide.ToString();
            Console.SetIn(new StringReader(triangleString));
            double result = triangle.CalculateArea();
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void NonexistentTriangle()
        {
            double aSide = 1;
            double bSide = 3;
            double cSide = 5;
            double expect = -1;
            IShape triangle = new Triangle();
            string triangleString = aSide.ToString() + " " + bSide.ToString() + " " + cSide.ToString();
            Console.SetIn(new StringReader(triangleString));
            double result = triangle.CalculateArea();
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void NegativeTriangle()
        {
            double aSide = 1;
            double bSide = 1;
            double cSide = 6;
            double expect = -1;
            IShape triangle = new Triangle();
            string triangleString = aSide.ToString() + " " + bSide.ToString() + " " + cSide.ToString();
            Console.SetIn(new StringReader(triangleString));
            double result = triangle.CalculateArea();
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void RectangularTriangle()
        {
            double aSide = 4;
            double bSide = 3;
            double cSide = 5;
            double expect = -1;
            Triangle triangle = new Triangle();           
            bool result = triangle.IsRectangular(aSide, bSide, cSide);
            Assert.True(result);
        }

        [Test]
        public void StringTriangle()
        {
            string aSide = "a";
            string bSide = "b";
            string cSide = "c";
            double expect = -1;
            IShape triangle = new Triangle();
            string triangleString = aSide.ToString() + " " + bSide.ToString() + " " + cSide.ToString();
            Console.SetIn(new StringReader(triangleString));
            double result = triangle.CalculateArea();
            Assert.AreEqual(expect, result);
        }
    }
}