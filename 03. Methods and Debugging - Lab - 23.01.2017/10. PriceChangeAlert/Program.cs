using System;

public class PriceChangeAlert
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double limit = double.Parse(Console.ReadLine());
        double previousPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());
            double different = PercentDifference(previousPrice, newPrice);
            bool isSignificantDifference = Difference(different, limit);
            string message = Get(newPrice, previousPrice, different, isSignificantDifference);

            Console.WriteLine(message);

            previousPrice = newPrice;
        }
    }

    private static string Get(double newPrice, double previousPrice, double different, bool isTrue)
    {
        string message = string.Empty;

        if (different == 0)
        {
            message = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!isTrue)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, newPrice, different * 100.0);
        }
        else if (isTrue && (different > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, newPrice, different * 100.0);
        }
        else if (isTrue && (different < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, newPrice, different * 100.0);
        }

        return message;
    }

    private static bool Difference(double limit, double different)
    {
        if (Math.Abs(limit) >= different)
        {
            return true;
        }

        return false;
    }

    private static double PercentDifference(double previousPrice, double newPrice)
    {
        double percentage = (newPrice - previousPrice) / previousPrice;
        return percentage;
    }
}
