namespace _05.ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine().Split().Select(int.Parse).ToList();
                var tempPoint = new Point();

                tempPoint.X = temp[0];
                tempPoint.Y = temp[1];

                points.Add(tempPoint);
            }

            var minDistance = double.MaxValue;
            var closestPair = double.MaxValue;
            var closestFirstPoint = new Point();
            var closestSecondPoint = new Point();

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    minDistance = calculating(points[i], points[j]);

                    if (minDistance < closestPair)
                    {
                        closestPair = minDistance;
                        closestFirstPoint = points[i];
                        closestSecondPoint = points[j];
                    }
                }
            }

            Console.WriteLine($"{closestPair:F3}");
            Console.WriteLine($"({closestFirstPoint.X}, {closestFirstPoint.Y})");
            Console.WriteLine($"({closestSecondPoint.X}, {closestSecondPoint.Y})");

        }

        public static double calculating(Point firstPoint, Point secondPoint)
        {
            var sideA = firstPoint.X - secondPoint.X;
            var sideB = firstPoint.Y - secondPoint.Y;
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }
}
