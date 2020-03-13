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

            var booksToPrint = library.Books.GroupBy(x => new { x.Author }).Select(g=> new { g.Key.Author, Price = g.Sum(x=> x.Price)}).OrderByDescending(o=>o.Price).ThenBy(o=>o.Author);

            foreach (var book in booksToPrint)
            {
                Console.WriteLine("{0} -> {1}", book.Author, book.Price);
            }

        }

        public static List<Book> ReadBooks(int booksCount)
        {
            var books = new List<Book>();
            for (int i = 0; i < booksCount; i++)
            {
                string[] bookData = Console.ReadLine().Split(' ').ToArray();
                var book = new Book(bookData[0], bookData[1], bookData[2], bookData[3], bookData[4], decimal.Parse(bookData[5]));
                books.Add(book);
            }
            return books;
        }
    }
}
