using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }
    }
}
