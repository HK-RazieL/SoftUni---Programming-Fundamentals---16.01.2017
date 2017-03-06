namespace _02.Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Ladybugs
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var newPlace = 0;
            var ladybugs = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (ladybugIndexes.Contains(i))
                {
                    ladybugs[i] = 1;
                }
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                var tokens = command.Split();

                var ladybugPosition = int.Parse(tokens[0]);
                var flightLength = int.Parse(tokens[2]);


                if (ladybugPosition <= ladybugs.Length && ladybugPosition + flightLength < ladybugs.Length)
                {
                    ladybugs[ladybugPosition] = 0;
                    newPlace = ladybugPosition + flightLength;
                    ladybugs[newPlace]++;

                    if (ladybugs[newPlace] > 1 && ladybugs[newPlace + flightLength] <= ladybugs.Length - 1)
                    {
                        ladybugs[newPlace]--;
                        ladybugs[newPlace + flightLength] = 1;
                    }
                }
                else
                {
                    ladybugs[ladybugPosition]--;
                }
            }

            foreach(var ladybug in ladybugs)
            {
                Console.Write(ladybug + " ");
            }
        }
    }
}
