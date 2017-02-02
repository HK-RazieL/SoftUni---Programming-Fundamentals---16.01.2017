namespace _04.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).Take(3).ToList().ForEach(a => Console.WriteLine(a));
        }
    }
}
