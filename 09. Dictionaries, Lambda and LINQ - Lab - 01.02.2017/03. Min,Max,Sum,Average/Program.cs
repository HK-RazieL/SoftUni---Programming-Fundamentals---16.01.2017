namespace _03.Min_Max_Sum_Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Min_Max_Sum_Average
    {
        public static void Main()
        {
            var amount = int.Parse(Console.ReadLine());
            var array = new int[amount];

            for (int i = 0; i < array.Length; i++)
            {
                var number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            Console.WriteLine($"Sum = {array.Sum()}");
            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"Average = {array.Average()}");


        }
    }
}
