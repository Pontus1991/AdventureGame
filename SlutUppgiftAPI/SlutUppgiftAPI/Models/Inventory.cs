using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
    public class Inventory // Lista av böcker samt böcker kan ha ETT library..  
    {
        public int InventoryId { get; set; }
        public int? BookId { get; set; }
        public List<Book> Books { get; set; }
        public Library Library { get; set; }

    }
}
