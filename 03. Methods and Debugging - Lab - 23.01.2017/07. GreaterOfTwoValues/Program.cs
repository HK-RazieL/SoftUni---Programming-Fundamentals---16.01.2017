namespace _07.GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    Integer();
                    break;
                case "char":
                    Character();
                    break;
                case "string":
                    String();
                    break;
                default:
                    break;
            }
        }

        public static void Integer()
        {
            int firstSymbol = int.Parse(Console.ReadLine());
            int secondSymbol = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(firstSymbol, secondSymbol));
        }

        public static void Character()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            if (firstSymbol.CompareTo(secondSymbol) >= 0)
            {
                Console.WriteLine(firstSymbol);
            }
            else
            {
                Console.WriteLine(secondSymbol);
            }
        }

        public static void String()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            if (firstString.CompareTo(secondString) >= 0)
            {
                Console.WriteLine(firstString);
            }
            else
            {
                Console.WriteLine(secondString);
            }
        }
    }
}
