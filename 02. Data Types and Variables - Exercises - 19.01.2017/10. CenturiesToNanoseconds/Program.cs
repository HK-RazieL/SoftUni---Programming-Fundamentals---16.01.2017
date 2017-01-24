using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            long seconds = minutes * 60;
            ulong milliseconds = (ulong)seconds * 1000;
            ulong microseconds = (ulong)milliseconds * 1000;
            ulong nanoseconds = (ulong)microseconds * 1000u;
            Console.WriteLine($"{centuries} Centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
