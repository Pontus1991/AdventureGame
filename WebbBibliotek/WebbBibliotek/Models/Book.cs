using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required] // Översätter det till SQL när vi gör våra migereringar. 
        [MaxLength(40), MinLength(4)]
        public string Title { get; set; }

        [Column(TypeName = "char(4)")] // Måste vara exakt 4 siffror.
        public int ReleaseYear { get; set; }

        [Required]
        public long ISBN { get; set; }

        public Rating Rating { get; set; }
        
        public int? RatingId { get; set; }


        public List<Book_Author> Book_Authors { get; set; }


        public Inventory Inventory { get; set; }

    }
}
