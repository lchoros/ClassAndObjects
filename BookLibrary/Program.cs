using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            var library = new Library("test", ReadBooks(booksCount));
            var date = ReadDate();

            var booksToPrint = library.Books.GroupBy(x => new { x.Author }).Select(g => new { g.Key.Author, Price = g.Sum(x => x.Price) }).OrderByDescending(o => o.Price).ThenBy(o => o.Author);

            var modifiedBookLibraryToPrint = library.Books.Where(m => m.ReleaseDate > date).OrderBy(m => m.ReleaseDate).ThenBy(o => o.Title);

            //foreach (var book in booksToPrint)
            //{
            //    Console.WriteLine("{0} -> {1}", book.Author, book.Price);
            //}

            foreach (var book in modifiedBookLibraryToPrint)
            {
                Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
            }

        }

        public static DateTime ReadDate()
        {
            var date = Console.ReadLine().Split('.');
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = int.Parse(date[2]);
            return new DateTime(year, month, day);
        }

        public static List<Book> ReadBooks(int booksCount)
        {
            var books = new List<Book>();
            for (int i = 0; i < booksCount; i++)
            {
                string[] bookData = Console.ReadLine().Split(' ').ToArray();
                var book = new Book(bookData[0], bookData[1], bookData[2], DateTime.Parse(bookData[3]), bookData[4], decimal.Parse(bookData[5]));
                books.Add(book);
            }
            return books;
        }
    }
}
