namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var factorial = Factorial(number);

            Console.WriteLine(Zeroes(factorial));
        }

        public static BigInteger Factorial(BigInteger number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int Zeroes(BigInteger number)
        {
            var zero = 0;
            for (BigInteger i = number; i > 0; i /= 10)
            {
                var zeroCheck = i % 10;
                if (zeroCheck == 0)
                {
                    zero++;
                }
                else
                {
                    break;
                }
            }

            return zero;
        }
    }
}
