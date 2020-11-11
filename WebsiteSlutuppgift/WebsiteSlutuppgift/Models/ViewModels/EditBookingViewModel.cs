using System;
using System.Collections.Generic;

namespace WebsiteSlutuppgift.Models.ViewModels
{
    public class EditBookingViewModel
    {
        public List<Track> Tracks { get; set; }
        public Booking Booking { get; set; }
    }
}
