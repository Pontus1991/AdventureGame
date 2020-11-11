using System;
using System.Collections.Generic;

namespace WebsiteSlutuppgift.Models.ViewModels
{
    public class CreateBookingViewModel
    {
        public List<Track> Tracks { get; set; }
        public Booking Booking { get; set; }
    }
}
