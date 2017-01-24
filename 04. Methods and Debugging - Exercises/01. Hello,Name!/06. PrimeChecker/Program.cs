namespace _06.PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);

            Console.WriteLine(IsPrime(n));
        }

        public static bool IsPrime(long n)
        {
            var isPrime = true;

            if (n == 0 || n == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
