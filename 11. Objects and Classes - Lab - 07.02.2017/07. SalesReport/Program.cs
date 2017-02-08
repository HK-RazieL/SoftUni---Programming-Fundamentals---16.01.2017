namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            var sale = new Sale();
            var n = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine().Split().ToList();
                var tempSale = new Sale();

                tempSale.town = temp[0];
                tempSale.product = temp[1];
                tempSale.price = temp[2];
                tempSale.quantity = temp[3];

                if (!dict.ContainsKey(temp[0]))
                {
                    dict[temp[0]] = 0;
                }
                dict[temp[0]] += Calculation(temp[2], temp[3]);

            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }

        }

        public static double Calculation(string price, string quantity)
        {
            var salePrice = double.Parse(price);
            var saleQuantity = double.Parse(quantity);
            var total = salePrice * saleQuantity;

            return total;
        }
    }

    public class Sale
    {
        public string town { get; set; }
        public string product { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
    }
}
