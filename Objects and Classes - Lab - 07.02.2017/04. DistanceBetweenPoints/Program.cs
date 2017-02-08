namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var pointOne = Console.ReadLine().Split().Select(double.Parse).ToList();
            var pointTwo = Console.ReadLine().Split().Select(double.Parse).ToList();

            var firstPoint = new Point();
            firstPoint.X = pointOne[0];
            firstPoint.Y = pointOne[1];

            var secondPoint = new Point();
            secondPoint.X = pointTwo[0];
            secondPoint.Y = pointTwo[1];

            Console.WriteLine($"{calculating(firstPoint, secondPoint):F3}");
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
