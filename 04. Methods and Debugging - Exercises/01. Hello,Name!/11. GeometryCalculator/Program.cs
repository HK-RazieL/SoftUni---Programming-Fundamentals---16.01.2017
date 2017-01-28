namespace _11.GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            var figure = Console.ReadLine();

            switch (figure)
            {
                case "triangle":
                    var triangleSide = double.Parse(Console.ReadLine());
                    var triangleHeight = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{TriangleArea(triangleSide, triangleHeight):f2}");
                    break;
                case "square":
                    var squareSide = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{SquareArea(squareSide):f2}");
                    break;
                case "rectangle":
                    var rectangleWidth = double.Parse(Console.ReadLine());
                    var rectangleHeight = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{RectangleArea(rectangleWidth, rectangleHeight):f2}");
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{CircleArea(radius):f2}");
                    break;
                default:
                    break;
            }
        }

        public static double TriangleArea(double triangleSide, double triangleHeight)
        {
            var area = (triangleSide * triangleHeight) / 2;

            return area;
        }

        public static double SquareArea(double squareSide)
        {
            var area = squareSide * squareSide;

            return area;
        }

        public static double RectangleArea(double rectangleWidth, double rectangleHeight)
        {
            var area = rectangleWidth * rectangleHeight;

            return area;
        }

        public static double CircleArea(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
