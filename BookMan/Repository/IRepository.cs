using BookMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMan.Repository
{
    public interface IRepository
    {
        public HashSet<Book> Books { get; set; }
        public Book GetBookById(int bookId);
    }
}
