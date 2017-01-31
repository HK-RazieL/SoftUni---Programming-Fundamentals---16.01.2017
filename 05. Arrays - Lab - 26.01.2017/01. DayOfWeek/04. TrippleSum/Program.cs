namespace _04.TrippleSum
{
    using System;
    using System.Linq;

    public class TrippleSum
    {
        public static void Main()
        {
            var arrayLength = Console.ReadLine();
            string[] array = arrayLength.Split(' ');
            var numbers = new decimal[array.Length];
            var counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var numbersInText = array[i];
                var newNumbers = decimal.Parse(numbersInText);
                numbers[i] = newNumbers;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    var sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum) && i < j)
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        counter++;
                    }                        
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
