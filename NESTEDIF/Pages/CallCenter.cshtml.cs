using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NESTEDIF
{
    public class CallCenterModel : PageModel
    {
        var Value = "Hello, Good Morning/afternoon/evening. My Name is Daniel Calling you from ABC, could I speak to Mr./Mrs/Ms./Dr./Prof. ";
        Console.WriteLine(Value);

        public void OnGet()
        {


        }

        public IActionResult OnPost()
        {

        }
    }
}