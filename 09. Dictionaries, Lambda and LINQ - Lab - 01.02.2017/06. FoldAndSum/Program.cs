namespace _06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = numbers.Length / 4;
            var leftSide = numbers.Take(k).Reverse();
            var rightSide = numbers.Reverse().Take(k).ToArray();

            var firstRow = leftSide.Concat(rightSide).ToArray();
            var secondRow = numbers.Skip(k).Take(2 * k).ToArray();

            var sum = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sum) );

        }
    }
}
