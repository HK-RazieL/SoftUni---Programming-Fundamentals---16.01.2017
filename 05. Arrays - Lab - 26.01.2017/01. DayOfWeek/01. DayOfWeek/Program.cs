namespace _01.DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            var day = int.Parse(Console.ReadLine());

            var dayOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            switch (day)
            {
                case 1:
                    Console.WriteLine(dayOfWeek[0]);
                    break;
                case 2:
                    Console.WriteLine(dayOfWeek[1]);
                    break;
                case 3:
                    Console.WriteLine(dayOfWeek[2]);
                    break;
                case 4:
                    Console.WriteLine(dayOfWeek[3]);
                    break;
                case 5:
                    Console.WriteLine(dayOfWeek[4]);
                    break;
                case 6:
                    Console.WriteLine(dayOfWeek[5]);
                    break;
                case 7:
                    Console.WriteLine(dayOfWeek[6]);
                    break;
                default:
                    Console.WriteLine("Invalid Day!");
                    break;
            }
        }
    }
}
