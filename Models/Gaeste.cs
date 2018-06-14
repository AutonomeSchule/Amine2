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
         public int Email  {get;set;}
         public bool vegan  {get;set;}

    }
}

// beim ersten mal, wenn es noch keine views gibt
//dotnet restore
//dotnet aspnet-codegenerator controller -name gaste2Controller -m Gaeste -dc AMINEV02Context --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries 
//dotnet ef migrations add InitialCreate
//dotnet ef database update



//bei Änderung
//dotnet restore
//dotnet aspnet-codegenerator controller -name gaste2Controller -m Gaeste -dc AMINEV02Context --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f
//dotnet ef migrations add InitialCreate?????
//dotnet ef database update
