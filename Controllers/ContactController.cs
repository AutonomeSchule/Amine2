﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmineV02.Models;

namespace AmineV02.Controllers
{
    public class ContactController : Controller
    {

        public IActionResult Index()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

      

    
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
