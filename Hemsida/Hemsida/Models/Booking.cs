using System;

namespace Hemsida.Models
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public string RoomName { get; set; }
        public string Booker { get; set; }
        public DateTime From { get; set; } // DateTime gör att vi får upp den där datumrutan i browsern. 
        public DateTime To { get; set; }
    }
}
