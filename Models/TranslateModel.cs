using System;
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
            new SelectListItem { Value = "gn-po", Text = "Poular"  },
        };
    }


    //TM
    public class TranslateModel
    {
        
        private String phrase;
        private String zielsprache;

        public TranslateModel(String phrase) {
            this.phrase = phrase;
        }

        public String getPhrase() {
            return phrase;

        }

        public String getzielsprache() {
            return zielsprache;
            
        }

        
        public void setPhrase(String phrase) {
            this.phrase = phrase;
        }
        public void setZielsprache(String zielsprache) {
            this.zielsprache = zielsprache;
        }

        public String translatePhrase() {
            // here is my translation model
            switch(zielsprache) {
                case "fr-ar":
                    switch(phrase) {
                        case "lait":
                            return "حليب";
                        case "fromage":
                            return "جبن";
                        case "miel":
                            return "عسل";
                        case "orange":
                            return "برتقال";
                        case "auto":
                            return "سيارة";
                        default:
                            return "للأسف نحن لا نعرف ذلك";
                    }
                      case "ar-fr":
                    switch(phrase) {
                        case "حليب":
                            return "lait";
                        case "جبن":
                            return "fromage";
                        case "عسل":
                            return "miel";
                        case "برتقال":
                            return "orange";
                        case "سيارة":
                            return "auto";
                        default:
                            return "Malheureusement, nous ne le savons pas";
                    }



                case "de":
                    switch(phrase) {
                        case "lait":
                            return "Milch";
                        case "fromage":
                            return "Käse";
                        case "miel":
                            return "Honig";
                        case "orange":
                            return "Orangen";
                        case "auto":
                            return "Wagen";
                        default:
                            return "Das kennen wir leider nicht";
                    }
                    case "en":
                        switch(phrase) {
                            case "lait":
                                return "Milk";
                            case "fromage":
                                return "Cheese";
                            case "miel":
                                return "Hony";
                            case "orange":
                                return "Orange";
                            case "auto":
                                return "car";      
                            default:
                                return "Unfortunately we do not know that";
                        }
                    case "fr":
                        switch(phrase) {
                            case "lait":
                                return "lait";
                            case "fromage":
                                return "Käse";
                            case "miel":
                                return "Honig";
                            case "orange":
                                return "Orangen";
                            case "auto":
                                return "Wagen";
                            default:
                                return "Malheureusement, nous ne le savons pas";
                        }
                    case "gn-po":
                        switch(phrase) {
                            case "lait":
                                return "حليب";
                            case "fromage":
                                return "Käse";
                            case "miel":
                                return "Honig";
                            case "orange":
                                return "Orangen";
                            case "auto":
                                return "Wagen";
                            default:
                                return "Das kennen wir leider nicht";
                        }

                        
                        default:
                        return "Tut uns leid wir kennen diese sprache nicht";

            }
        }

        public String setProjekt(String projekt) {
            projekt="Menschen treffen";
            return projekt;
        }
        
        

        
        
    }
}