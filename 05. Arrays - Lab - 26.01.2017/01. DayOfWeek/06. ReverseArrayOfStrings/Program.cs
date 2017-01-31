namespace _06.ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            var newString = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(string.Join(" ", newString.Reverse()));
        }
    }
}
