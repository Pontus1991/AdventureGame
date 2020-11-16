using System;
using System.Collections.Generic;

namespace WebsiteSlutuppgift.Models
{
    public static class  DbContext // Låtsasdatabasen 
    {
        public static List<Track> Tracks { get; set; }
        public static List<Booking> Bookings { get; set; }

        static DbContext()
        {
            Tracks = new List<Track>();
            Bookings = new List<Booking>();

            Seed();
        }

        private static void Seed() 
        {
            var track1 = new Track() { Id = Guid.NewGuid(), Name = "Bana 1" };
            var track2 = new Track() { Id = Guid.NewGuid(), Name = "Bana 2" };
            var track3 = new Track() { Id = Guid.NewGuid(), Name = "Bana 3" };
            var track4 = new Track() { Id = Guid.NewGuid(), Name = "Bana 4" };
            var track5 = new Track() { Id = Guid.NewGuid(), Name = "Bana 5" };
            var track6 = new Track() { Id = Guid.NewGuid(), Name = "Bana 6" };
            var track7 = new Track() { Id = Guid.NewGuid(), Name = "Bana 7" };
            var track8 = new Track() { Id = Guid.NewGuid(), Name = "Bana 8" };
            var track9 = new Track() { Id = Guid.NewGuid(), Name = "Bana 9" };
            var track10 = new Track() { Id = Guid.NewGuid(), Name = "Bana 10" };

            Tracks.Add(track1);
            Tracks.Add(track2);
            Tracks.Add(track3);
            Tracks.Add(track4);
            Tracks.Add(track5);
            Tracks.Add(track6);
            Tracks.Add(track7);
            Tracks.Add(track8);
            Tracks.Add(track9);
            Tracks.Add(track10);
        }
    }
}
