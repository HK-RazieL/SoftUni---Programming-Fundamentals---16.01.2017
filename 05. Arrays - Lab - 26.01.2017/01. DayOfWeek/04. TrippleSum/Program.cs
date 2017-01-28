namespace _04.TrippleSum
{
    using System;

    public class TrippleSum
    {
        public static void Main()
        {
            var arrayLength = Console.ReadLine();
            string[] array = arrayLength.Split(' ');
            var numbers = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                var numbersInText = array[i];
                var newNumbers = int.Parse(numbersInText);
                numbers[i] = newNumbers;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int l = 0; l < numbers.Length; l++)
                    {
                        if (numbers[i] + numbers[j] == numbers[l] && i < j)
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[l]}");
                        }
                    }
                }
            }
        }
    }
}
