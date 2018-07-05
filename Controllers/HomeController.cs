using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmineV02.Models;

namespace AmineV02.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(String wort, String Zielsprache)
        {
            TranslateModel tm = new TranslateModel("maitenant tout est parfait");
            ViewData["phrase"] = tm.translatePhrase();
            tm.setPhrase(wort);
            tm.setZielsprache(Zielsprache);
            ViewData["phrase2"] = tm.translatePhrase();

            ViewData["zielsprache"] = Zielsprache;

            var model = new ZielspracheViewModel();
            return View(model);

        }
           
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
