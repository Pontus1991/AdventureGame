using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
    public class LibraryCard
    {
        public int LibraryId { get; set; }
        public int LibraryCardId { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
