using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [StringLength(4, )]
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public List<Book_Author> Book_Authors { get; set; }
    }
}
