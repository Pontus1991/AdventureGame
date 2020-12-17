using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public long ISBN { get; set; }
        public int ReleaseYear { get; set; }

        public Rental Rental { get; set; }
        public int? RentalId { get; set; }
        public Inventory Inventory { get; set; }
        public int? InventoryId { get; set; }
        public List <Book_Author> Book_Authors { get; set; }

    }
}
