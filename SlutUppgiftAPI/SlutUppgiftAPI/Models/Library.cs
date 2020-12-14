using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        public int? RentalId { get; set; }
        public int BookId { get; set; }

        public List<Inventory> Inventories { get; set; }

        public List<Rental> Rentals { get; set; }


    }
}
