namespace _01.Hello_Name_
{
    using System;

    public class Hello_Name
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            Greeting(name);
        }

        public static void Greeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
