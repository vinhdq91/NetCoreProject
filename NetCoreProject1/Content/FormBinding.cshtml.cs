using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreProject1.Content
{
    [BindProperties]
    public class FormBindingModel : PageModel
    {
        public string Message { get; set; }

        // Parameter binding
        //public void OnPost(string fullName, int age, string email) => Message = age < 18 ? 
        //    $"Sorry, {fullName}. You are not legal to subscribe our site." :
        //    $"Hello, {fullName}. Thank you for your subscription. We will send you a message to you email {email}.";

        // Property binding
        //[BindProperty]
        public string FullName { get; set; }
        //[BindProperty]
        public int Age { get; set; }
        //[BindProperty]
        public string Email { get; set; }
        public void OnPost() => Message = Age < 18 ?
            $"Sorry, {FullName}. You are not legal to subscribe our site." :
            $"Hello, {FullName}. Thank you for your subscription. We will send you a message to you email {Email}.";
    }
}
