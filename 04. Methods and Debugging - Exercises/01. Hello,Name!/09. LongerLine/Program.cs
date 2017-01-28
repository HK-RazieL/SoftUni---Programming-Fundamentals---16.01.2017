namespace _09.LongerLine
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            Console.WriteLine(ClosestPoint(x1, y1, x2, y2, x3, y3, x4, y4));
        }

        public static string ClosestPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstPoint = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            double thirdPoint = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            double fourthPoint = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            double firstLine = firstPoint + secondPoint;
            double secondLine = thirdPoint + fourthPoint;

            double longestLine = Math.Max(firstLine, secondLine);

            if (longestLine == firstLine)
            {
                if (firstPoint <= secondPoint)
                {
                    return $"({x1}, {y1})({x2}, {y2})";
                }
                else
                {
                    return $"({x2}, {y2})({x1}, {y1})";
                }
            }
            else if (longestLine == secondLine)
            {
                if (thirdPoint <= fourthPoint)
                {
                    return $"({x3}, {y3})({x4}, {y4})";
                }
                else
                {
                    return $"({x4}, {y4})({x3}, {y3})";
                }
            }
            else if (firstLine == secondLine)
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }

            return string.Empty;
        }
    }
}
