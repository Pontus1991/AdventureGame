using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? LibraryId { get; set; }
        public LibraryCard LibraryCard { get; set; }
        public Rental Rental { get; set; }
    }
}
