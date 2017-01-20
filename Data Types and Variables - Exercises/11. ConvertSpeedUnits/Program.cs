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
            var distanceInMeters = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = (((hours * 60)) * 60) + (minutes * 60) + seconds;
            float timeInHours = (timeInSeconds / 60) / 60;
            float distanceInKilometers = distanceInMeters / 1000;
            float distanceInMiles = distanceInKilometers * 0.621371192f;

            Console.WriteLine(distanceInMeters / timeInSeconds);
            Console.WriteLine(distanceInKilometers / timeInHours);
            Console.WriteLine(distanceInMiles / timeInHours);
        }
    }
}
