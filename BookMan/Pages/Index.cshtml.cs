using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMan.Models;
using BookMan.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookMan.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository _repository;
        public HashSet<Book> Books => _repository.Books;
        public int Count => _repository.Books.Count;
        public string Message { get; set; } = null;
        public IndexModel(ILogger<IndexModel> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public void OnGet()
        {
            Message = TempData["Message"] != null ? TempData["Message"].ToString() : null;
        }
    }
}
