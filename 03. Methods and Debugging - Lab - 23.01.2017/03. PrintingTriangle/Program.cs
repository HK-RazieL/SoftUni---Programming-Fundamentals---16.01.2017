namespace _03.PrintingTriangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            Triangle(number);
            TriangleBottom(number);
        }

        public static int Triangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($" {j}");
                }

                Console.WriteLine();
            }

            return 0;
        }

        public static int TriangleBottom(int number)
        {
            for (int i = number - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($" {j}");
                }

                Console.WriteLine();
            }

            return 0;
        }
    }
}
