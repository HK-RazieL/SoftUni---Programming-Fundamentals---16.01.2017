namespace _03.Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hornet_Assault
    {
        public static void Main()
        {
            var bees = Console.ReadLine().Split().Select(int.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(int.Parse).ToList();

            var hornetPower = hornets.Sum();
            var hornetsIndex = 0;

            for (int i = 0; i < bees.Count; i++)
            {
                
                if (hornetPower > bees[i])
                {
                    bees[i] = 0;
                }
                else if (hornetPower < bees[i])
                {
                    hornets[hornetsIndex] = 0;
                    bees[i] = bees[i] - hornetPower;
                    hornetsIndex++;
                    hornetPower = hornets.Sum();
                }
                else if (bees[i] == hornetPower)
                {
                    hornets[hornetsIndex] = 0;
                    bees[i] = bees[i] - hornetPower;
                    hornetsIndex++;
                    hornetPower = hornets.Sum();
                }
                
            }

            if (bees.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", bees.Where(x => x > 0)));
            }
            else if(bees.Sum() == 0)
            {
                Console.WriteLine(string.Join(" ", hornets.Where(x => x > 0)));
            }

        }
    }
}
