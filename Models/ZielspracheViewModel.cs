using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AmineV02.Models
{

    public class ZielspracheViewModel
    {
        public string Zielsprache { get; set; }

        public List<SelectListItem> Zielsprachen { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "ar-fr", Text = "العربية-Francais" },
            new SelectListItem { Value = "fr-ar", Text = "Francais-العربية" },
            new SelectListItem { Value = "de", Text = "Deutsch" },
            new SelectListItem { Value = "en", Text = "English"  },
            new SelectListItem { Value = "fr", Text = "Francais" },
            new SelectListItem { Value = "gn-po", Text = "Poular"},
        };
    }
}