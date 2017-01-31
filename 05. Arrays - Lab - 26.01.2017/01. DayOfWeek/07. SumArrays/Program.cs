namespace _07.SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var length = Math.Max(firstArray.Length, secondArray.Length);
            var sum = new int[length];

            for (int i = 0; i < length; i++)
            {
                sum[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.Write(string.Join(" ", sum));
        }
    }
}
