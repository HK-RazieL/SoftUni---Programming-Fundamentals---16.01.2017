using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            var ID = int.Parse(Console.ReadLine());
            var employeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {ID}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");
        }
    }
}
