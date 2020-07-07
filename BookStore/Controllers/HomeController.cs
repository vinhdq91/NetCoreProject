using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<BookModel> _bookRepository;
        public HomeController(IRepository<BookModel> _bookRepository)
        {
            this._bookRepository = _bookRepository;
        }
        public IActionResult Index()
        {
            return View(_bookRepository.List());
        }
        public IActionResult Detail(int bookId)
        {
            BookModel book = _bookRepository.Get(bookId);
            return View(book);
        }
    }
}
