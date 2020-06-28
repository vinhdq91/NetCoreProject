using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreProject1.Content.TestChangeDirectory
{
    public class IndexModel : PageModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Message { get; set; } = "Initial Requeset";
        public string SayHello() => $"Hello, {FirstName} {LastName}. How are you?";
        public string SayGoodbye()
        {
            return string.Format("Goodbye, {0} {1}. See you again", FirstName, LastName);
        }
        public void OnGet()
        {
            FirstName = "Donald";
            LastName = "Trump";
        }
        
    }
}
