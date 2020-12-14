using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
    public class ReleaseDate
    {
        public int ReleaseDateId { get; set; }
        public int Release { get; set; }

        public List<Book> Books { get; set; }
    }
}
