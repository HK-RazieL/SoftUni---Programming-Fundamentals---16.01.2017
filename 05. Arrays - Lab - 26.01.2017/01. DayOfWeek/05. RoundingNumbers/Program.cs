namespace _05.RoundingNumbers
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            var array = new double[numbers.Length];


            for (int i = 0; i < array.Length; i++)
            {
                var digits = numbers[i];
                var newNumbers = double.Parse(digits);
                array[i] = newNumbers;

                if (array[i] < 0)
                {
                    Console.WriteLine($"{array[i]} => {Math.Round(array[i], MidpointRounding.AwayFromZero)}");
                }
                else if(array[i] > 0)
                {
                    Console.WriteLine($"{array[i]} => {Math.Round(array[i], MidpointRounding.AwayFromZero)}");
                }
                if (array[i] == 0)
                {
                    Console.WriteLine($"{array[i]} => 0");
                }
            }
        }
    }
}
