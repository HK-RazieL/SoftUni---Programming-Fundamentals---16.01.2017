namespace _5.BombNumbers
{
    using System;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var specialNumber = bomb[0];
            var power = bomb[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    int leftPower = Math.Max(i - power, 0);
                    int rightPower = Math.Min(i + power, numbers.Count - 1);

                    numbers.RemoveRange(i, rightPower - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftPower, i - leftPower);

                    i = 0;
                }
            }

            Console.WriteLine(string.Join("", numbers.Sum()));
        }
    }
}
