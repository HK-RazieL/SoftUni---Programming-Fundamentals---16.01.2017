namespace _04.NumbersInReversedOrder
{
    using System;
    using System.Linq;

    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            var n = decimal.Parse(Console.ReadLine());

            Console.WriteLine(ConvertToString(n));
        }

        public static decimal ConvertToString(decimal n)
        {
            // LINQ solution
            //var reversedNumber = decimal.Parse(new string(n.ToString().Reverse().ToArray()));
            //return reversedNumber;

            string nString = n.ToString();
            char[] stringArray = new char[nString.Length];
           
            for (int i = nString.Length - 1, currentIndex = 0; i >= 0; i--, currentIndex++)
            {
                stringArray[currentIndex] = nString[i];
            }

            var stringResult = new string(stringArray);
            return decimal.Parse(stringResult);
        }
    }
}
