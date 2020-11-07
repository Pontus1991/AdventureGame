using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgift.Models
{
    public class Track
    {
        public int Id { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Ett eget meddelande")] // Vi kräver att man skriver in nånting här på propertyn name. Måste finnas ett värde i denna property.
        [StringLength(10, MinimumLength = 10)] // Tiosiffrigt telefonnummer
        public string PhoneNumber { get; set; } // Måste ha string här Annars visas inte första nollan. 

        [Required(ErrorMessage = "Ett eget meddelande")] // Vi kräver att man skriver in nånting här på propertyn name. Måste finnas ett värde i denna property.
        
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Ett eget meddelande")] // Vi kräver att man skriver in nånting här på propertyn name. Måste finnas ett värde i denna property.
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), StringLength(30)]
        public string LastName { get; set; }
        public int Price { get; set; }
    }
}
