namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var text = Console.ReadLine().Split().ToList();

                var book = new Book();
                book.Name = text[0];
                book.Author = text[1];
                book.Publisher = text[2];
                book.Date = DateTime.ParseExact(text[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ID = text[4];
                book.Price = double.Parse(text[5]);

                books.Add(book);
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in books.OrderBy(x => x.Date).ThenBy(x => x.Name))
            {
                if (item.Date > date)
                {
                    Console.WriteLine($"{item.Name} -> {item.Date:dd.MM.yyyy}");
                }
            }
        }

        public class Book
        {
            public string Name { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }

            public DateTime Date { get; set; }

            public string ID { get; set; }

            public double Price { get; set; }
        }
    }
}