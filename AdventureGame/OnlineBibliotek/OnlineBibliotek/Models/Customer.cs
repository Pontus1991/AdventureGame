using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBibliotek.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public LibraryCard LibraryCard { get; set; } //  ska vara lista om man ska kunna ha fler librarykort. 

        public int LibraryCardId { get; set; }
    }
}
