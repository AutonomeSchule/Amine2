using System;

namespace AMINEV02.Models
{
    public class Gaeste
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Ankunft { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Phonenumber {get;set;}
    }
}

// beim ersten mal
//dotnet restore
//dotnet aspnet-codegenerator controller -name gaste2Controller -m Gaeste -dc AMINEV02Context --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries 

//bei Änderung
//dotnet aspnet-codegenerator controller -name gaste2Controller -m Gaeste -dc AMINEV02Context --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f

