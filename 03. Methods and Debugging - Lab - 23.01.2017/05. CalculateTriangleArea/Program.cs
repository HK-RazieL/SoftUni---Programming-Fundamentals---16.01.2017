namespace _05.CalculateTriangleArea
{
    using System;

    public class CalculateTriangleArea
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            double area = TriangleArea(width, height);

            Console.WriteLine(area);
        }

        public static double TriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
