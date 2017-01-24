namespace _04.DrawAFilledSquare
{
    using System;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Top(n);
            Middle(n);
            Bottom(n);
        }

        public static void Top(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        public static void Middle(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');

                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }

        public static void Bottom(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
