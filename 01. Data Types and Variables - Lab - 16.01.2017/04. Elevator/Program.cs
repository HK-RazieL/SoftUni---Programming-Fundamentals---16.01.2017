using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = double.Parse(Console.ReadLine());
            var capacity = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(people / capacity));
        }
    }
}
