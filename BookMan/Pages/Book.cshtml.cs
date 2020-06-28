using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMan.Models;
using BookMan.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookMan
{
    public class BookModel : PageModel
    {
        private readonly IRepository _repository;
        public HashSet<Book> Books => _repository.Books;
        public Book Book { get; set; } = new Book();
        public BookModel(IRepository repository)
        {
            _repository = repository;
        }
        public void OnGet(int id)
        {
            Book = _repository.Detail(id);
        }

        public IActionResult OnPostUpdate(Book book)
        {
            if (_repository.Detail(book.Id) != null)
            {
                _repository.Detail(book.Id).Title = book.Title;
                _repository.Detail(book.Id).Category = book.Category;
                _repository.Detail(book.Id).Authors = book.Authors;
                _repository.Detail(book.Id).Publisher = book.Publisher;
                _repository.Detail(book.Id).Year = book.Year;
                _repository.Detail(book.Id).Price = book.Price;
                _repository.Detail(book.Id).Description = book.Description;
            }
            return Redirect("/");
        }

        public IActionResult OnPostDelete(int id)
        {
            if (_repository.Detail(id) != null)
            {
                _repository.Books.Remove(_repository.Detail(id));
            }
            return Redirect("/");
        }
    }
}