using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreProject1.Content
{
    public class RouteBindingModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FullName { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Age { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Email { get; set; }
        public string Message { get; set; }
        public void OnGet() => Message = Age < 18 ?
            $"Sorry, {FullName}. You are not legal to subscribe our site." :
            $"Hello, {FullName}. Thank you for your subscription. We will send you a message to you email {Email}.";
    }
}
