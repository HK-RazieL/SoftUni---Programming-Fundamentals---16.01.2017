using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            if (number < long.MinValue || number > long.MaxValue)
            {
                Console.Write(number);
                Console.WriteLine(" can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{number} can fit in:");

                if (number >= -128 && number <= 127)
                {
                    Console.WriteLine("* sbyte");
                }

                if (number >= 0 && number <= 255)
                {
                    Console.WriteLine("* byte");
                }

                if (number >= -32768 && number <= 32767)
                {
                    Console.WriteLine("* short");
                }

                if (number >= 0 && number <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }

                if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }

                if (number >= 0 && number <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }

                if (number >= long.MinValue && number <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }

        }
    }
}

