namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            var text = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList().OrderBy(x => x);
            var dict = new Dictionary<string, int>();

            foreach (var item in text)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }

                dict[item]++;
            }

            var result = new List<string>();

            foreach (var item in dict)
            {
                if (item.Key.Length < 5 && !result.Contains(item.Key))
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
