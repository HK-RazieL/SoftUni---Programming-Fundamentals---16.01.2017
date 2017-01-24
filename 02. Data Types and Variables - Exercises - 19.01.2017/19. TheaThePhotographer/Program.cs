using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPhotos = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var timeToFIlter = filterTime * numberOfPhotos;
            var picturesToUpload = (Math.Ceiling((numberOfPhotos * filterFactor) / 100.0) * uploadTime);
            var seconds = (timeToFIlter + picturesToUpload);
            var minutes = 0;
            var hours = 0;
            var days = 0;

            var totalSeconds = seconds;

            for (totalSeconds = seconds; totalSeconds >= 60; totalSeconds-=60)
            {
                minutes++;
            }
            var totalMinutes = minutes;

            for (totalMinutes = minutes; totalMinutes >= 60; totalMinutes-=60)
            {
                hours++;
            }
            var totalHours = hours;

            for (totalHours = hours; totalHours >= 24; totalHours-=24)
            {
                days++;
            }
            Console.WriteLine($"{days}:{totalHours:00}:{totalMinutes:00}:{totalSeconds:00}");
        }
    }
}
