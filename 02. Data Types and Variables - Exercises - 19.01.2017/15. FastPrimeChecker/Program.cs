using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var i = 0;
            bool result = true;

            for (i = 0; i <= number; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        result = false;
                        break;
                    }

                }

                Console.WriteLine($"{i} is prime -> {result}");
            }
        }
    }
}
