namespace _01.CharityMarathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var marathonLength = decimal.Parse(Console.ReadLine());
            var numberOfRunners = decimal.Parse(Console.ReadLine());
            var numberOfLaps = decimal.Parse(Console.ReadLine());
            var lengthOfTheTrack = decimal.Parse(Console.ReadLine());
            var capacity = decimal.Parse(Console.ReadLine());
            var moneyDonated = double.Parse(Console.ReadLine());

            decimal runners = capacity * marathonLength >= numberOfRunners ? numberOfRunners : capacity * marathonLength;
            decimal totalMeters = numberOfLaps * lengthOfTheTrack * runners;
            decimal totalKilometers = totalMeters / 1000;
            decimal totalMoney = totalKilometers * (decimal)moneyDonated;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
