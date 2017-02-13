namespace _5.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibrary
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var librery = new Librery();
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

            var grouped = books.GroupBy(x => x.Author);

            var libraries = grouped.Select(group => new Librery()
            {
                Name = group.Key,
                Books = group.ToList()
            })
            .OrderByDescending(library => library.Books.Sum(a => a.Price))
            .ThenBy(a => a.Name)
            .ToArray();

            foreach (var item in libraries)
            {
                Console.WriteLine($"{item.Name} -> {item.Books.Sum(a => a.Price):F2}");
            }
        }
    }

    public class Librery
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
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