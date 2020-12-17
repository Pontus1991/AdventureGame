using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public long ISBN { get; set; }
        public Rating Rating { get; set; }
        public int? RatingId { get; set; }
        public List<Book_Author> Book_Authors { get; set; }
        public Inventory Inventory { get; set; }

    }
}
