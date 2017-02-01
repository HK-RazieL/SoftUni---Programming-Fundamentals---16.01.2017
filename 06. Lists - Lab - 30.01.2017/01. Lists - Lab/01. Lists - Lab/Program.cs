namespace _01.Lists___Lab
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RemoveNegativesandReverse
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in list)
            {
                Console.Write(list);
            }
        }
    }
}
