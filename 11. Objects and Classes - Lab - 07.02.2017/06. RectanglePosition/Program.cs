namespace _06.RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondRectangle = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (firstRectangle[0] >= secondRectangle[0] 
                && firstRectangle[1] <= secondRectangle[1] 
                && firstRectangle[0] + firstRectangle[2] <= secondRectangle[0] + secondRectangle[2] 
                && firstRectangle[1] + firstRectangle[3] <= secondRectangle[1] + secondRectangle[3])
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
