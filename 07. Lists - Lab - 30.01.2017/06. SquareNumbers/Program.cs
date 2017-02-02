namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var newNumbers = new List<int>();

            foreach (var item in numbers)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    newNumbers.Add(item);
                }
            }

            newNumbers.Sort();
            newNumbers.Reverse();

            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
