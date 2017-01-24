namespace _06.MathPower
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var result = ToPower(firstNumber, secondNumber);

            Console.WriteLine(result);
        }

        public static double ToPower(double firstNumber, double secondNumber)
        {
            var startingNumber = 1.0;
            for (int i = 1; i <= secondNumber; i++)
            {
                startingNumber *= firstNumber;
            }

            return startingNumber;
        }
    }
}
