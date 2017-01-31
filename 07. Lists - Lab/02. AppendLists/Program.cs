namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split('|').ToArray();
            var result = new List<string>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = numbers[i];
                temp.Split(' ');
                result.Add(temp.Trim());
            }

            result.Reverse();

            Console.Write(string.Join(" ", result));

        }
    }
}
