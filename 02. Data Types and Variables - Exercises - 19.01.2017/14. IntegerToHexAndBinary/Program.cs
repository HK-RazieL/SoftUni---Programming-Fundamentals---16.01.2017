using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var hex = Convert.ToString(number, 16).ToUpper();
            var binary = Convert.ToString(number, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
