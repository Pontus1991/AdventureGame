using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingHallen4.Models
{
    public class Track
    {  
        public int Id { get; set; }
        public string Title { get; set; } // Bana 3 till ex

        public int Age { get; set; } // Är man över 18 år är det dyrare. Halva priset om man är under 18.
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //The [Column(TypeName = "decimal(18, 2)")] data annotation is required so Entity Framework Core can correctly map Price to currency in the database
       // [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } // Beroende på vilken dag man bokar så är det olika pris.
    }
}
