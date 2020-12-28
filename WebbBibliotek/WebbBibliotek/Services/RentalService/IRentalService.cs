using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbBibliotek.Models;

namespace WebbBibliotek.Services.RentalService
{
    public interface IRentalService
    {
        List<Rental> GetAllRentals();
        Rental GetRentalById(int id);
        List<Rental> AddRental(Rental newRental);
    }
}
