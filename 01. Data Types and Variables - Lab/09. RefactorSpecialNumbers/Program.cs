using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int total = 0;
            int takova = 0;
            bool specialNumber = false;

            for (int i = 1; i <= number; i++)
            {

                takova = i;

                while (i > 0)
                {

                    total += i % 10;

                    i = i / 10;

                }

                specialNumber = (total == 5) || (total == 7) || (total == 11);

                Console.WriteLine($"{takova} -> {specialNumber}");

                total = 0;

                i = takova;
            }
        }
    }
}
