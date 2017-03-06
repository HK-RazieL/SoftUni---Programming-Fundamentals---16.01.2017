namespace Programing_Fundamentals_Exam___26._02._2017
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
            var numberOfWingFlaps = long.Parse(Console.ReadLine());
            var distanceTravel = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var rest = (numberOfWingFlaps / endurance) * 5;
            var distancePerBurst = (numberOfWingFlaps / 1000) * distanceTravel;
            var timeForDistance = numberOfWingFlaps / 100;
            var totalTime = rest + timeForDistance;

            Console.WriteLine($"{distancePerBurst:F2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
