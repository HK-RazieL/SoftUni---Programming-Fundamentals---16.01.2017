namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var currentSequence = new List<int>();
            var longestSequence = new List<int>();

            for (int i = 1; i < numbers.Count; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {
                    currentSequence.Add(numbers[i - 1]);
                }
               

               
            }
        }
    }
}
