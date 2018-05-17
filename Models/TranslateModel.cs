using System;
namespace AmineV02.Models
{
    public class TranslateModel
    {
        private String phrase;

        public TranslateModel(String phrase) {
            this.phrase = phrase;
        }

        public String getPhrase() {
            return phrase;
        }

        public void setPhrase(String phrase) {
            this.phrase = phrase;
        }

        public String translatePhrase() {
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
                    return "jetzt läuft alles super";
            }
        }
        
    }
}