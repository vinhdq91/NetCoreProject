using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetCoreProject1.Models;

namespace NetCoreProject1.Content
{
    public class ObjectBindingModel : PageModel
    {
        public string Message { get; set; }
        public string ResponseMessage(Profile profile) => profile.Age < 18 ?
            $"Sorry, {profile.FullName}. You are not legal to subscribe our site." :
            $"Hello, {profile.FullName}. Thank you for your subscription. You are in class {profile.Class}." +
            $" We will send you a message to you email {profile.Age}.";

        [BindProperty]
        public Profile Profile { get; set; }
        public void OnPost() => Message = ResponseMessage(Profile);

        // Sử dụng OnGet cho object binding cần thêm attribute [FromQuery] trước object truyền vào nếu không lấy dữ liệu từ form
        //public void OnGet([FromQuery] Subscription subscription)
        //{
        //    Message = ResponseMessage(subscription);
        //}

        // Object binding với route data
        //public void OnGet([FromRoute] Subscription subscription)
        //{
        //    Message = ResponseMessage(subscription);
        //}
    }
}
