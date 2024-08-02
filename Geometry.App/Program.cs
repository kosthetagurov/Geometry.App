using Geometry.Lib.Abstractions;
using Geometry.Lib.Figures;

namespace Geometry.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double radius = 5.0;
            var circle = new Circle(radius);
            var circleArea = circle.CalculateArea();

            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            var triangle = new Triangle(sideA, sideB, sideC);   
            var triangleArea = triangle.CalculateArea();
            var isRightTriangle = triangle.IsRight();

            Console.ReadKey();
        }
    }
}
