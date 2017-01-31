namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var newList = new List<int>();
            var counter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    newList.Add(numbers[i]);
                    counter++;
                }
            }

            newList.Reverse();

            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(string.Join(" ", newList[i]));
            }

            if (counter == 0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
