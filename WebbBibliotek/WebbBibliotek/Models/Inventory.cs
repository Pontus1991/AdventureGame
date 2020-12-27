using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        public List<Book> Books { get; set; }

        public int? BookId { get; set; }

        public List<Rental> Rentals { get; set; }

        public int? RentalId { get; set; }

        public bool Available  // Kolla om boken är tillgänglig
        {
            get
            {
                if (Rentals == null)
                {
                    return true;
                }
                else if (Rentals.Count == 0)
                {
                    return true;
                }
                else if (Rentals.All(r => r.Returned))
                {
                    return true;
                }

                return true; 
            }
                
        }

    }
}
