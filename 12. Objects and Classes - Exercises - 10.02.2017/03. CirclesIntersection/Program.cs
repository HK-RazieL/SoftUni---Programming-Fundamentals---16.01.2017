namespace _03.CirclesIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstPoint = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPoint = Console.ReadLine().Split().Select(int.Parse).ToList();

            var firstPointPosition = new Point();
            firstPointPosition.X = firstPoint[0];
            firstPointPosition.Y = firstPoint[1];
            firstPointPosition.Radius = firstPoint[2];

            var secondPointPosition = new Point();
            secondPointPosition.X = secondPoint[0];
            secondPointPosition.Y = secondPoint[1];
            secondPointPosition.Radius = secondPoint[2];

            if (Distance(firstPointPosition, secondPointPosition) <= firstPointPosition.Radius + secondPointPosition.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        public static double Distance(Point firstPoint, Point secondPoint)
        {
            var distance = Math.Sqrt(Math.Pow((secondPoint.X - firstPoint.X), 2) + Math.Pow((secondPoint.Y - firstPoint.Y), 2));

            return distance;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
    }
}
