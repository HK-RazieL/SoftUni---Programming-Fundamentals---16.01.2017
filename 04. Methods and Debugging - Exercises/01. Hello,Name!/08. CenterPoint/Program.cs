namespace _08.CenterPoint
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"({ClosestPoint(x1, y1, x2, y2)})");
        }

        public static string ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            double closestPoint = Math.Min(firstPoint, secondPoint);

            if (closestPoint == firstPoint)
            {
                return $"{x1}, {y1}";
            }
            else if (closestPoint == secondPoint)
            {
                return $"{x2}, {y2}";
            }
            else if (firstPoint == secondPoint)
            {
                return $"{x1}, {y1}";
            }

            return string.Empty;
        }
    }
}
