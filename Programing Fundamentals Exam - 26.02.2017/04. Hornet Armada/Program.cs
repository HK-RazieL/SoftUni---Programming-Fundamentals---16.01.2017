namespace _04.Hornet_Armada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Hornet_Armada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var regex = new Regex(@"(\d+)\s=\s([^=->:\s]+)\s->\s([^=->:\s]+):(\d+)");
            var army = new List<Army>();
            Army armyList = new Army();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var legions = regex.Match(input);

                var activity = int.Parse(legions.Groups[1].Value);
                var legionName = legions.Groups[2].Value;
                var soldierType = legions.Groups[3].Value;
                var soldierCount = int.Parse(legions.Groups[4].Value);

                armyList = new Army();
                armyList.activity = activity;
                armyList.legionName = legionName;
                armyList.soldierType = soldierType;
                armyList.soldierCount = soldierCount;

                army.Add(armyList);
                army.GroupBy(x => x.legionName);


            }

            var sortingActivity = 0;
            var sorting = Console.ReadLine().Split('\\').ToArray();
            var sortingType = string.Empty;


            if (sorting.Length > 1)
            {
                sortingActivity = int.Parse(sorting[0]);
                sortingType = sorting[1];
            }
            else
            {
                sortingType = sorting[0];
            }

            List<Army> results = army.FindAll(x => x.soldierType == sortingType);

            foreach (var legion in army.Where(x => x.soldierType == sortingType))
            {
                if (army.Where(x => x.activity < sortingActivity).Any())
                {
                    Console.WriteLine($"{legion.legionName} -> {legion.soldierCount}");

                }
            }
        }
    }

    public class Army
    {
        public int activity { get; set; }

        public string legionName { get; set; }

        public string soldierType { get; set; }

        public int soldierCount { get; set; }
    }
}

