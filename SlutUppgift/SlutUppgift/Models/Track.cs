using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgift.Models
{
    public class Track
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; } // Måste ha string här Annars visas inte första nollan. 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Price { get; set; }
    }
}
