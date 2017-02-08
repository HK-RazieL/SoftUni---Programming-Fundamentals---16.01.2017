namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AMinerTask
    {
        public static void Main()
        {
            var mail = string.Empty;
            var dictionary = new Dictionary<string, string>();

            for (int i = 0; ; i++)
            {
                var name = Console.ReadLine();

                if (name == "stop")
                {
                    foreach (var item in dictionary)
                    {
                        if (!item.Value.EndsWith(".us") && !item.Value.EndsWith(".uk"))
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }
                    return;
                }

                mail = Console.ReadLine();

                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = string.Empty;
                }

                if (dictionary.ContainsKey(name))
                {
                    dictionary[name] = mail;
                }
            }
        }
    }
}
