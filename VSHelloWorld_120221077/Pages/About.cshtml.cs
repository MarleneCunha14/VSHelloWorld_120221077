﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VSHelloWorld_120221077.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
