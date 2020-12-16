using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary2.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool Rented { get; set; } = false;//Vi får kolla hur vi gör detta i Controllern lite mer exakt!
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

    }
}
