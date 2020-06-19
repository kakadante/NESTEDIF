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
        public CallCenterModel()
        {

        }
        public void OnGet()
        {

                //var Q1 = "Hello, Good Morning/afternoon/evening. My Name is Cynthia Calling you from ABC, could I speak to Mr./Mrs/Ms./Dr./Prof. ";
                //Console.WriteLine(Q1);

        }

        //public IActionResult OnPost()
        //{

        //    var Q1 = "Hello, Good Morning/afternoon/evening. My Name is Cynthia Calling you from ABC, could I speak to Mr./Mrs/Ms./Dr./Prof. ";
        //    return Q1();
        //}

    }
}