using BookMan.Enums;
using BookMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMan.Repository
{
    public class BookRepository : IRepository
    {
        public HashSet<Book> Books { get; set; } = new HashSet<Book>
        {
            new Book {Id = 1, Title = "ASP.NET Core for dummy",Publisher = "Apress", Year = 2018, Authors = "Donald Trump", Price = 4.5, Category = Enum.GetName(typeof(CategoryEnum), 1)},
            new Book {Id = 2, Title = "Professional ASP.NET Core 3",Publisher = "Manning", Year = 2019, Authors = "Bill Clinton", Price = 6.5, Category = Enum.GetName(typeof(CategoryEnum), 1)},
            new Book {Id = 3, Title = "ASP.NET Core Self learning",Publisher = "Wiley", Year = 2017,Authors = "Barack Obama", Price = 7, Category = Enum.GetName(typeof(CategoryEnum), 1)},
            new Book {Id = 4, Title = "ASP.NET Core quick course",Publisher = "Linda",Authors = "George Bush", Price = 80, Category = Enum.GetName(typeof(CategoryEnum), 1), Description = "This book is most expensive"},
            new Book {Id = 5, Title = "ASP.NET Core Video Course",Publisher = "Linda", Authors = "Vladimir Putin", Price = 30, Category = Enum.GetName(typeof(CategoryEnum), 1)},
        };
        public Book Detail(int id) => Books.SingleOrDefault(b => b.Id == id);
    }
}
