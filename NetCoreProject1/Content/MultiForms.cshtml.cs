using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace NetCoreProject1.Content
{
    public class MultiFormsModel : PageModel
    {
        public string Message { get; set; } = "Initial Requeset";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Message = "Form Posted";
        }
        public void OnPostDelete(int id)
        {
            Message = "This is post delete for id: " + id;
        }

        public void OnPostEdit(int id)
        {
            Message = "This is post edit for id: " + id;
        }

        public void OnPostView(int id)
        {
            Message = "This is post view for id: " + id;
        }
    }
}
