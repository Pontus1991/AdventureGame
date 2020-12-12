using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBibliotek.Models
{
    public class Author_Book // Kopplingstabell
    {
        public int AuthurId { get; set; }
        public int BookId { get; set; }
        public Author Author { get; set; }
        public Book Book { get; set; }
    }
}
