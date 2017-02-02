namespace _04.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            Console.WriteLine(Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(string.Join("", x.Reverse())))
                .Sum());
        }
    }
}
