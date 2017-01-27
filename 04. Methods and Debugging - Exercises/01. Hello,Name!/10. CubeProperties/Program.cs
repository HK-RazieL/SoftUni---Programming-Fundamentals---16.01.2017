namespace _10.CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeParameter = Console.ReadLine();

            Console.WriteLine($"{CubePropertie(cubeSide, cubeParameter):f2}");
        }

        public static double CubePropertie(double cubeSide, string cubeParameter)
        {
            switch (cubeParameter)
            {
                case "face":
                    var faceDiagonals = Math.Sqrt((Math.Pow(cubeSide, 2) * 2));
                    return faceDiagonals;
                case "space":
                    var spaceDiagonals = Math.Sqrt((Math.Pow(cubeSide, 2) * 3));
                    return spaceDiagonals;
                case "volume":
                    var volume = Math.Pow(cubeSide, 3);
                    return volume;
                case "area":
                    var area = Math.Pow(cubeSide, 2) * 6;
                    return area;
            }
            return 0.0;
        }
    }
}
