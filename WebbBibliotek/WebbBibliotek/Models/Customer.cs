using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int LibraryCard { get; set; }

    }
}
