namespace _02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            for (int i = 0;; i++)
            {
                var text = Console.ReadLine().Split().ToList();

                if (text[0] == "A")
                {
                    phonebook[text[1]] = text[2];
                }

                if (text[0] == "S" && phonebook.ContainsKey(text[1]))
                {
                    var name = text[1];
                    Console.WriteLine($"{text[1]} -> {phonebook[name]}");
                }
                else if (text[0] == "S" && !phonebook.ContainsKey(text[1]))
                {
                    Console.WriteLine($"Contact {text[1]} does not exist.");
                }

                if (text[0] == "ListAll")
                {
                    foreach (var item in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                if (text[0] == "END")
                {
                    return;
                }
            }
        }
    }
}
