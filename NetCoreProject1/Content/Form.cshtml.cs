using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreProject1.Content
{
    //[IgnoreAntiforgeryToken(Order=1001)]
    public class FormModel : PageModel
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public void OnPost(/*string title, string text*/)
        {
            // Cách 1: Truyền parameter là thuộc tính name của các elements khi submit form
            //Title = title;
            //Text = text;

            // Cách 2: Yêu cầu Request lấy giá trị từ các elements khi submit form (Request là đối tượng đóng gói form thành HTTP)
            Title = Request.Form["title"];
            Text = Request.Form["text"];
        }
    }
}
