namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, int>();

            for (int i = 0;; i++)
            {
                var resource = Console.ReadLine();

                if (resource == "stop")
                {
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }

                    return;
                }

                if (!dictionary.ContainsKey(resource))
                {
                    dictionary[resource] = 0;
                }

                if (dictionary.ContainsKey(resource))
                {
                    var amount = int.Parse(Console.ReadLine());
                    dictionary[resource] += amount;
                }
            }
        }
    }
}
