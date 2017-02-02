namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var separator = new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };
            var firstString = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            foreach (var word in firstString)
            {
                if (word.All(char.IsUpper))
                {
                    upperCase.Add(word);
                }
                else if (word.All(char.IsLower))
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
