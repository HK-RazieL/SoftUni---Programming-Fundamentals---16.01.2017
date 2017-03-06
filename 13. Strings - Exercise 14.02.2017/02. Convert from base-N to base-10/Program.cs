using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ConvertFromBase_NTobase_10
{
    public class ConvertFromBase_NTobase_10
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            var baseNumber = text[0];
            var number = text[1];
            var index = 0;
            BigInteger newNumber = 0;

            while (number > 0)
            {
                var firstDigit = number % 10;
                var nextDigitInList = firstDigit * BigInteger.Pow(baseNumber, index);
                newNumber += nextDigitInList;
                number = number / 10;
                index++;
            }

            Console.WriteLine(newNumber);
        }
    }
}

