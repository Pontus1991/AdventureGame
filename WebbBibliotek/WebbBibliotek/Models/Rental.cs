using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Rental
    {
        public int RentalId { get; set; }

        public DateTime RentalDate { get; set; } 

        public DateTime? ReturnDate { get; set; } // Om denna INTE är null så har filmen lämnats tillbaks. 

        public bool Rented { get; set; } = false;

        // Nav prop
        public Inventory Inventory { get; set; }

        public int? InventoryId { get; set; }

        public List<Customer> Customers { get; set; }

        public int? CustomerId { get; set; }

        public bool Returned  
        {
            get
            {
                return ReturnDate == null ? false : true;
            }
        }
    }
}
