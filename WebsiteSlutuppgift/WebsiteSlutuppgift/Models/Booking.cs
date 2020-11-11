using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteSlutuppgift.Models
{
    public class Booking
    {
        public Guid Id { get; set; }
        public string TrackName { get; set; }
        public string Booker { get; set; }
        public DateTime From { get; set; } // DateTime gör att vi får upp den där datumrutan i browsern. 
        public DateTime To { get; set; }
        public Guid TrackId { get; internal set; }
    }
}
