using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            bool special;

            for (int i = 1; i <= number; i++)
            {
                if (i % 10 + i / 10 == 5 || i % 10 + i / 10 == 7 || i % 10 + i / 10 == 11)
                {
                    special = true;
                }
                else
                {
                    special = false;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
