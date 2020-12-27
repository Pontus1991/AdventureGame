using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


        // To realize the one-to-many relationship between users and characters, we add properties to our models.
        // Detta blir en tabell "Vänster" om Rental och jag tänker att det är User som blir Customer också i detta fall.
        public List<Rental> Rentals { get; set; } // Använd Rental istället för character som han gör i demot.
        public int? RentalId { get; set; }

    }
}
