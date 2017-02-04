namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var stats = new Dictionary<string, List<string>>();

            for (int i = 0; ; i++)
            {
                var text = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = text[0];

                if (text[0] == "JOKER")
                {
                    foreach (var item in stats)
                    {
                        Console.WriteLine($"{item.Key}: {TotalPoints(item.Value)}");
                    }
                    return;
                }

                var cards = text[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                if (stats.ContainsKey(name))
                {
                    stats[name].AddRange(cards);
                }

                if (!stats.ContainsKey(name))
                {
                    stats.Add(name, cards);
                }
            }
        }

        public static int TotalPoints(List<string> cards)
        {
            var totalHand = new List<int>();

            for (int j = 0; j < cards.Count; j++)
            {
                var points = cards[j];
                var power = CardPower(points) * CardColor(points);
                totalHand.Add(power);
            }
            return totalHand.Sum();
        }

        public static int CardColor(string color)
        {
            var cardColor = color[1].ToString();

            if (cardColor == "0")
            {
                cardColor = color[2].ToString();
            }

            switch (cardColor)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
            }

            return 0;
        }

        public static int CardPower(string power)
        {
            var cardPower = power[0].ToString();

            switch (cardPower)
            {
                case "1":
                    return 10;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
            }
            return 0;
        }
    }
}