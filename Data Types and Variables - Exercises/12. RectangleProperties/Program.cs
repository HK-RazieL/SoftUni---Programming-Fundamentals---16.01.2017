using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;
            var diagonal = Math.Pow(width,2) + Math.Pow(height, 2);
            var perimeter = 2 * (width + height);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(Math.Sqrt(diagonal));
        }
    }
}
