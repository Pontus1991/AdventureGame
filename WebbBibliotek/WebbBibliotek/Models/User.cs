using System;
using System.Collections.Generic;
using WebbBibliotek.Models;

namespace BookStoresWebAPI.Models
{
    public partial class User
    {
        public int UserId { get; set; }

        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
 

        public List<Rental> Rentals { get; set; }
        public int? RentalId { get; set; }
    }
}
