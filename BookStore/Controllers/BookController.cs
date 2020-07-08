using BookStore.Enums;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private IRepository<BookModel> _bookRepository;
        public BookController(IRepository<BookModel> _bookRepository)
        {
            this._bookRepository = _bookRepository;
        }

        public IActionResult Create()
        {
            BookModel bookModel = new BookModel();
            return View(bookModel);
        }

        [HttpPost]
        public IActionResult Create(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.Create(bookModel);
                return Redirect("/");
            }
            else
                return View(bookModel);
        }

        public IActionResult Detail(int id)
        {
            BookModel bookModel = _bookRepository.Get(id);
            return View(bookModel);
        }

        public IActionResult Edit(int id)
        {
            BookModel bookModel = _bookRepository.Get(id);
            return View(bookModel);
        }

        [HttpPost]
        public IActionResult Edit(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.Edit(bookModel);
                return Redirect("/");
            }
            else
                return View(bookModel);
        }

        public IActionResult Delete(int id)
        {
            _bookRepository.Delete(id);
            return Redirect("/");
        }
    }
}
