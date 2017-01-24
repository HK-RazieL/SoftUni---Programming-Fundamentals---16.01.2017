namespace _02.SignOfIntegerNumber
{
    using System;
    public class Program
    {
        public static int number = int.Parse(Console.ReadLine());

        public static void Main()
        {

            isPositive();
            isNegative();
            isZero();
        }

        public static void isPositive()
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }

        public static void isNegative()
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }

        public static void isZero()
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
