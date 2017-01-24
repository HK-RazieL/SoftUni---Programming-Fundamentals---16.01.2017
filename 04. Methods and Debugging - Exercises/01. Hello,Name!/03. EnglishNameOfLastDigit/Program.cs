namespace _03.EnglishNameOfLastDigit
{
    using System;
    using System.Numerics;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            long lastDigit = LastDigit(number);
            Console.WriteLine(LastDigitName(lastDigit));
        }

        public static long LastDigit(long number)
        {
            return Math.Abs(number % 10);
        }

        public static string LastDigitName(long number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }
            return string.Empty;
        }
    }
}
