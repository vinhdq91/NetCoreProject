using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreProject1.Content
{
    public class CheckBoxModel : PageModel
    {
        public List<string> Language { get; set; }
        public List<string> ListLanguage => new List<string>() { 
            "Vietnamese",
            "English",
            "Japanese",
            "Korean",
            "Thailand"
        };
        public void OnPost(List<string> languages)
        {
            Language = languages;
        }
    }
}
