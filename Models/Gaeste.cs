using System;
using System.ComponentModel.DataAnnotations;

namespace AMINEV02.Models
{
    public class Gaeste
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nachname {get; set; }
        public DateTime Ankunft { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required] 
        public string Wunsch { get; set; } 

        public decimal Price { get; set; } 

        [Required]
        [RegularExpression(@"07[6789][0-9]{3}[0-9]{2}[0-9]{2}")]
         public decimal Phonenumber {get;set;}
        public string Email  {get;set;}

        
        public bool vegan  {get;set;}

    

     }
 }                  



// beim ersten mal
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