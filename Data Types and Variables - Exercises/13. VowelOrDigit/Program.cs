using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    Console.WriteLine("digit");
                        break;
                case 'a':
                case 'o':
                case 'u':
                case 'i':
                case 'e':
                case 'y':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
