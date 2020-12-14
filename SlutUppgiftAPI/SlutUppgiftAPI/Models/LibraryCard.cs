using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
    public class LibraryCard
    {
        public int LibraryCardId { get; set; }
        public int Library_Card { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
