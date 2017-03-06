namespace _01.ConvertFrombase_10Tobase_N
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class ConvertFrombase_10Tobase_N
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            var number = text[1];
            var newNumber = new List<BigInteger>();

            while (number > 0)
            {
                var temp = number % text[0];
                number = number / text[0];
                newNumber.Add(temp);
            }

            foreach (var item in newNumber.ToArray().Reverse())
            {
                Console.Write(item);
            }
        }
    }
}
