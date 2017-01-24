namespace _03.Methods_and_Debugging___Lab
{
    using System;

    public class Program
    {
        public static void Main()
        {
            header();
            body();
            footer();
        }
        public static void header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        public static void body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
