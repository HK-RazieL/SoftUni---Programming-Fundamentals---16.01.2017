using System;
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
            var number = long.Parse(Console.ReadLine());

            Console.WriteLine($"{number} can fit in:");

            if (number >= -128 && number <= 127)
                {
                    Console.WriteLine("* sbyte");
                }

                if (number >= -32768 && number <= 32767)
                {
                    Console.WriteLine("* short");
                }

                if (number >= 0 && number <= 255)
                {
                    Console.WriteLine("* byte");
                }

                if (number >= 0 && number <= 65535)
                {
                    Console.WriteLine("* ushort");
                }

                if (number >= -2147483648 && number <= 2147483647)
                {
                    Console.WriteLine("* int");
                }

                if (number >= 0 && number <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }

                if (number >= -9223372036854775808 && number <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }

                if (number < -9223372036854775808 && number > 9223372036854775807)
                {
                  Console.WriteLine(number);
                Console.WriteLine("can't fit in any type");
                }
            }
        }
    }

