using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    for (int l = 0; l <= n - 1; l++)
                    {
                        Console.Write((char)('a' + i));
                        Console.Write((char)('a' + j));
                        Console.Write((char)('a' + l));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
