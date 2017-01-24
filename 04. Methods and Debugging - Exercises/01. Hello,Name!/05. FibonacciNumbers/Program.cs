namespace _05.FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            var newVar = Fibonacci(n);

            Console.WriteLine(newVar);
            Console.WriteLine(Fibonacci(n));
        }

        public static long Fibonacci(long n)
        {
            int firstNumber = 1;
            int secondNumber = 1;

            for (long i = 2; i <= Math.Abs(n); i++)
            {
                var thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            return secondNumber;
        }
    }
}
