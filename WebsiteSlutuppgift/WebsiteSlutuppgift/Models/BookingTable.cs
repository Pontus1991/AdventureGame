using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteSlutuppgift.Models
{
    public class BookingTable
    {
        public Guid Id { get; set; }  // Id är till för att vi ska kunna skapa objekt utan namn.

        public Guid TableId { get; set; }

        [Required(ErrorMessage = "Table name is required.")]
        [StringLength(60, MinimumLength = 3)]
        public string TableName { get; set; }

        [Required(ErrorMessage = "Table name is required.")]
        [StringLength(60, MinimumLength = 3)]
        public string TableBooker { get; set; }

        public DateTime From { get; set; } // DateTime gör att vi får upp datumrutan i browsern. 
        public DateTime To { get; set; }
        
    }
}
