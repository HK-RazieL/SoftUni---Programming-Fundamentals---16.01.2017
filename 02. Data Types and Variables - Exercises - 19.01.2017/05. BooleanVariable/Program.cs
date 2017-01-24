using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            if (word == "True")
            {
                Console.WriteLine("Yes");
            }
            else if(word == "False")
            {
                Console.WriteLine("No");
            }
        }
    }
}
