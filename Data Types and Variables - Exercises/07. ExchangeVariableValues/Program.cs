using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstVariable = int.Parse(Console.ReadLine());
            var secondVariable = int.Parse(Console.ReadLine());
            var thirdVariable = firstVariable;
            var fourthVariable = secondVariable;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstVariable}");
            Console.WriteLine($"b = {secondVariable}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {secondVariable}");
            Console.WriteLine($"b = {firstVariable}");


        }
    }
}
