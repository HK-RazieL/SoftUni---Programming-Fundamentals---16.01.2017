namespace _03.LastKNumbersSums
{
    using System;

    public class LastKNumbersSums
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var k = long.Parse(Console.ReadLine());
            long sum = 1;
            var array = new long[n];
            array[0] = 1;

            for (long i = 1; i < array.Length; i++)
            {
                for (long j = i - k; j < i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += array[j];
                    }
                }
                array[i] = sum;

            }

            for (int l = 0; l < n; l++)
            {
                Console.Write(array[l] + " ");
            }
        }
    }
}
