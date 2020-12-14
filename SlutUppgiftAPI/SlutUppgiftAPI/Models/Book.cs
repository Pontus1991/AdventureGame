using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
        public class Book
        {
            public int BookId { get; set; }
            public string BookTitle { get; set; }
            public long ISBN { get; set; }
            public List<Book_Author> Book_Authors { get; set; }
            public int? ReleaseDateId { get; set; }

            public ReleaseDate ReleaseDate { get; set; }
            public int? RatingId { get; set; }
            public Rating Rating { get; set; }
            public int? InventoryId { get; set; }
            public Inventory Inventory { get; set; }
        } 
}
