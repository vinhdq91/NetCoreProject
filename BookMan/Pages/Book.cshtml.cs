using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMan.Enums;
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
        public int ActionType { get; set; }
        public BookModel(IRepository repository)
        {
            _repository = repository;
        }
        public void OnGet(int id)
        {
            Book = _repository.GetBookById(id);
        }

        public void OnGetUpdate(int id)
        {
            ActionType = (int)ActionTypeEnum.Update;
            Book = _repository.GetBookById(id);
            ViewData["Title"] = Book != null ? $"Edit book {Book.Title} ?" : "Book not found.";
        }

        public IActionResult OnPostUpdate(Book book)
        {
            if (book != null)
            {
                Book bookInDb = _repository.GetBookById(book.Id);
                if (bookInDb != null)
                {
                    bookInDb.Title = book.Title;
                    bookInDb.Category = book.Category;
                    bookInDb.Authors = book.Authors;
                    bookInDb.Publisher = book.Publisher;
                    bookInDb.Year = book.Year;
                    bookInDb.Price = book.Price;
                    bookInDb.Description = book.Description;
                }
            }
            TempData["Message"] = $"Update book {_repository.GetBookById(book.Id).Title} successfully !";
            return Redirect("/");
        }

        public void OnGetDelete(int id)
        {
            ActionType = (int)ActionTypeEnum.Delete;
            Book = _repository.GetBookById(id);
            ViewData["Title"] = Book != null ? $"Are you sure deleting the book : {Book.Id} ?" : "Book not found.";
        }

        public IActionResult OnGetConfirmDelete(int id)
        {
            string title = _repository.GetBookById(id).Title;
            _repository.Books.Remove(_repository.GetBookById(id));
            TempData["Message"] = $"Delete book {title} successfully !";
            return Redirect("/");
        }
    }
}