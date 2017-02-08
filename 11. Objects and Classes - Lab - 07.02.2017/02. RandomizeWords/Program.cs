namespace _02.RandomizeWords
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RandomizeWords
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(' ');
            var rng = new Random();
            var result = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                var temp = text[i];
                var index = rng.Next(0, text.Length);
                var randomWord = text[index];
                text[i] = randomWord;
                text[index] = temp;
            }

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
