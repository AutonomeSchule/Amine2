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
        public IActionResult Index(String wort, String zielsprache)
        {
            TranslateModel tm = new TranslateModel("maitenant tout est parfait");
            ViewData["phrase"] = tm.translatePhrase();
            tm.setPhrase(wort);
            tm.setZielsprache(zielsprache);
            ViewData["phrase2"] = tm.translatePhrase();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Test()
        {
            ViewData["Message"] = "Testbereich";

            return View();
        }

        public IActionResult Platz()
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
