using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int Ratings { get; set; }
        public List<Book> Books { get; set; }
    }
}
