using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBibliotek.Models
{
    public class Author
    {
        public int Author_Id { get; set; }
        public string Author_FirstName { get; set; }
        public string Author_LastName { get; set; }

        public ICollection<Author_Book> Author_Book { get; set; } // För att den ska kunna komma in från Booktabellen via kopplingstabellen.




    }
}
