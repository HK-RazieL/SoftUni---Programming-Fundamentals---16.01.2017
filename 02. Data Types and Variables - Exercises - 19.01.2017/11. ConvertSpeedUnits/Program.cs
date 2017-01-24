using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            float timeInSeconds = (((hours * 60)) * 60) + (minutes * 60) + seconds;
            float timeInHours = (timeInSeconds / 60) / 60;
            float distanceInKilometers = distanceInMeters / 1000;
            float distanceInMiles = distanceInMeters / 1609;

            float metersPerSecond = (distanceInMeters / timeInSeconds);
            float kilometersPerHour = distanceInKilometers / timeInHours;
            float milesPerHour = distanceInMiles / timeInHours;

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
