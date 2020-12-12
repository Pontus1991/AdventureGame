using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBibliotek.Models
{
    public class Rental_Book  // Kopplingstabell
    {
        public int RentalId { get; set; }
        public int BookId { get; set; }

        public Rental Rental { get; set; }

        public Book Book { get; set; }
    }
}
