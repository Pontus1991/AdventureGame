using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary2.Models
{
    public class Inventory//skapa en many to many
    {
        public int InventoryId { get; set; }
        public int? BookId { get; set; }
        public List<Book> Books { get; set; }
        public int? RentalId { get; set; }//Ha inte med FK här ifrån skiten, en shadowkey kommer skapas automatiskt oavsett vad vi lägger här på grund av dependancy injection
        public List<Rental> Rentals { get; set; }
    }
}
