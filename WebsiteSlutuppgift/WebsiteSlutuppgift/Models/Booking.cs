using System;
using System.ComponentModel.DataAnnotations;


namespace WebsiteSlutuppgift.Models
{
    public class Booking
    {
        public Guid Id { get; set; }  // Id är till för att vi ska kunna skapa objekt utan namn.

        // En boking utan ett tracksid dvs banans id fyller ingen funktion
        public Guid TrackId { get; set; }

        [Required(ErrorMessage = "Room name is required.")]
        [StringLength(60, MinimumLength = 3)]
        public string TrackName { get; set; }

        [Required(ErrorMessage = "Room name is required.")]
        [StringLength(60, MinimumLength = 3)]
        public string Booker { get; set; }

        public DateTime From { get; set; } // DateTime gör att vi får upp datumrutan i browsern. 
        public DateTime To { get; set; }
    }
}
