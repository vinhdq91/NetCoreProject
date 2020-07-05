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

        // Detail
        public void OnGet(int id)
        {
            ActionType = (int)ActionTypeEnum.Detail;
            Book = _repository.GetBookById(id);
        }

        // Create
        public void OnGetCreate()
        {
            ActionType = (int)ActionTypeEnum.Create;
            ViewData["Title"] = "Create a book";
        }

        public IActionResult OnPostCreate(Book book)
        {
            if (book != null)
            {
                int id = _repository.Books.OrderByDescending(x => x.Id).ToList()[0].Id + 1;
                book.Id = id;
                _repository.Books.Add(book);
            }
            TempData["Message"] = "Create book successfully !";
            return Redirect("/");
        }

        // Update
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


        // Delete
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