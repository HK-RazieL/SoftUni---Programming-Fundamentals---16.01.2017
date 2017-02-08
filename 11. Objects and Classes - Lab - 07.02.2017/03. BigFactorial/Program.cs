namespace _03.BigFactorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }
    }
}
