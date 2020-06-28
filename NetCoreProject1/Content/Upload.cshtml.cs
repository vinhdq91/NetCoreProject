using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreProject1.Content
{
    public class UploadModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        public UploadModel(IWebHostEnvironment environment) => _environment = environment;
        public bool Success { get; set; } = true;
        public string FilePath { get; set; } = string.Empty;
        public void OnPost(IFormFile file)
        {
            try
            {
                FilePath = Path.Combine(_environment.ContentRootPath, "Upload", file.FileName);
                using (FileStream fs = new FileStream(FilePath, FileMode.Create))
                {
                    file.CopyTo(fs);
                    ViewData["file"] = file.FileName;
                }
            }
            catch (Exception)
            {
                Success = false;
            }
        }
    }
}
