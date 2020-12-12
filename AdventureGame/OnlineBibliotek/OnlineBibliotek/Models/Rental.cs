using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBibliotek.Models
{
    public class Rental
    {
        public int Rental_id { get; set; }
        public int? Rental_Date { get; set; } // Able to be NULL
        public int? Returning_Date { get; set; } // Able to be NULL
        public bool OnLoan { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }
    }
}
