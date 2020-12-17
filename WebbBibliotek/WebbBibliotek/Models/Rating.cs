using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public List<Book> Books { get; set; }

        [Range(0, 5, ErrorMessage = "Ange ett tal mellan 0 och 5")]
        public int Ratings { get; set; }

    }
}
