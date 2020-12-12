using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBibliotek.Models
{
    public class Customer
    {
        public int Customer_id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public LibraryCard LibraryCard { get; set; }

        public int LibraryCardId { get; set; }
    }
}
