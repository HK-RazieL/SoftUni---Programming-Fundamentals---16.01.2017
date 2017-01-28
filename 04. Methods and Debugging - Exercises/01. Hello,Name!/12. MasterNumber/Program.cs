namespace _12.MasterNumber
{
    using System;
    using System.Linq;

    public class MasterNumber
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (IsPalidrome(i) && SumOfDigits(i) && ContainsEvenNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalidrome(int number)
        {
            int reverse = 0;
            int num = number;
            while (number > 0)
            {
                int lastDigit = number % 10;
                reverse = reverse * 10 + lastDigit;
                number /= 10;
            }

            if (reverse == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SumOfDigits(int number)
        {
            var numberArray = new int[number.ToString().Length];
            var sum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                var digit = number % 10;
                number /= 10;
                numberArray[i] = digit;
                sum += numberArray[i];
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ContainsEvenNumber(int number)
        {
            var counter = 0;

            for (int i = number; i > 0; i /= 10)
            {
                var firstDigit = i % 10;
                if (firstDigit % 2 == 0)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
