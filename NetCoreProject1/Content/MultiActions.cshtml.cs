using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreProject1.Content
{
    public class MultiActionsModel : PageModel
    {
        public string Message { get; set; } = "Default GET method";
        public void OnPostRegister() => Message = "Post register fired";
        public void OnPostRequestInfo() => Message = "Post request info fired";
        public void OnPost() => Message = "Post request info fired";
        public void OnGetClear() => Message = "Get clear fired";
        public void OnGetReset() => Message = "Get reset fired";
        
    }
}
