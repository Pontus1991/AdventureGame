using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
    public class Book_Author // Kopplingstabell
    {
        public int AuthorId { get; set; }
        public Author  MyProperty { get; set; }
        public int BookId { get; set; }

        public List<Book_Author> Book_Authors { get; set; }
    }
}
