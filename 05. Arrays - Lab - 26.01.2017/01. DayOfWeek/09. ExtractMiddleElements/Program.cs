namespace _09.ExtractMiddleElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractMiddleElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int middle = numbers.Count / 2;
            int middleEven = numbers.Count / 2 - 1;
            int middleOdd = numbers.Count / 2 + 1;


            if (numbers.Count == 1)
            { 
                Console.WriteLine(numbers[0]);
            }
            else if (numbers.Count % 2 == 0)
            {
                string even = $"{{ {string.Join(", ", numbers[middleEven], numbers[middle])} }}";

                Console.WriteLine(even);
            }
            else if (numbers.Count % 2 != 0)
            {
                string odd = $"{{ {string.Join(", ", numbers[middleEven], numbers[middle], numbers[middleOdd])} }}";

                Console.WriteLine(odd);
            }

        }
    }
}
