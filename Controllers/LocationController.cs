﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmineV02.Models;

namespace AmineV02.Controllers
{
    public class LocationController : Controller
    {

        public IActionResult Index()
        {
            ViewData["Message"] = "Unser Ort";
            return View();
        }

      

    
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
