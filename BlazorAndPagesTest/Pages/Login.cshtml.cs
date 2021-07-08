using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorAndPagesTest.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            Console.WriteLine("Get Enter");
        }

        public void OnPost()
        {
            Console.WriteLine("Post Enter");
        } 
    }
}
