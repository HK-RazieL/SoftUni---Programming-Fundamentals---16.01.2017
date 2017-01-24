namespace _02.MaxMethod
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(firstNumber, secondNumber, thirdNumber));
        }

        public static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            int biggestFirstNumber = Math.Max(firstNumber, secondNumber);
            int biggestEndNumber = Math.Max(biggestFirstNumber, thirdNumber);

            return biggestEndNumber;
        }
    }
}
