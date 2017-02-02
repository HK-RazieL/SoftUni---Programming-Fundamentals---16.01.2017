namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (!counts.ContainsKey(item))
                {
                    counts[item] = 0;
                }
                counts[item]++;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
