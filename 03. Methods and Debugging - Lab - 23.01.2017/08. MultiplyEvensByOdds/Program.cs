namespace _08.MultiplyEvensByOdds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(TotalSumOfEvenAndOdd(Math.Abs(number)));
        }

        public static int TotalSumOfEvenAndOdd(int number)
        {
            int sumOfEven = GetSumOfEvenDigits(number);
            int sumOfOdd = GetSumOfOddDigits(number);
                
            return sumOfEven * sumOfOdd;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            int even = 0;

            while (number > 0)
            {
                int lastNumber = number % 10;
                if (lastNumber % 2 == 0)
                {
                    even += lastNumber;
                }

                number /= 10;
            }

            return even;
        }

        public static int GetSumOfOddDigits(int number)
        {
            var odd = 0;

            while (number > 0)
            {
                int lastNumber = number % 10;
                if (lastNumber % 2 == 1)
                {
                    odd += lastNumber;
                }

                number /= 10;
            }

            return odd;
        }
    }
}
