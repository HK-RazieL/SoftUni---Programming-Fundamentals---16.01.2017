namespace _04.CharacterMultiplier
{
    using System;
    using System.Linq;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToList();

            Console.WriteLine(wtf(text[0], text[1]));
        }

        public static int wtf(string firstString, string secondString)
        {
            var index = 0;
            var result = 0;

            while (index < Math.Max(firstString.Length, secondString.Length))
            {
                if (index > secondString.Length - 1)
                {
                    result += firstString.ElementAt(index);
                }
                else if (index > firstString.Length - 1)
                {
                    result += secondString.ElementAt(index);
                }
                else
                {
                    result += firstString.ElementAt(index) * secondString.ElementAt(index);
                }
                index++;
            }

            return result;
        }
    }
}
