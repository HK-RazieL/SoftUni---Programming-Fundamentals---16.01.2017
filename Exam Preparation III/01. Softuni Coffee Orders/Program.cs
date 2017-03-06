using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal total = 0;
        for (int i = 0; i < n; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());
            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            decimal totalPrice = (daysInMonth * capsulesCount) * pricePerCapsule;
            Console.WriteLine("The price for the coffee is: ${0:F2}", totalPrice);
            total += totalPrice;
        }
        Console.WriteLine("Total: ${0:F2}", total);
    }
}