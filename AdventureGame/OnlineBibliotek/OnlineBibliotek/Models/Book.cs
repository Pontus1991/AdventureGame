using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBibliotek.Models
{
    public class Book
    {
        public int Book_id { get; set; }
        public int boktitel { get; set; }
        public int isbn { get; set; }

        public Rating Rating { get; set; }
        public int RatingId { get; set; }

        public ReleaseDate ReleaseDate { get; set; }
        public int ReleaseDateId { get; set; }

        public Library Library { get; set; }
        public int LibraryId { get; set; }





    }
}
