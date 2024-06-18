using SquareLibrary;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape triangle = new Triangle();
            circle.Area();
            triangle.Area();
        }
    }
}
