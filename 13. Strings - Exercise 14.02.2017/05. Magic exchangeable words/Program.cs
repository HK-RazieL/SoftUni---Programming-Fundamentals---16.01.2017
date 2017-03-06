namespace _05.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToArray();

            var longer = Math.Max(text[0].Length, text[1].Length);
            var shorter = Math.Min(text[0].Length, text[1].Length);

            var leftSide = text[0].Length >= text[1].Length ? text[0] : text[1];
            var rightSide = text[0].Length < text[1].Length ? text[0] : text[1];


            var dict = new Dictionary<char, char>();

            var match = true;

            for (int i = 0; i < leftSide.Length; i++)
            {
                if (dict.ContainsKey(leftSide[i]) && i >= rightSide.Length)
                {
                    continue;
                }

                if (!dict.ContainsKey(leftSide[i]) && i < rightSide.Length)
                {
                    dict[leftSide[i]] = rightSide[i];
                }

                if (!dict.ContainsKey(leftSide[i]) && i >= rightSide.Length)
                {
                    match = false;
                }

                if (dict.ContainsKey(leftSide[i]) && dict[leftSide[i]] != rightSide[i])
                {
                    match = false;
                }

            }

            if (match)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
