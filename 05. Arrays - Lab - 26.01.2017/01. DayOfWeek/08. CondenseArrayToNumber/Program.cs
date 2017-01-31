namespace Condense_Array_to_Number
{
    using System;
    using System.Linq;

    public class Condense_Array_to_Number
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (sequence.Length > 1)
            {
                int[] condensedArray = new int[sequence.Length - 1];

                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    condensedArray[i] = sequence[i] + sequence[i + 1];
                }

                sequence = condensedArray;
            }

            Console.WriteLine(sequence[0]);
        }
    }
}
