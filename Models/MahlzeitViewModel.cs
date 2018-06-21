using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AmineV02.Models
{
    public class MahlzeitViewModel
    {
        public string Mahlzeit { get; set; }

        public List<SelectListItem> Mahlzeiten { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "0001", Text = "Riz au Gras" },
            new SelectListItem { Value = "0002", Text = "Reis mit Erdnussbuttersauce"  },
            new SelectListItem { Value = "0003", Text = "Reis mit Sauce" },
            new SelectListItem { Value = "0004", Text = "Poisson a la Braise"  },
        };
    }
}