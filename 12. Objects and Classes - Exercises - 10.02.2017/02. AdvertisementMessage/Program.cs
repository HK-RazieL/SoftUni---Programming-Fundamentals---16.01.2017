namespace _02.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var rng = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{Phrases(rng.Next(0,6))} {Events(rng.Next(0,6))} {Author(rng.Next(0, 8))} - {City(rng.Next(0, 5))}");
            }
        }

        public static string Phrases(int number)
        {
            var list = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            return list[number];
        }

        public static string Events(int number)
        {
            var list = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            return list[number];
        }

        public static string Author(int number)
        {
            var list = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            return list[number];
        }

        public static string City(int number)
        {
            var list = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            return list[number];
        }
    }
}
