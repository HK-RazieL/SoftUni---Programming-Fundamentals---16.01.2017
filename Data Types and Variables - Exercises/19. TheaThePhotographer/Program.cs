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
            int picturesCount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double percentage = filterFactor / 100.0;
            int usefulPictures = (int)Math.Ceiling(picturesCount * percentage);

            long totalPictures = picturesCount * (long)filterTime;
            long uploadedPictures = usefulPictures * (long)uploadTime;

            Console.WriteLine(TimeSpan.FromSeconds(totalPictures + uploadedPictures).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
        }
    }
}
