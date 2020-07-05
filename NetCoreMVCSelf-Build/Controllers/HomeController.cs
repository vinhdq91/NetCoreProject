using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCSelf_Build
{
    public class HomeController : Controller
    {
        private readonly List<(string, string)> Presidents = new List<(string, string)>()
        {
            ("Donald", "Trump"),
            ("Barack", "Obama"),
            ("Abraham", "Lincohn")
        };
        public string Index(string id)
        {
            if (string.IsNullOrEmpty(id))
                return "Welcome to ASP Net Core.";
            else
                return $"Hello {id}, Welcome to ASP Net Core.";
        }

        public IActionResult List()
        {
            return View("List", Presidents);
        }
    }
}
