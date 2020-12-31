using WebbBibliotek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbBibliotek.Models
{
    public class Rental
    {
        public int RentalId { get; set; }

        public DateTime? RentalDate { get; set; } //Även fast det är nullable här, så sköter controllern inmatningen automatiskt

        public DateTime? ReturnDate { get; set; } // Om denna INTE är null så har filmen lämnats tillbaks. 

        public bool Rented { get; set; } = false;

        // Nav prop
        public Inventory Inventory { get; set; }
        public int? InventoryId { get; set; }


        //But what about the other way around? We have an RPG character and want
        //to select the corresponding user? To be able to do that, we add a User
        //property to the Character model, as well.
        // Nav prop
        //public User User { get; set; }
        //public int? UserId { get; set; }

        //public User User { get; set; }
        
        //public int? UserId { get; set; }

        public List<Customer> Customers { get; set; }

        public int? CustomerId { get; set; }

        public bool Returned  
        {
            get
            {
                return ReturnDate == null ? false : true; 
            }
        }



    }
}
