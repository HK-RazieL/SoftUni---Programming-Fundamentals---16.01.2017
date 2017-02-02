namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var currentSequence = new List<double>();
            var longestSequence = new List<double>();

            for (int i = 0; i < numbers.Count - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    currentSequence.Add(numbers[i]);

                    if (i == numbers.Count - 2)
                    {
                        currentSequence.Add(numbers[i]);
                    }
                }
                else if (currentSequence.Contains(numbers[i]))
                {
                    currentSequence.Add(numbers[i]);

                    if (numbers[i] != numbers[i + 1] && currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence.Clear();
                        longestSequence.AddRange(currentSequence);
                        currentSequence.Clear();
                    }

                    currentSequence.Clear();
                }
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                Console.WriteLine(string.Join(" ", currentSequence));
            }
            else if (currentSequence.Count == 0)
            {
                currentSequence.Add(numbers[0]);
                Console.WriteLine(string.Join(" ", currentSequence));
            }

            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}