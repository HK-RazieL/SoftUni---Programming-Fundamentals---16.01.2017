namespace _01.CountWorkDays
{
    using System;
    using System.Linq;
    using System.Globalization;

    public class CountWorkDays
    {
        public static void Main()
        {
            var firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new DateTime[]
            {
              new DateTime(4, 01, 01),
              new DateTime(4, 03, 03),
              new DateTime(4, 05, 01),
              new DateTime(4, 05, 06),
              new DateTime(4, 05, 24),
              new DateTime(4, 09, 06),
              new DateTime(4, 09, 22),
              new DateTime(4, 11, 01),
              new DateTime(4, 12, 24),
              new DateTime(4, 12, 25),
              new DateTime(4, 12, 26),
            };

            var counter = 0;

            for (DateTime date = firstDate.Date; date <= secondDate.Date; date = date.AddDays(1))
            {
                DayOfWeek day = date.DayOfWeek;

                DateTime temp = new DateTime(4, date.Month, date.Day);

                if (!holidays.Contains(temp) && day != DayOfWeek.Saturday && day != DayOfWeek.Sunday)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
